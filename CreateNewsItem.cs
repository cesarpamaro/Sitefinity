using System;
using Telerik.Sitefinity.Modules.News;

var mgr = NewsManager.GetManager();
var item = mgr.CreateNewsItem();

item.Title = "Hello Sitefinity";
item.Content = "<p>Content body</p>";
item.PublicationDate = DateTime.UtcNow;
item.Visible = true;

mgr.SaveChanges();
