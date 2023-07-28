using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System;
namespace Lecture12
{
    public interface IBurgerBuilder
    {
        void AddBread(string bread);
        void AddLettuce(string lettuce);
        void AddCheese(string cheese);
        void AddPickledCucumber(string cucumber);
        void SetMeat(string meat);
        void SetSauce(string sauce);
        Burger GetBurger();
    }
    
}
