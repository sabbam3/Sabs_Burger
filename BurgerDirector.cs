using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace Lecture12
{
    public class BurgerDirector
    {
        IBurgerBuilder burgerBuilder;
        public BurgerDirector(IBurgerBuilder burgerBuilder)
        {
            this.burgerBuilder = burgerBuilder;
        }
        public void ConstructBurger(string bread, string lettuce, string cheese, string pickledCucumber, string meat, string sauce)
        {
            
            burgerBuilder.AddBread(bread);
            if(cheese != " ") burgerBuilder.AddCheese(cheese);
            if(pickledCucumber != " ") burgerBuilder.AddPickledCucumber(pickledCucumber);
            burgerBuilder.AddLettuce(lettuce);
            burgerBuilder.SetMeat(meat);
            burgerBuilder.SetSauce(sauce);
            
        }
        
    }
}
