using System;
using System.Linq;
using Telerik.Sitefinity.Modules.News;
using Telerik.Sitefinity.GenericContent.Model;

var from = DateTime.UtcNow.AddDays(-30);

var mgr = NewsManager.GetManager();
var items = mgr.GetNewsItems()
    .Where(n => n.Status == ContentLifecycleStatus.Live && n.Visible && n.PublicationDate >= from)
    .OrderByDescending(n => n.PublicationDate)
    .ToList();
