namespace RepositoryPattern.RepoPattern;

public class BlogPost
{
    public string Name {get; set; }

    public string Description {get; set;}

    public DateTime PublicDate {get; set;}

    public Author Author { get; set;}

    public string URL { get; set;}


    public Blog Blog { get; set;}
    

}