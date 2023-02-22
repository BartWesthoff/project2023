using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2023.models
{
    public class Shoppingcart
    {

        public Shoppingcart()
        {
            this.items = new List<IShoppingItem>();
            this.weight = 0.0;
        }

        public List<IShoppingItem> items { get; set; }
        public double weight { get; set; }

        public void AddItem(IShoppingItem item, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                this.items.Add(item);
                this.weight += quantity * item.weight;
            }

        }

        public void RemoveAllItems()
        {
            this.items.Clear();
        }   

        public void RemoveItem(int index)
        {
            this.items.RemoveAt(index);
            this.weight -= this.items[index].weight;
        }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (IShoppingItem item in this.items)
            {
                total += item.price;
            }
            return total;
        }

        public int GetTotalQuantity()
        {
            
            return this.items.Count;
        }

        public void PrintShoppingCart()
        {
            Console.WriteLine("Shoppingcart:");
            foreach (IShoppingItem item in this.items)
            {
                Console.WriteLine(item.name + " " + item.price + " " + item.weight + "gram");
            }
            Console.WriteLine("Total price: " + this.GetTotalPrice());
        }   
    }
}
