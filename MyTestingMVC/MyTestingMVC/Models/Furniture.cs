using System.ComponentModel.DataAnnotations.Schema;

namespace MyTestingMVC.Models
{
    [Table("Furniture")]
    public class Furniture
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public int quantity { get; set; }
        public int avaliablequantity { get; set; }
    }
}
