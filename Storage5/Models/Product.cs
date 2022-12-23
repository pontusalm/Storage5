using System.ComponentModel.DataAnnotations;

namespace Storage5.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Range(0, 10000)]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [Required]
        public string Category { get; set; }

        public string Shelf { get; set; }

        public int Count { get; set; }

        public string Description { get; set; }
    }
}
