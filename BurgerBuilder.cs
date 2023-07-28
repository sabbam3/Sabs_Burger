using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12
{
    public class BurgerBuilder : IBurgerBuilder
    {
        Burger burger;
        public BurgerBuilder() 
        { 
          this.burger = new Burger();
        } 
        public void AddBread(string bread)
        {
            burger.Bread = bread;
        }

        public void AddCheese(string cheese)
        {
            burger.Cheese = cheese;  
        }

        public void AddLettuce(string lettuce)
        {
            burger.Lettuce = lettuce;
        }

        public void AddPickledCucumber(string cucumber)
        {
            burger.PickledCucumber = cucumber;
        }
        public void SetMeat(string meat)
        {
            burger.Meat = meat;
        }

        public void SetSauce(string sauce)
        {
            burger.Sauce = sauce;
        }
        public Burger GetBurger()
        {
            return burger;
        }
    }
}
