namespace RepositoryPattern.RepoPattern;

public class Blog : IAggregateRoot
{
    public string URL {get; set;}
    public string Name {get; set; }

    public string? Description {get; set;}

    public List<BlogPost>? BlogPost {get; set;}

    protected Blog() {}

    public Blog(string url, string name)
    {
       this.URL = url;
       this.Name = name;
    }

    public Blog(string url, string name, string description)
    :this(url,name)
    {
      /* this.URL = url;
       this.Name = name;*/
       this.Description = description;
    }

}