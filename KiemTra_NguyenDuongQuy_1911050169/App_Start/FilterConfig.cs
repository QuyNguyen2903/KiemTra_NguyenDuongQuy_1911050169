using System.Web;
using System.Web.Mvc;

namespace KiemTra_NguyenDuongQuy_1911050169
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
