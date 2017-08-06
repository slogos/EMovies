using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMovies.Models
{
    public class ProductsModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PaginationModel Pagination { get; set; }
        public int CategoryID { get; set; }

        public SelectList Categories()
        {
            EMovieEntities db = new EMovieEntities();
            var categories = from c in db.Categories
                             orderby c.CategoryName
                             select new
                             {
                                 c.CategoryID,
                                 c.CategoryName,
                             };
            return new SelectList(categories, "CategoryID", "CategoryName");
        }
    }
}