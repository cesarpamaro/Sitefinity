[ApiController]
[Route("api/content/news")]
public class NewsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetLatest()
    {
        var mgr = NewsManager.GetManager();
        var items = mgr.GetNewsItems()
            .Where(n => n.Status == ContentLifecycleStatus.Live && n.Visible)
            .Select(n => new { n.Title, n.ItemDefaultUrl, n.PublicationDate })
            .ToList();
        return Ok(items);
    }
}
