using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12
{
    public class BaseBurgers
    {
        BurgerBuilder burgerBuilder;
        BurgerDirector burgerDirector;
        BurgerComposition burger;
        public BaseBurgers()
        {
           burgerBuilder = new BurgerBuilder();
           burgerDirector = new BurgerDirector(burgerBuilder);
           burger = new BurgerComposition();
        }
        public void Hamburger()
        {
          var hamburgerMeat = BurgerComposition.Meat.Goods.ToString();
          var hamburgerSouce = BurgerComposition.Sauce.Sweet.ToString();
          burgerDirector.ConstructBurger(burger.Bread, burger.Lettuce, " ", burger.PickledCucumber, hamburgerMeat, hamburgerSouce);
          Burger hamburger = burgerBuilder.GetBurger();
          Console.WriteLine(hamburger);
        }
        public void Cheeseburger()
        {
            var meat = BurgerComposition.Meat.Whitout.ToString();
            var souce = BurgerComposition.Sauce.Spicy.ToString();
            burgerDirector.ConstructBurger(burger.Bread, burger.Lettuce, burger.Cheese, burger.PickledCucumber, meat, souce);
            Burger cheeseburger = burgerBuilder.GetBurger();
            Console.WriteLine(cheeseburger);
        }
        public void BrandedBurger()
        {
            var meat = BurgerComposition.Meat.Chicken.ToString();
            var souce = BurgerComposition.Sauce.Branded.ToString();
            burgerDirector.ConstructBurger(burger.Bread, burger.Lettuce, " ", burger.PickledCucumber, meat, souce);
            Burger brandedBurger = burgerBuilder.GetBurger();
            Console.WriteLine(brandedBurger);
        }
    }
}
