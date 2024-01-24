using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Materials
{
    public class Coal : Material, IStackable<Coal>, ICombustible
    {
        public double heatCapacity { get => 3000; }
        public TimeSpan combustionTime { get => TimeSpan.FromSeconds(25); }

        public override string Name => "Каменный уголь";

        public override string Description => "Полезное ископаемое. Является отличным топливом для любой термической обработки.";

        public override decimal Price => 4.5M;

        public async Task Burn()
        {
            await Task.Delay(combustionTime);
        }

        public List<Coal> Stack(params Coal[] resoures)
        {
            List<Coal> stack = new List<Coal>();

            foreach (var coal in resoures)
            {
                if (stack.Count < 64)
                {
                    stack.Add(coal);
                }
            }
            return stack;
        }
    }
}
