using System.ComponentModel;

namespace _181701c_task_3.Models
{
    public class Product
    {
        public int Id { set; get; }

        public string? Name { set; get; }

        public double Price { set; get; }

        public string? Description { set; get; }

        public Product(int id, string name, double price, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }
    }
}
