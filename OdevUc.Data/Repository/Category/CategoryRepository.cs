using OdevUc.Data.Context;
using OdevUc.Data.Domain;

namespace OdevUc.Data.Repository.Base;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(OdevDbContext context) : base(context)
    {

    }

    public IEnumerable<Category> FindByName(string name)
    {
        var list = dbContext.Set<Category>().Where(c => c.Name.Contains(name)).ToList();
        return list;
    }

    public int GetAllCount()
    {
        return dbContext.Set<Category>().Count();
    }
}

