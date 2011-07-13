using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DvdPostBL; 

namespace main
{
    public partial class Support : UserControl
    {
        public delegate void MyLoad(object sender,EventArgs e);
        public event MyLoad MyLoadEvent;

        public enum Support_Type 
        { 
            DVD = 1,
            BLUERAY = 2,
            VOD = 3

        }
        private uint _id;

        public uint Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _support_id;

        public int Support_id
        {
            get { return _support_id; }
            set { _support_id = value; }
        }

        private bool _isdisplay;

        public bool IsDisplay
        {
            get { return _isdisplay; }
        }


        public Support()
        {
            InitializeComponent();
        }

        public void LoadData() 
        {
            DataProduct p = new DataProduct();
            string studio = p.GetStudio(Id, Support_id);

            lblStudioValue.Text = studio;

            List<string> lstLangue = p.GetListLangue(Id, Support_id);
            ctrlLanguageSubtitle.DataSource = lstLangue;
          
            //List<string> lstSubtitle = p.GetListSubtitle(Id, Support_id);
            //listSubtitle.DataSource = lstSubtitle;

            int nbDvd = p.GetNbDvd(Id, Support_id);
            lblNbDvd.Text = nbDvd.ToString() ;


            _isdisplay = nbDvd > 0 || Support_id == (int)Support_Type.VOD && lstLangue.Count > 0 ;
            lblNbDvd.Visible =lblDvd.Visible = nbDvd > 0;   
  
        }

        //private void Support_Load(object sender, EventArgs e)
        //{
        //    LoadData();
        //    if (MyLoadEvent != null) 
        //    {
        //        MyLoadEvent(this, e); 
        //    }
           
           
        //}

    }
}
