using PharmacyLTM.ViewModels.Catalog.Categories;
using PharmacyLTM.ViewModels.Catalog.ProductImages;
using PharmacyLTM.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyLTM.Models
{
    public class ProductDetailViewModel
    {
        public CategoryVm Category { get; set; }

        public ProductVm Product { get; set; }

        public List<ProductVm> RelatedProducts { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}