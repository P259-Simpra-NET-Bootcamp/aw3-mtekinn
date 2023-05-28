using OdevUc.Data.Context;

namespace OdevUc.Data.Repository.Product;

public class ProductRepository : GenericRepository<Domain.Product>, IProductRepository
{
    public ProductRepository(OdevDbContext context) : base(context)
    {

    }
}
