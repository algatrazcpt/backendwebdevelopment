namespace Pratik2.Models
{
    public class Order
    {
        int orderId;
        string productName="";
        decimal price;
        int quantity;

        public int OrderId { get => orderId; set => orderId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public decimal Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
