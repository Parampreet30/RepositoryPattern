namespace RepositoryPattern.RepoPattern;

public class Blog : IAggregateRoot
{
    public string URL {get; set;}
    public string Name {get; set; }

    public string Description {get; set;}

    public List<BlogPost> BlogPost {get; set;}

}