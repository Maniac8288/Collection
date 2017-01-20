using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult About(products test)
        {
            List<products> products = new List<products>();
           
                products.Add(new Models.products()
                {
                    Name = Request.Form["Name"],
                    Color = " "+test.Color
                });
            return View(products);

        }
        [HttpPost]
        public string Array(List<string> names)
        {
            string fin = "";
            for (int i = 0; i < names.Count; i++)
            {
                fin += names[i] + ";  ";
            }
            return fin;
        }
      
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetAuthor(Author author)
        {
            return View();
        }
    }
}