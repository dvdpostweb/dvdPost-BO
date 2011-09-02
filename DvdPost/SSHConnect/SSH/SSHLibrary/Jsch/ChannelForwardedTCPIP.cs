using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Tamir.SharpSsh.jsch
{
	/* -*-mode:java; c-basic-offset:2; -*- */
	/*
	Copyright (c) 2002,2003,2004 ymnk, JCraft,Inc. All rights reserved.

	Redistribution and use in source and binary forms, with or without
	modification, are permitted provided that the following conditions are met:

	  1. Redistributions of source code must retain the above copyright notice,
		 this list of conditions and the following disclaimer.

	  2. Redistributions in binary form must reproduce the above copyright 
		 notice, this list of conditions and the following disclaimer in 
		 the documentation and/or other materials provided with the distribution.

	  3. The names of the authors may not be used to endorse or promote products
		 derived from this software without specific prior written permission.

	THIS SOFTWARE IS PROVIDED ``AS IS'' AND ANY EXPRESSED OR IMPLIED WARRANTIES,
	INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
	FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL JCRAFT,
	INC. OR ANY CONTRIBUTORS TO THIS SOFTWARE BE LIABLE FOR ANY DIRECT, INDIRECT,
	INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
	LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA,
	OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
	LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
	NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE,
	EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
	*/

	class ChannelForwardedTCPIP : Channel
	{

		static System.Collections.ArrayList pool=new System.Collections.ArrayList();

		private const int LOCAL_WINDOW_SIZE_MAX=0x20000;
		private const int LOCAL_MAXIMUM_PACKET_SIZE=0x4000;

		internal String host;
		internal int lport;
		internal int rport;

		internal ChannelForwardedTCPIP():base()
		{
			setLocalWindowSizeMax(LOCAL_WINDOW_SIZE_MAX);
			setLocalWindowSize(LOCAL_WINDOW_SIZE_MAX);
			setLocalPacketSize(LOCAL_MAXIMUM_PACKET_SIZE);
		}

		public override void init ()
		{
			try
			{ 
				IPEndPoint ep = new IPEndPoint(Dns.GetHostByName(host).AddressList[0], lport);
				Socket socket = new Socket(ep.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
				socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, 1);
				socket.Connect(ep);
				io=new IO();
				NetworkStream ns = new NetworkStream( socket );
				io.setInputStream( ns );
				io.setOutputStream( ns );
			}
			catch(Exception e)
			{
				Console.WriteLine(e);
			}
		}

		public override void run()
		{
			thread=Thread.CurrentThread;
			Buffer buf=new Buffer(rmpsize);
			Packet packet=new Packet(buf);
			int i=0;
			try
			{
				while(thread!=null && io!=null && io.ins!=null)
				{
					i=io.ins.Read(buf.buffer, 
						14, 
						buf.buffer.Length-14
						-16 -20 // padding and mac
						);
					if(i<=0)
					{
						eof();
						break;
					}
					packet.reset();
					if(_close)break;
					buf.putByte((byte)Session.SSH_MSG_CHANNEL_DATA);
					buf.putInt(recipient);
					buf.putInt(i);
					buf.skip(i);
					session.write(packet, this, i);
				}
			}
			catch
			{
				//System.out.println(e);
			}
			//thread=null;
			//eof();
			disconnect();
		}
		public override void disconnect()
		{
			close();
			thread=null;
			try
			{
				if(io!=null)
				{
					if(io.ins!=null)io.ins.Close();
					if(io.outs!=null)io.outs.Close();
				}
			}
			catch
			{
				//e.printStackTrace();
			}
			io=null;
			Channel.del(this);
		}
		internal override void  getData(Buffer buf)
		{
			setRecipient(buf.getInt());
			setRemoteWindowSize(buf.getInt());
			setRemotePacketSize(buf.getInt());
			byte[] addr=buf.getString();
			int port=buf.getInt();
			byte[] orgaddr=buf.getString();
			int orgport=buf.getInt();

			/*
			System.out.println("addr: "+new String(addr));
			System.out.println("port: "+port);
			System.out.println("orgaddr: "+new String(orgaddr));
			System.out.println("orgport: "+orgport);
			*/

			lock(pool)
			{
				for(int i=0; i<pool.Count; i++)
				{
					Object[] foo=(Object[])(pool[i]);
					if(foo[0]!=session) continue;
					if((int)foo[1]!=port) continue;
					this.rport=port;
					this.host=(String)foo[2];
					this.lport=(int)foo[3];
					break;
				}
				if(host==null)
				{
					Console.WriteLine("??");
				}
			}
		}

		internal static Object[] getPort(Session session, int rport)
		{
			lock(pool)
			{
				//Object[] foo=null;
				for(int i=0; i<pool.Count; i++)
				{
					Object[] bar=(Object[])(pool[i]);
					if(bar[0]!=session) continue;
					if((int)bar[1]!=rport) continue;
					return bar;
				}
				return null;
			}
		}

		internal static String[] getPortForwarding(Session session)
		{
			System.Collections.ArrayList foo=new System.Collections.ArrayList();
			lock(pool)
			{
				for(int i=0; i<pool.Count; i++)
				{
					Object[] bar=(Object[])(pool[i]);
					if(!bar[0].Equals(session)) continue;
					foo.Add(bar[1]+":"+bar[2]+":"+bar[3]);
				}
			}
			String[] bar2=new String[foo.Count];
			for(int i=0; i<foo.Count; i++)
			{
				bar2[i]=(String)(foo[i]);
			}
			return bar2;
		}

		internal static void addPort(Session session, int port, String host, int lport) 
		{
			lock(pool)
			{
				if(getPort(session, port)!=null)
				{
					throw new JSchException("PortForwardingR: remote port "+port+" is already registered.");
				}
				Object[] foo=new Object[4];
				foo[0]=session; foo[1]=port;
				foo[2]=host; foo[3]=lport;
				pool.Add(foo);
			}
		}
		internal  static void delPort(ChannelForwardedTCPIP c)
		{
			delPort(c.session, c.rport);
		}
		internal static void delPort(Session session, int rport)
		{
			lock(pool)
			{
				Object[] foo=null;
				for(int i=0; i<pool.Count; i++)
				{
					Object[] bar=(Object[])(pool[i]);
					if(!bar[0].Equals(session)) continue;
					if((int)bar[1]!=rport) continue;
					foo=bar;
					break;
				}
				if(foo==null)return;
				pool.Remove(foo);	
			}

			Buffer buf=new Buffer(100); // ??
			Packet packet=new Packet(buf);

			try
			{
				// byte SSH_MSG_GLOBAL_REQUEST 80
				// string "cancel-tcpip-forward"
				// boolean want_reply
				// string  address_to_bind (e.g. "127.0.0.1")
				// uint32  port number to bind
				packet.reset();
				buf.putByte((byte) 80/*SSH_MSG_GLOBAL_REQUEST*/);
				buf.putString( Util.getBytes("cancel-tcpip-forward"));
				buf.putByte((byte)0);
				buf.putString(Util.getBytes("0.0.0.0"));
				buf.putInt(rport);
				session.write(packet);
			}
			catch
			{
				//    throw new JSchException(e.toString());
			}
		}
		internal static void delPort(Session session)
		{
			int[] rport=null;
			int count=0;
			lock(pool)
			{
				rport=new int[pool.Count];
				for(int i=0; i<pool.Count; i++)
				{
					Object[] bar=(Object[])(pool[i]);
					if(bar[0].Equals(session)) 
					{
						rport[count++]=((int)bar[1]);
					}
				}
			}
			for(int i=0; i<count; i++)
			{
				delPort(session, rport[i]);
			}
		}
	}

}
