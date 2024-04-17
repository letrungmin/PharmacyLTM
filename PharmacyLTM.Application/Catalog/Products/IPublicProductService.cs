using PharmacyLTM.ViewModels.Catalog.Products;
using PharmacyLTM.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PharmacyLTM.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PageResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
        
    }
}
