using System.Web;
using System.Web.Mvc;

namespace ITNOVA_SOLUTION
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
