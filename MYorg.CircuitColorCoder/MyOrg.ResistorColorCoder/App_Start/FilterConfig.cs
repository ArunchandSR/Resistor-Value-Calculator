using System.Web;
using System.Web.Mvc;

namespace MyOrg.ResistorColorCoder
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
