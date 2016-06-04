using System.Web.Mvc;
using SoftwareArchitecture.Data;
using SoftwareArchitecture.Data.Controllers.Impl;

namespace SoftwareArchitecture.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Search()
        {
            ViewBag.Message = "Search result";
            string searchStr = ViewBag.SearchText = this.Request.QueryString["Text"];

            var reguest = new SiteSearchRequest();
            ViewBag.List = reguest.Get(searchStr);

            return View();
        }

        public ActionResult All()
        {
            var reguest = new SiteSearchRequest();
            ViewBag.List = reguest.Get();

            return View();
        }

        public ActionResult Add(SiteInfo site)
        {
            if (!string.IsNullOrEmpty(site?.Title) && !string.IsNullOrEmpty(site.Description))
            {
                var request = new SiteAddRequest();
                if(request.Add(site))
                {
                    return RedirectToAction("All", "Home", new { area = "" });
                }
            }

            return View();
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