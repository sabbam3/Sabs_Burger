using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12
{
    public class Burger
    {
        

        public string Bread { get; set; } 
        public string Lettuce {  get; set; }
        public string Cheese {  get; set; }
        public string PickledCucumber { get; set; }
        public string Meat { get; set; }
        public string Sauce { get; set; }
        public override string ToString()
        {
            return $" {Bread}\n {Lettuce}\n {Cheese}\n {PickledCucumber}\n Sauce: {Sauce}\n Meat: {Meat}";
            
        }
    }
}
