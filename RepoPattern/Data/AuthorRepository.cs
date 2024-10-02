
namespace RepositoryPattern.RepoPattern;

public class AuthorRepository : IRepository<Author>
{
    public static IList<Author> _db = new List<Author>();

    public Author Create(params object[] args)
    {
        throw new NotImplementedException();
    }

    public void Delete(object Id)
    {
        Author? author = this.FindById(Id);
       /*Author? author =  _db.Where(a => a.Email == Id.ToString()).SingleOrDefault();*/

      /* if(author is null)
       {
        throw new ArgumentException("Author email must exist.");
       }*/
       _db.Remove(author);
    }

    public Author FindById(object Id)
    {
         Author? author = _db.Where(a => a.Email == Id.ToString()).SingleOrDefault();
         if(author is null)
       {
        throw new ArgumentException("Author email must exist.");
       }
       return author;
    }

    public IList<Author> GetAll()
    {
        return_db;
    }

    public void Update(object Id, Author model)
    {
        Author author = this.FindById(Id);
        if (model.Email != Id.ToString())
        {
            throw new ArgumentException("Model Id's must match");
        }
        _db.Remove(author);
        _db.Add(model);
    }
}