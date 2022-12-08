using Microsoft.EntityFrameworkCore;

namespace Model;
public class BlogContext : DbContext
{
    public BlogContext()
    {
        var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        DBPath = System.IO.Path.Join(path,"Lab4.db");
    }

 protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DBPath}");

    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    public string DBPath { get; }
}