using OdevUc.Base.Model;

namespace OdevUc.Business.Category;

public class CategoryResponse : BaseResponse
{
    public string Name { get; set; }
    public int Order { get; set; }
}