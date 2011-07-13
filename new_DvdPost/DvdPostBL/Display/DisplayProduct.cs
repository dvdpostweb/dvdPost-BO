using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DvdPostBL.Display
{
    public class DisplayProduct
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

        private string _Categorie;
        public string Categorie
        {
            get { return _Categorie; }
            set { _Categorie = value; }
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
        private string _Status;
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        private string _Studio;
        public string Studio
        {
            get { return _Studio; }
            set { _Studio = value; }
        }
        private string _Quality;
        public string Quality
        {
            get { return _Quality; }
            set { _Quality = value; }
        }

        private DateTime? _Start;
        public DateTime? Start
        {
            get { return _Start; }
            set { _Start = value; }
        }
        private DateTime? _End;
        public DateTime? End
        {
            get { return _End; }
            set { _End = value; }
        }
        private uint? _OldProduct;
        public uint? OldProduct
        {
            get { return _OldProduct; }
            set { _OldProduct = value; }
        }

        private string _lang;

        public string Lang
        {
            get { return _lang; }
            set { _lang = value; }
        }
        private string _subtitle;

        public string Subtitle
        {
            get { return _subtitle; }
            set { _subtitle = value; }
        }
        //public override string ToString()
        //{
        //    return Name + " / " + Imdb_id ;
        //}
    }
}
