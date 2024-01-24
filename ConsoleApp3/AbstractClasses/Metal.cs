using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.AbstractClasses
{
    public abstract class Metal : Material, IStackable<Metal>
    {
        public virtual List<Metal> Stack(params Metal[] resoures)
        {
            List<Metal> stack = new List<Metal>();

            foreach (var metal in resoures) 
            {
                if (stack.Count < 64)
                {
                    stack.Add(metal);
                }
            }
            return stack;
        }
    }
}
