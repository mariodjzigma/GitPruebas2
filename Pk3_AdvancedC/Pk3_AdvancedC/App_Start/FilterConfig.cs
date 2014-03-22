using System.Web;
using System.Web.Mvc;

namespace Pk3_AdvancedC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}