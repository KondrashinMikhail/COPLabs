using InternetStoreContracts.BindingModels;
using InternetStoreContracts.StoragesContracts;
using InternetStoreContracts.ViewModels;
using InternetStoreDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace InternetStoreDatabaseImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using var context = new InternetStoreDatabase();
            return context.Orders
                .Select(CreateModel).ToList();
        }

        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null) return null;
            using var context = new InternetStoreDatabase();
            return context.Orders
                .Where(rec => rec.CustomerName == model.CustomerName || rec.CustomerEmail == model.CustomerEmail).ToList()
                .Select(CreateModel)
                .ToList();
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null) return null;
            using var context = new InternetStoreDatabase();
            var order = context.Orders
                .FirstOrDefault(rec => rec.Id == model.Id);
            return order != null ? CreateModel(order) : null;
        }
        

        public void Insert(OrderBindingModel model)
        {
            using var context = new InternetStoreDatabase();
            var order = new Order
            {
                CustomerName = model.CustomerName,
                CustomerEmail = model.CustomerEmail,
                Products = model.Products,
                PhotoPaths = model.Photo
            };
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public void Update(OrderBindingModel model)
        {
            using var context = new InternetStoreDatabase();
            var order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (order == null) throw new Exception("Заказ не найден");
            order.CustomerName = model.CustomerName;
            order.CustomerEmail = model.CustomerEmail;
            order.PhotoPaths = model.Photo;
            order.Products = model.Products;
            context.SaveChanges();
        }
        
        public void Delete(OrderBindingModel model)
        {
            using var context = new InternetStoreDatabase();
            var order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (order == null) throw new Exception("Заказ не найден");
            context.Orders.Remove(order);
            context.SaveChanges();
        }

        private OrderViewModel CreateModel(Order order) 
        {
            return new OrderViewModel
            {
                Id = order.Id,
                CustomerName = order.CustomerName,
                CustomerEmail = order.CustomerEmail,
                Photos = order.PhotoPaths,
                Products = order.Products
            };
        }
    }
}
