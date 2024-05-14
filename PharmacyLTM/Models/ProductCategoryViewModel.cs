using PharmacyLTM.ViewModels.Catalog.Categories;
using PharmacyLTM.ViewModels.Catalog.Products;
using PharmacyLTM.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyLTM.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }

        public PageResult<ProductVm> Products { get; set; }
    }
}