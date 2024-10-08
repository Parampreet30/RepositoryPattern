namespace RepositoryPattern.RepoPattern;

public class Blog : IAggregateRoot
{
   private IList<BlogPost> _blogposts = new List<BlogPost>();
    public string URL {get; set;}
    public string Name {get; set; }

    public string? Description {get; set;}

    public IReadOnlyCollection<BlogPost>? BlogPosts => _blogposts.AsReadOnly();     //{get; set;}

    protected Blog() {}

    public Blog(string url, string name)
    {
     // if (string.IsNullOrWhiteSpace(url))
      /*{
         throw new ArgumentNullException("Url must not be null or contain only whitespace.");
      }*/

       //Uri uri = new Uri(url);
       if(Uri.TryCreate(url, new UriCreationOptions(){ DangerousDisablePathAndQueryCanonicalization = false}));
       {
         throw new UriFormatException("Url must be in correct format.");
       }
       //this.URL = url;
       //this.Name = name;
    }

    public Blog(string url, string name, string description)
    :this(url,name)
    {
      /* this.URL = url;
       this.Name = name;*/
       this.Description = description;
    }
    public void AddBlogPost(string url, string name){
      _blogposts.Add(new BlogPost() {URL = url, Name = name });
    }

}