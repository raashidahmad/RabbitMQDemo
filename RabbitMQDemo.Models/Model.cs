using System.ComponentModel.DataAnnotations;

namespace RabbitMQDemo.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } = "Default";
        public string ProductDescription { get; set; } = "Default";
        public int ProductPrice { get; set; }
        public int ProductStock { get; set; }
    }
}
