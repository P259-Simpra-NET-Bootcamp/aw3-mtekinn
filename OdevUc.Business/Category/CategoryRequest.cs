using OdevUc.Base.Model;

namespace OdevUc.Business.Category;

public class CategoryRequest : BaseRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Order { get; set; }
}