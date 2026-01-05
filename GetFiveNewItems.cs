using System;
using System.Linq;
using Telerik.Sitefinity.Modules.News;
using Telerik.Sitefinity.GenericContent.Model;

var mgr = NewsManager.GetManager();
var latest = mgr.GetNewsItems()
    .Where(n => n.Status == ContentLifecycleStatus.Live && n.Visible)
    .OrderByDescending(n => n.PublicationDate)
    .Take(5)
    .Select(n => new { Title = n.Title, Url = n.ItemDefaultUrl })
    .ToList();
