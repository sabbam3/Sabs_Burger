using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace Lecture12
{
    public class BurgerComposition
    {
        public string Bread = "Bread";
        public string Lettuce = "Lettuce";
        public string Cheese = "Cheese";
        public string PickledCucumber = "Pickled Cucumber";
        public enum Meat
        {
            Chicken = 1,
            Goods,
            Whitout
        }
        public enum Sauce 
        {
            Sweet = 1,
            Spicy,
            Branded,
            Whitout
        }
    }
}
