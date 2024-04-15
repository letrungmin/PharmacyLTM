﻿using PharmacyLTM.ViewModels.Catalog.Products;
using PharmacyLTM.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace PharmacyLTM.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task <int> Create(ProductCreateRequest request);
        Task <int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewCount(int productId);
        Task<PageResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
        Task<int> AddImages(int productId, List<IFormFile> files);

        Task<int> RemoveImages(int imageId);

        Task<int> UpdateImage(int imageId, string caption, bool isDefault);

        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
