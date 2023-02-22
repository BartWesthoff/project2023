

using project2023.models;

namespace project2023
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Meat biefstuk = new Meat(name: "biefstuk", description: "beschrijving", price: 5.99, weight: 200);
            Meat ossenhaas = new Meat(name: "ossenhaas", description: "beschrijving", price: 7.99, weight: 150);
            Meat varkenshaas = new Meat(name: "varkenshaas", description: "beschrijving", price: 4.99, weight: 250);
            Fish kibbeling = new Fish(name: "kibbeling", description: "beschrijving", price: 3.99, weight: 100);

            Shoppingcart shoppingcart = new Shoppingcart();

            bool isShopping = true;
            // create array of items
            IShoppingItem[] items = { biefstuk, ossenhaas, varkenshaas, kibbeling };

            while (isShopping)
            {
                // ask what customer wants to buy and ask if they want to continue
                bool correctInput = false;
                int number2 = -1;
                while (!correctInput) {
                    Console.WriteLine("What do you want to buy?");
                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine(i + 1 + ". " + items[i].name);
                    }

                    number2 = int.Parse(Console.ReadLine()); // convert number to int and add item to shopp
                    if(number2-1 < items.Length)
                    {
                        correctInput= true;

                    }
                }
                // convert number to int and add item to shoppingcart
                shoppingcart.AddItem(items[number2 - 1], 1);

                Console.WriteLine("Do you want to continue shopping? (y/n)");
                string isShopping2 = Console.ReadLine();
                if (isShopping2.ToLower() != "y")
                {
                    isShopping = false;
                }



            }

            shoppingcart.PrintShoppingCart();

        }
    }
}