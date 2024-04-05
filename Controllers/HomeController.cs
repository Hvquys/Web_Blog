using Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace Web_Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPostsPartialView()
        {
            var list = new List<post>();
            try
            {
                list = new Blog.Interface.BlogManagerment().GetListPost();
            }
            catch (Exception ex)
            {

                throw;
            }
            return PartialView(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}