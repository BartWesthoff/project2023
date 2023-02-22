using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2023.models
{
    public class Meat : IShoppingItem
    {
        public Meat(string name, string description, double price, double weight)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.weight = weight;
            
        }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public double weight { get; set; }
    }   
}
