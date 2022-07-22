using System.Web;
using System.Web.Mvc;

namespace EClerx.MVC.Day26
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
