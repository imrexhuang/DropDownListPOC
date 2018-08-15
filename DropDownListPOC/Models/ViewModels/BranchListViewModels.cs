using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// https://jeffprogrammer.wordpress.com/2015/12/11/asp-net-mvc-5-dropdownlist-%E4%B8%8B%E6%8B%89%E9%81%B8%E5%96%AE/

namespace DropDownListPOC.Models.ViewModels
{
    public class BranchListViewModels
    {
        public string BranchName { get; set; }
        public IEnumerable<SelectListItem> MyList { get; set; }
    }
}