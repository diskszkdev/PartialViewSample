using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace PartialViewSample.Pages.SP402
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public PartialViewResult OnGetPartial()
        {
            var menus = new List<string>
            {
                "aaaaa","bbbbb","ccccc","ddddd","eeeee"
            };

            return new PartialViewResult
            {
                ViewName = "_FavoritePartial",
                ViewData = new ViewDataDictionary<List<string>>(ViewData,menus)
            };
        }

        public PartialViewResult OnGetMenuPartial()
        {
            var menus = new List<string>
            {
                "あああああ","いいいいい","ううううう","えええええ","おおおおお"
            };

            return new PartialViewResult
            {
                ViewName = "_MenuPartial",
                ViewData = new ViewDataDictionary<List<string>>(ViewData, menus)
            };
        }
    }
}