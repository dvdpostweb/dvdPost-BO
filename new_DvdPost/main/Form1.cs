using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DbLinq.Factory;
using MySql.Data.MySqlClient;
using DvdPostBL;

namespace main
{
    public partial class Form1 : Form
    {
        const string PATH_PICTURE = "192.168.100.205"; 
        public Form1()
        {
            InitializeComponent();
            initConnection();
            LoadLanguage(); 
        }
//        D:\Ict7\Clients\DvdPost\DbLinq-0.20.1>dbmetal  -provider=MySql -database:new_dvdpost -server:192.168.100.204 -user:root -password:(:melissa:) -namespace:Data -code:NewDvdPost.cs -sprocs

        private void initConnection ()
        {
            //string dbServer = Environment.GetEnvironmentVariable("DbLinqServer") ?? "192.168.100.204";
            //string connStr = String.Format("server={0};user id={1}; password={2}; database={3}", dbServer, "root", "(:melissa:)", "new_dvdpost");

            //string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["prod"].ConnectionString;
            //Data.NewDVdPost db = new Data.NewDVdPost(new MySqlConnection(connStr));


            //var lst = from pf in db.ProductFicheS
            //          from d in db.Directors
            //          from pt in db.ProductTypes 
            //          where pf.DirectorID == d.ID && pf.ProductTypeID == pt.ID 
            //          orderby pf.Name,pf.SaIsoNID,pf.DiskID   
            //          select new {Name = pf.Name, Imdb_id= pf.IMDbID,Saison = pf.SaIsoNID,Disk = pf.DiskID,type_dvd = pt.Name,Director = d.Name };

             //join m in maxdate on new { t.Tech_Quest_ID, t.User_ID, t.StartDate.Date }
             //               equals new { m.Tech_Quest_ID, m.User_ID, m.mdate.Date }
            //var lst = from pf in db.ProductFicheS
            //          join d in db.Directors on pf.DirectorID equals d.ID
            //          join pt in db.ProductTypes on pf.ProductTypeID equals pt.ID
            //          orderby pf.Name, pf.SaIsoNID, pf.DiskID   
            //          select new { Name = pf.Name, Imdb_id = pf.IMDbID, Saison = pf.SaIsoNID, Disk = pf.DiskID, type_dvd = pt.Name, Director = d.Name };

            DataProductFiches p = new DataProductFiches();  
            gridProductFiches.DataSource = p.GetList(); 

        
        }

        private void gridViewProductFiche_DoubleClick(object sender, EventArgs e)
        {
           // uint productFiche_id;
            DvdPostBL.Display.DisplayProductFiche obj;
            obj = (DvdPostBL.Display.DisplayProductFiche)gridViewProductFiche.GetRow(gridViewProductFiche.FocusedRowHandle);
            if (obj == null) return;
            DataProduct p = new DataProduct();
            gridProduct.DataSource = p.GetList(obj.ID,obj.Name);
            xtabCtrlNewDvdPost.SelectedTabPage = xtabPageInfo;
            
            LoadInfo(obj.ID,obj.Type); 

        }

        private void gridViewProduct_DoubleClick(object sender, EventArgs e)
        {
            // uint productFiche_id;
            DvdPostBL.Display.DisplayProduct obj;
            obj = (DvdPostBL.Display.DisplayProduct)gridViewProduct.GetRow(gridViewProduct.FocusedRowHandle);
            if (obj == null) return;
            DataDVD p = new DataDVD();
            gridDVD.DataSource = p.GetList(obj.ID, obj.Name);
            xtabCtrlNewDvdPost.SelectedTabPage = xtabPageDisk;

 
        }
        private void LoadLanguage()
        {
            List<Data.Languages> lst;

            DataLanguage lang = new DataLanguage();

            lst = lang.GetListPrimary();

           
            cmbLanguage.DisplayMember = "name";
            cmbLanguage.ValueMember = "id";
            
            //cmbLanguage.Refresh();  
            cmbLanguage.DataSource = lst;
            cmbLanguage.SelectedIndex = 1;
           
        }

        private void LoadInfoLanguage(uint id,uint language,string type) 
        {
            List<Data.MovieDescriptions> lstDescription;
            DataProductFiches p = new DataProductFiches();
            lstDescription = p.GetDetail(id);

            Data.MovieDescriptions  obj = lstDescription.First(x => x.LanguageID == language);
            string pathFull;
            if (type == "Normal")
            {
                pathFull = @"\\" + PATH_PICTURE + @"\images\" + obj.Picture; 
            }
            else 
            {
                pathFull = @"\\" + PATH_PICTURE + @"\imagesx\" + obj.Picture; 
            }
            imgCover.ImageLocation = pathFull;
            txtDescription.Text = obj.Description;  
        }
        private void addSupport(GroupBox gb,uint id,int support_id) 
        {
            if (gb.Controls.Count > 0 ) 
            {
                Support tmp = (Support)gb.Controls[gb.Controls.Count - 1];
                tmp.Dispose(); 
                gb.Controls.Clear();
            }
            Support uc = new Support();
           // uc.MyLoadEvent +=new Support.MyLoad(uc_MyLoadEvent);          
            uc.Id = id ;
            uc.Support_id = support_id ;
            
            gb.Controls.Add(uc);
            uc.LoadData(); 
            gb.Visible = uc.IsDisplay;
        }

    //    void uc_MyLoadEvent(object sender, EventArgs e)
    //    {
    //        Support sp = (Support)sender;
    //        GroupBox gb;
    //        switch (sp.Support_id)
    //{
    //            case 1:
    //                gb = gbDvd;
    //                    break;
    //            case 2 :
    //                gb = gbBlueray; 
    //                break;
    //            case 3 :
    //                gb = gbVod; 
    //                break;
    //            default:
    //                gb = gbDvd;
    //                break;
    //     }  
    //        gb.Visible = sp.IsDisplay; 
    //    }
       
        private void LoadInfo(uint id, string type)
        {
            uint lng;    
            
            lng = (uint)cmbLanguage.SelectedValue;
            LoadInfoLanguage(id, lng,type);

            addSupport(gbDvd, id, 1);
            addSupport(gbBlueray, id, 2);
            addSupport(gbVod, id, 3);  
            
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbLanguage.SelectedIndex == -1) return;
            DvdPostBL.Display.DisplayProductFiche obj;
            obj = (DvdPostBL.Display.DisplayProductFiche)gridViewProductFiche.GetRow(gridViewProductFiche.FocusedRowHandle);
            if (obj != null)
            {
                uint lng;
                lng = (uint)cmbLanguage.SelectedValue;
                LoadInfoLanguage(obj.ID,lng,obj.Type);
            }
        }
    }
}
