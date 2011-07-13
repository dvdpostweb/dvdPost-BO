using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Data;

namespace DvdPostBL
{
    public class DbContext
    {
        private NewDVdPost _newDvdPost ;

        public NewDVdPost NewDvdPost
        {
            get
            {
                if (_newDvdPost == null) 
                {
                    string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["prod"].ConnectionString;              
                    _newDvdPost = new NewDVdPost(new MySqlConnection(connStr)); 
                }
                    return _newDvdPost; }
            set { _newDvdPost = value; }
        }
       
    }
}
