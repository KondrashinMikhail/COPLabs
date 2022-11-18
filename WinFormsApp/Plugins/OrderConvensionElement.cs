using PluginsConvention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Plugins
{
    public class OrderConvensionElement : PluginsConventionElement
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public virtual string[] OrderPhotoPaths { get; set; }
        public virtual List<int> OrderProducts { get; set; }
    }
}
