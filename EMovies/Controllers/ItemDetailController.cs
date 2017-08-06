using EMovies.Models;
using System.Linq;
using System.Web.Mvc;

namespace EMovies.Controllers
{
    public class ItemDetailController : Controller
    {
        private EMovieEntities db = new EMovieEntities();

        public ActionResult Index(int id)
        {
            var data = db.Products.SingleOrDefault(p => p.ProductID == id);
            return View(data);
        }
    }
}