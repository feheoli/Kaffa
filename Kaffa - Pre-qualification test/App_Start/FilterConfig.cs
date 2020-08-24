using System.Web;
using System.Web.Mvc;

namespace Kaffa___Pre_qualification_test
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
