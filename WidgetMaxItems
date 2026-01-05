using System.ComponentModel;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

[ControllerToolboxItem(Name = "LatestNewsWidget", Title = "Latest News", SectionName = "Custom")]
public class LatestNewsController : Controller
{
    [Category("Content")]
    [DisplayName("Max items")]
    public int MaxItems { get; set; } = 5;

    public ActionResult Index()
    {
        return View("Default", MaxItems);
    }
}
