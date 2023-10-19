using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Upcasting_Downcasting_tasks
{
    public class Pineapple : Fruit
    {
        public double VitaminE = 0;
        public double VitaminD = 0;

       
        public override void Taste()
        {
            Console.WriteLine("Sweet taste");
        }
    }
}
