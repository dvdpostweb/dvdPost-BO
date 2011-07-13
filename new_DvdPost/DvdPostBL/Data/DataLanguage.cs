using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;

namespace DvdPostBL
{
  public  class DataLanguage : DbContext 
    {
        public List<Languages> GetList() 
        {
            var lst = from l in NewDvdPost.Languages 
                      orderby l.Name
                      select l;

            return lst.ToList(); 
        }
        /// <summary>
        /// Language primaire (FR,NL,EN)
        /// </summary>
        /// <returns></returns>
        public List<Languages> GetListPrimary()
        {
            var lst = from l in NewDvdPost.Languages
                      where l.ID <= 3 
                      orderby l.Name
                      select l;

            return lst.ToList(); 
 
        }
    }
}
