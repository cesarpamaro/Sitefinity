using System.Web.Mvc;

public class AuthAwareController : Controller
{
    public ActionResult Index()
    {
        if (User?.Identity?.IsAuthenticated == true)
            return Content("Hello authenticated user");

        return Content("Hello anonymous user");
    }
}
