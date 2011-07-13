using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;

namespace DvdPostBL
{

    public class DataProduct : DbContext 
    {
        public DataProduct() 
        {
           
        }
        public int GetNbDvd(uint id, int support_id) 
        {
            var lst = from p in NewDvdPost.Products
                      join dvd in NewDvdPost.ProductDisks on p.ID equals dvd.ProductID
                      where p.MovieID == id && p.ProductSupportID == support_id
                            && dvd.Status == 1

                      select dvd;

            return lst.Count(); 
        }

        public List<string> GetListLangue(uint id, int support_id)
        {
            var lst = from p in NewDvdPost.Products
                      join pl in NewDvdPost.LanguagesProducts on p.ID equals pl.ProductID
                      join pl_l in NewDvdPost.Languages  on pl.LanguageID equals pl_l.ID
                      
                      // left join in linq
                      join pls in NewDvdPost.ProductsSubtitles on p.ID equals pls.ProductDetailID into groupSubtitle
                      from subtitle in groupSubtitle.DefaultIfEmpty(new ProductsSubtitles())

                      // left join in linq
                      join pls_l in NewDvdPost.Subtitles on subtitle.LanguageID equals pls_l.ID into groupSubtitleLanguage
                      from subtitle_l in groupSubtitleLanguage.DefaultIfEmpty(new Subtitles ())

                      // left join in linq
                      join pq in NewDvdPost.ProductQualities on p.ProductQualityID equals pq.ID into groupQuality
                      from quality in groupQuality.DefaultIfEmpty(new ProductQualities())

                      where p.MovieID == id && p.ProductSupportID == support_id
                      select pl_l.Name + " - " + subtitle_l.Name  + " - " + quality.Name;

            //List<string> result = (List<string>)lst.ToList();
            List<string> result = new List<string>();
            foreach (var item in lst )
            {
                result.Add(item);
            }
                    
           
            return lst.ToList() ; 
        }

        //public List<string> GetListSubtitle(uint id, int support_id)
        //{
        //    var lst = from p in NewDvdPost.Products
        //              join pl in NewDvdPost.ProductLanguagesSubtitles on p.ID equals pl.ProductDetailID
        //              join pls_l in NewDvdPost.LangueS on pl.LanguageID equals pls_l.ID
        //              where p.ProductFicheID == id && p.ProductSupportID == support_id
        //              select pls_l.Name; 

        //    return lst.ToList();
        //}
        public string GetStudio(uint id, int support_id) 
        {
            var lst = from p in NewDvdPost.Products
                      join s in NewDvdPost.Studios on p.StudioID equals s.ID into groupStudio
                      from studio in groupStudio.DefaultIfEmpty(new Studios())
                      where p.MovieID == id && p.ProductSupportID== support_id
                      select studio.Name;
            if (lst.Count() == 0) return ""; 
            return lst.First(); 
     
        }

        public List<Display.DisplayProduct> GetList(uint id, string title) 
        {
       
            var lst = from p in NewDvdPost.Products
                      // left join in linq
                      join pc in NewDvdPost.ProductSupports on p.ProductSupportID  equals pc.ID into groupSupport
                      from cat in groupSupport.DefaultIfEmpty(new ProductSupports())
                      
                      // left join in linq
                      join ps in NewDvdPost.ProductStatus on p.ProductStatusID equals ps.ID into groupStatus
                      from status in groupStatus.DefaultIfEmpty(new ProductStatus())

                      // left join in linq
                      join s in NewDvdPost.Studios on p.StudioID equals s.ID into groupStudio
                      from studio in groupStudio.DefaultIfEmpty(new Studios())

                      // left join in linq
                      join pq in NewDvdPost.ProductQualities on p.ProductQualityID equals pq.ID into groupQuality
                      from quality in groupQuality.DefaultIfEmpty(new ProductQualities())

                      join pl in NewDvdPost.LanguagesProducts  on p.ID equals pl.ProductID
                      join pl_l in NewDvdPost.Languages on pl.LanguageID equals pl_l.ID  
 
                      // left join in linq
                      join pls in NewDvdPost.ProductsSubtitles  on p.ID equals pls.ProductDetailID into groupSubtitle
                      from subtitle in groupSubtitle.DefaultIfEmpty(new ProductsSubtitles())

                      // left join in linq
                      join pls_l in NewDvdPost.Subtitles on subtitle.LanguageID equals pls_l.ID into groupSubtitleLanguage
                      from subtitle_l in groupSubtitleLanguage.DefaultIfEmpty(new Subtitles ())
  
                      where p.MovieID == id 
                      select new Display.DisplayProduct { ID = p.ID, 
                                                          Name = title, 
                                                          CreatedAt = p.CreatedAt, 
                                                          UpdatedAt = p.UpdatedAt, 
                                                          Categorie = cat.Name, 
                                                          Quality = quality.Name, 
                                                          End = p.DateEnd, 
                                                          Start = p.DateStart, 
                                                          OldProduct = p.OldProductsID, 
                                                          Status = status.Name, 
                                                          Studio = studio.Name,
                                                          Lang = pl_l.Name,
                                                          Subtitle = subtitle_l.Name };

            List<Display.DisplayProduct> lstp = lst.ToList<Display.DisplayProduct>();
            return lstp;

        }
    }
}
