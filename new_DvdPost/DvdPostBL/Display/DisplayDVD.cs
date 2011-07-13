using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DvdPostBL.Display
{
    public class DisplayDVD
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        
        private uint _ID;
        public uint ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private uint _Disk;
        public uint Disk
        {
            get { return _Disk; }
            set { _Disk = value; }
        }

        private string _Status;
        public string Status
        {
            get { return _Status ; }
            set { _Status = value; }
        }
        private DateTime _CreatedAt;
        public DateTime CreatedAt
        {
            get { return _CreatedAt; }
            set { _CreatedAt = value; }
        }
        private DateTime _UpdatedAt;
        public DateTime UpdatedAt
        {
            get { return _UpdatedAt; }
            set { _UpdatedAt = value; }
        }
              
        private int? _BoxID;
        public int? BoxID
        {
            get { return _BoxID; }
            set { _BoxID = value; }
        }

        private uint? _Position;
        public uint? Position
        {
            get { return _Position; }
            set { _Position = value; }
        }
        private string _where;

        public string Where
        {
            get { return _where; }
            set { _where = value; }
        }
        //public override string ToString()
        //{
        //    return Name + " / " + Imdb_id ;
        //}
    }
}
