using OdevUc.Data.Domain;
using OdevUc.Data.Repository.Base;

namespace OdevUc.Data.Repository;

public interface ICategoryRepository : IGenericRepository<Category>
{
    IEnumerable<Category> FindByName(string name);
    int GetAllCount();
}

