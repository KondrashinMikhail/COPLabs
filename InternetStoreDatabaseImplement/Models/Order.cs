using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetStoreDatabaseImplement.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required] public string CustomerName { get; set; }
        [Required] public string CustomerEmail { get; set; }
        public string[] PhotoPaths { get; set; }
        public string[] Products { get; set; }
    }
}