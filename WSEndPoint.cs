using System.Linq;
using System.Web.Http;
using Telerik.Sitefinity.Modules.News;
using Telerik.Sitefinity.GenericContent.Model;

[RoutePrefix("api/news")]
public class NewsApiController : ApiController
{
    [HttpGet, Route("")]
    public IHttpActionResult Get(int take = 10)
    {
        var mgr = NewsManager.GetManager();
        var data = mgr.GetNewsItems()
            .Where(n => n.Status == ContentLifecycleStatus.Live && n.Visible)
            .OrderByDescending(n => n.PublicationDate)
            .Take(take)
            .Select(n => new { n.Title, n.ItemDefaultUrl, n.PublicationDate })
            .ToList();

        return Ok(data);
    }
}
