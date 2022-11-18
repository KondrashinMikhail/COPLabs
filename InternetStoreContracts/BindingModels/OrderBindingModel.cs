using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStoreContracts.BindingModels
{
    public class OrderBindingModel
    {
        public int? Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public virtual string[] Photo { get; set; }
        public virtual string[] Products { get; set; }
    }
}
