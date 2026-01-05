using System.Collections.Generic;
using System.Linq;
using Telerik.Sitefinity.Modules.News;
using Telerik.Sitefinity.GenericContent.Model;

public interface INewsService
{
    IList<(string Title, string Url)> Latest(int take);
}

public class NewsService : INewsService
{
    public IList<(string Title, string Url)> Latest(int take)
    {
        var mgr = NewsManager.GetManager();
        return mgr.GetNewsItems()
            .Where(n => n.Status == ContentLifecycleStatus.Live && n.Visible)
            .OrderByDescending(n => n.PublicationDate)
            .Take(take)
            .Select(n => new { n.Title, n.ItemDefaultUrl })
            .ToList()
            .Select(x => (x.Title, x.ItemDefaultUrl))
            .ToList();
    }
}
