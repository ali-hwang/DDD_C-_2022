// See https://aka.ms/new-console-template for more information
using Model;
var dbpath = new BlogContext();
Console.WriteLine($"path:{dbpath.DBPath}");

dbpath.Add(new Blog{Uri="www.systex.com.tw"});
dbpath.Add(new Blog{Uri="www.systex1.com.tw"});
dbpath.Add(new Blog{Uri="www.systex2.com.tw"});
dbpath.SaveChanges();

Console.WriteLine("修改一下資料");
var blog = dbpath.Blogs!.OrderBy(b => b.BlogId).Last();
blog.Uri = "https://www.cwb.gov.tw";
blog.Posts.Add(new Post { Title = "urgent", Content = "Type is coming" });
blog.Posts.Add(new Post { Title = "urgent", Content = "Earthquake last night" });
dbpath.SaveChanges();





var blogs = dbpath.Blogs.OrderBy(b => b.BlogId);
foreach(var db in blogs)
{
    Console.WriteLine($"{db.BlogId},{db.Uri}");
}
