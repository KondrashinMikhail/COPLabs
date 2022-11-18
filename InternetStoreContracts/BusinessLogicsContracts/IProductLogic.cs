using InternetStoreContracts.BindingModels;
using InternetStoreContracts.ViewModels;

namespace InternetStoreContracts.BusinessLogicsContracts
{
    public interface IProductLogic
    {
        List<ProductViewModel> Read(ProductBindingModel model);
        void CreateOrUpdate(ProductBindingModel model);
        void Delete(ProductBindingModel model);
    }
}
