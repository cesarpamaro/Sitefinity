using System.Web.Mvc;

public class CachedWidgetController : Controller
{
    [OutputCache(Duration = 300, VaryByParam = "none")]
    public ActionResult Index() => View("Default");
}
