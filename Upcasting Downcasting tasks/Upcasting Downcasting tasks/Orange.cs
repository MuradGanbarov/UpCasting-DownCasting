using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting_tasks
{
    public class Orange : Fruit
    {
        public double VitaminC = 0;

        public override void Taste()
        {
            Console.WriteLine("Sour and sweet taste");
        }
    }
}
