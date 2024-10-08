namespace RepositoryPattern.RepoPattern;

using Microsoft.EntityFrameworkCore;

public class BlogContext : DBContext(){
public DbSet<Author> Authors = null;

public DbSet<Blog> Blogs = null;

public DbSet<BlogPost> BlogPosts = null;

public BlogContext(DbContextOptions<BlogContext> options) : base(options){}

}