using Microsoft.VisualStudio.TestTools.UnitTesting;
using project2023.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace project2023tests
{

    [TestClass]
    public class Shoppingtest
    {

        [TestMethod]
        public void Get_Itemcount()
        {
            // arrange
            Meat biefstuk = new Meat(name: "biefstuk", description: "beschrijving", price: 5.99, weight: 200);
            Meat ossenhaas = new Meat(name: "ossenhaas", description: "beschrijving", price: 7.99, weight: 150);
            Meat varkenshaas = new Meat(name: "varkenshaas", description: "beschrijving", price: 4.99, weight: 250);
            Fish kibbeling = new Fish(name: "kibbeling", description: "beschrijving", price: 3.99, weight: 100);

            Shoppingcart shoppingcart = new Shoppingcart();

            // act
            shoppingcart.AddItem(biefstuk, 1);

            // assert
            Assert.AreEqual(1, shoppingcart.items.Count);

        }

        [TestMethod]
        public void Get_Weight()
        {
            // arrange
            Meat biefstuk = new Meat(name: "biefstuk", description: "beschrijving", price: 5.99, weight: 200);
            Meat ossenhaas = new Meat(name: "ossenhaas", description: "beschrijving", price: 7.99, weight: 150);
            Meat varkenshaas = new Meat(name: "varkenshaas", description: "beschrijving", price: 4.99, weight: 250);
            Fish kibbeling = new Fish(name: "kibbeling", description: "beschrijving", price: 3.99, weight: 100);

            Shoppingcart shoppingcart = new Shoppingcart();

            // act
            shoppingcart.AddItem(biefstuk, 1);
            shoppingcart.AddItem(ossenhaas, 1);
            shoppingcart.AddItem(varkenshaas, 1);
            shoppingcart.AddItem(kibbeling, 2);

            shoppingcart.RemoveItem(0);

            // assert
            Assert.AreEqual(100, shoppingcart.weight);
        }

        [TestMethod]
        public void IsTrue()
        {
            Assert.IsTrue(true);
        }


    }
}
