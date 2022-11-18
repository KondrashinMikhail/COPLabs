using InternetStoreContracts.BindingModels;
using InternetStoreContracts.ViewModels;

namespace InternetStoreContracts.BusinessLogicsContracts
{
    public interface IOrderLogic
    {
        List<OrderViewModel> Read(OrderBindingModel model);
        void CreateOrUpdate(OrderBindingModel model);
        void Delete(OrderBindingModel model);
    }
}
