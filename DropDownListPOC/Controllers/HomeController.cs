using DropDownListPOC.Models;
using DropDownListPOC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownListPOC.Controllers
{
    public class HomeController : Controller
    {
        private DBEntities db = new DBEntities();

        public ActionResult Index()
        {
            var data = from x in db.BranchList select x;

            // https://jeffprogrammer.wordpress.com/2015/12/11/asp-net-mvc-5-dropdownlist-%E4%B8%8B%E6%8B%89%E9%81%B8%E5%96%AE/
            List<SelectListItem> mySelectItemList = new List<SelectListItem>();

            foreach (var item in data)
            {
                mySelectItemList.Add(new SelectListItem()
                {
                    Text = item.BranchName,
                    Value = item.BranchName,
                    Selected = false
                });
            }

            BranchListViewModels model = new BranchListViewModels() //上面的 Model
            {
                MyList = mySelectItemList
            };

            return View(model);
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