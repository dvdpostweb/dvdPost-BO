using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;

namespace DvdPostBL
{

    public class DataProductFiches : DbContext 
    {
        public DataProductFiches() 
        {
           
        }
        public List<MovieDescriptions> GetDetail(uint id) 
        {
            var lst = from pfd in NewDvdPost.MovieDescriptions
                      where pfd.MovieID == id
                      select pfd;

            return lst.ToList(); 
        }
        public List<Display.DisplayProductFiche> GetList() 
        {
            var lst = from pf in NewDvdPost.Movies 
                      join d in NewDvdPost.Directors on pf.DirectorID equals d.ID into groupDirector
                      from director in groupDirector.DefaultIfEmpty(new Directors())  
                      join pt in NewDvdPost.ProductTypes on pf.MovieTypeID equals pt.ID
                      join pft in NewDvdPost.MovieTypes on pf.ProductFicheTypeID equals pft.ID  
                      orderby pf.Name, pf.SaIsoNID, pf.DiskID
                      select new Display.DisplayProductFiche { ID = pf.ID,Name = pf.Name, Imdb_id = pf.IMDbID, Saison = pf.SaIsoNID, Disk = pf.DiskID, Type = pt.Name, Director = director.Name,FicheType = pft.Name  };

            List<Display.DisplayProductFiche> lstp = lst.ToList<Display.DisplayProductFiche>();
            return lstp;

        }
    }
}
