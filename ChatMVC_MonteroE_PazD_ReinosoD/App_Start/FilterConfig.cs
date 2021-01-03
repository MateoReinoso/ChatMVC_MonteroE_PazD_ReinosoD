using System.Web;
using System.Web.Mvc;

namespace ChatMVC_MonteroE_PazD_ReinosoD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
