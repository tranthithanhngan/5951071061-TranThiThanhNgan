using System.Web;
using System.Web.Mvc;

namespace TRANTHITHANHNGAN_5951071061
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
