using EMovies.Models;
using System.Web.Mvc;

namespace EMovies.Controllers
{
    public class RegisterController : Controller
    {
        private EMovieEntities db = new EMovieEntities();

        public ActionResult Index()
        {
            return View(new Customer());
        }

        public RedirectToRouteResult Register(Customer customer)
        {
            customer.Password = SHA256.Encode(customer.Password);

            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


    }
}