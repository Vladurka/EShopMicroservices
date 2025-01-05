using Catalog.Api.Products.CreateProduct;

namespace Catalog.Api.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public List<string> Category { get; set; } = new List<string>();    
        public string Description { get; set; } = string.Empty;
        public string ImageFile { get; set; } = string.Empty;
        public decimal Price { get; set; }


        public Product() { }
        public Product(CreateProductCommand product)
        {
            Name = product.Name;
            Category = product.Category;
            Description = product.Description;
            ImageFile = product.ImageFile;
            Price = product.Price;
        }
    }
}
