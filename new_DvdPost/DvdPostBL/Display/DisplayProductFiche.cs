using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DvdPostBL.Display
{
    public class DisplayProductFiche
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
        
        private long _Imdb_id;

        public long Imdb_id
        {
            get { return _Imdb_id; }
            set { _Imdb_id = value; }
        }
        private uint? _Saison;

        public uint? Saison
        {
            get { return _Saison; }
            set { _Saison = value; }
        }
        private uint? _Disk;

        public uint? Disk
        {
            get { return _Disk; }
            set { _Disk = value; }
        }
        private string _FicheType;

        public string FicheType
        {
            get { return _FicheType; }
            set { _FicheType = value; }
        }
        private string _Type;

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        private string _Director;

        public string Director
        {
            get { return _Director; }
            set { _Director = value; }
        }

        //public override string ToString()
        //{
        //    return Name + " / " + Imdb_id ;
        //}
    }
}
