using SampleTest.Models;

namespace SampleTest.Services
{
    public class ProductServices
    {
        public ProductServices()
        {
            _products = SampleData();
        }

        private List<ProductModel> _products { get; set; }

        public List<ProductModel> Customers()
        {
            return _products;
        }

        public int Create(ProductModel product)
        {
            product.ID = _products.Count;
            _products.Add(product);
            return product.ID;
        }

        public int Update(ProductModel product)
        {
            var find = _products.SingleOrDefault(x => x.ID == product.ID);
            if (find == null)
            {
                throw new Exception("Not found");
            }
            Helpers.CopyPropertiesTo<ProductModel, ProductModel>(product, find);
            return product.ID;
        }

        public int Delete(ProductModel product)
        {
            var find = _products.SingleOrDefault(x => x.ID == product.ID);
            if (find == null)
            {
                throw new Exception("Not found");
            }
            _products.Remove(product);
            return product.ID;
        }

        private List<ProductModel> SampleData()
        {
            return new List<ProductModel>
            {
                new ProductModel
                {
                    ID = 1,
                    Name = "1099Express",
                    Description = "1099 Forms for IRS information returns",
                    Price = 179.00m,
                },
                new ProductModel
                {
                    ID = 2,
                    Name = "W2Expres",
                    Description = "W2 Forms for Social Security information returns",
                    Price = 159.00m,
                },
                new ProductModel
                {
                    ID = 3,
                    Name = "1095",
                    Description = "1095 Forms for IRS information returns",
                    Price = 189.00m
                },
            };
        }

    }
}
