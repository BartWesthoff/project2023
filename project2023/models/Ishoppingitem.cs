using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2023.models
{
    public interface IShoppingItem
    {
        string name { get; set; }
        string description { get; set; }
        double price { get; set; }
        double weight { get; set; }
    }
}
