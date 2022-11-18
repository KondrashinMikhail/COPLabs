using InternetStoreContracts.BindingModels;
using InternetStoreContracts.StoragesContracts;
using InternetStoreContracts.ViewModels;
using InternetStoreDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace InternetStoreDatabaseImplement.Implements
{
    public class ProductStorage : IProductStorage
    {
        public List<ProductViewModel> GetFullList()
        {
            using var context = new InternetStoreDatabase();
            return context.Products
                .Select(CreateModel).ToList();
        }

        public List<ProductViewModel> GetFilteredList(ProductBindingModel model)
        {
            //using var context = new InternetStoreDatabase();
            using var context = new InternetStoreDatabase();
           return context.Products.Select(CreateModel).ToList().Where(rec => rec.Name == model.Name).ToList();
        }

        public ProductViewModel GetElement(ProductBindingModel model)
        {
            if (model == null) return null;
            using var context = new InternetStoreDatabase();
            var product = context.Products.FirstOrDefault(rec => rec.Id == model.Id);
            return product != null ? CreateModel(product) : null;
        }


        public void Insert(ProductBindingModel model)
        {
            using var context = new InternetStoreDatabase();
            var product = new Product
            {
                Name = model.Name
            }; 
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Update(ProductBindingModel model)
        {
            using var context = new InternetStoreDatabase();
            var product = context.Products.FirstOrDefault(rec => rec.Id == model.Id);
            if (product == null) throw new Exception("Продукт не найден");
            product.Name = model.Name;
            context.SaveChanges();
        }

        public void Delete(ProductBindingModel model)
        {
            using var context = new InternetStoreDatabase();
            var product = context.Products.FirstOrDefault(rec => rec.Id == model.Id);
            if (product == null) throw new Exception("Продукт не найден");
            context.Products.Remove(product);
            context.SaveChanges();
        }

        private ProductViewModel CreateModel(Product product) 
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
            };
        }
    }
}
