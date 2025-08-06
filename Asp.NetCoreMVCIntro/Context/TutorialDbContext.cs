using Asp.NetCoreMVCIntro.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.NetCoreMVCIntro.Context;

public class TutorialDbContext: DbContext
{
    public TutorialDbContext(DbContextOptions<TutorialDbContext> options): base 
        (options)
    {
        
    }
    public DbSet<Tutorial> Tutorials { get; set; }
    public DbSet<Article> Articles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>().HasData(
            new Article
            {
                ArticleId = 1,
                ArticleTitle = "Introduction to C#",
                ArticleContent = "C# in an Object Oriented Language",
                TutorialId = 1,
            }
            );
	}

}
