using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting_tasks
{
    public class Apple : Fruit
    {
        public double VitaminA = 0;
        public double VitaminB = 0;

       


        public override void Taste()
        {
            Console.WriteLine("Sweet and sour taste");
        }
    }
}
