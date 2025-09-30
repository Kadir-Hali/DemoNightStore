namespace DemoNightStore.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
