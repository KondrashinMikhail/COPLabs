using InternetStoreContracts.BindingModels;
using InternetStoreContracts.BusinessLogicsContracts;
using InternetStoreContracts.StoragesContracts;
using InternetStoreContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStoreBusinessLogic.BusinessLogics
{
    public class OrderLogic : IOrderLogic
    {
        private readonly IOrderStorage _orderStorage;
        public OrderLogic(IOrderStorage orderStorage) => _orderStorage = orderStorage;

        public void CreateOrUpdate(OrderBindingModel model)
        {
            if (model.Id.HasValue) _orderStorage.Update(model);
            else _orderStorage.Insert(model);
        }

        public void Delete(OrderBindingModel model)
        {
            var element = _orderStorage.GetElement(new OrderBindingModel { Id = model.Id });
            if (element == null) throw new Exception("Элемент не найден");
            _orderStorage.Delete(model);
        }

        public List<OrderViewModel> Read(OrderBindingModel model)
        {
            if (model == null) return _orderStorage.GetFullList();
            if (model.Id.HasValue) return new List<OrderViewModel> { _orderStorage.GetElement(model) };
            return _orderStorage.GetFilteredList(model);
        }
    }
}
