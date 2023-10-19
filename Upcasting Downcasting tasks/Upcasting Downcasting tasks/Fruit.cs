using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting_tasks
{
    public abstract class Fruit
    {
        public double Price = 0;
        public string Sort;

        public abstract void Taste();
    }
}
