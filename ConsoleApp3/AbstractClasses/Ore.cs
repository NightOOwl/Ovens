using ConsoleApp3.AbstractClasses;
using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Materials
{
    public abstract class Ore : Material, IProcessableTo<Metal>, IStackable<Ore>
    {
        public abstract int MinimalProcessTemperature { get; }
        public abstract TimeSpan ProcessTime { get; }        

        public abstract Task<Metal> Process(double temperature, TimeSpan fuelBurningTimeRemain);
       
        public virtual List<Ore> Stack(params Ore[] resouces)
        {
            List<Ore> stack = new List<Ore>();

            foreach (var ore in resouces)
            {
                if (stack.Count < 64)
                {
                    stack.Add(ore);
                }
            }
            return stack;
        }
    }
}
