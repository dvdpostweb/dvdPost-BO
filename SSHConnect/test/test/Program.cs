using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            SSH.SSHMain main = new SSH.SSHMain() ;
            main.execBackupAboProcess(); 
        }
    }
}
