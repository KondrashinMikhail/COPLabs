namespace InternetStoreContracts.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public virtual string[] Photos { get; set; }
        public virtual string[] Products { get; set; }
    }
}
