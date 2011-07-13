using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;

namespace DvdPostBL
{

    public class DataDVD : DbContext 
    {
        public DataDVD() 
        {
           
        }

        public List<Display.DisplayDVD> GetList(uint id, string title) 
        {
   
            var lst = from p in NewDvdPost.ProductDisks 
                      
                      // left join in linq
                      join ps in NewDvdPost.ProductDVdStatus on p.Status equals ps.ID into groupStatus
                      from status in groupStatus.DefaultIfEmpty(new ProductDVdStatus())

                      // left join in linq
                      join pw in NewDvdPost.ProductDVdWhere on p.WhereID equals pw.ID into groupWhere
                      from gwhere in groupWhere.DefaultIfEmpty(new ProductDVdWhere())
                      
                      // left join in linq
                      where p.ProductID == id
                      select new Display.DisplayDVD { ID = p.ProductID,
                                                      Disk = p.DVdID,   
                                                      Name = title, 
                                                      CreatedAt = p.CreatedAt, 
                                                      UpdatedAt = p.UpdatedAt, 
                                                      Status = status.Name, 
                                                      BoxID = p.BoxID ,
                                                      Position = p.BoxPOs,
                                                      Where = gwhere.Name};

            List<Display.DisplayDVD> lstp = lst.ToList<Display.DisplayDVD>();
            return lstp;

        }
    }
}
