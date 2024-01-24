using ConsoleApp3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Materials
{
    public class CopperOre : Ore
    {
        public override int MinimalProcessTemperature => 1083;

        public override TimeSpan ProcessTime => TimeSpan.FromSeconds(7);

        public override string Name => "Медная руда";

        public override string Description => "Медная руда, извлекаемая из недр, представляет собой важный ресурс для изготовления чистой меди";

        public override decimal Price => 11.5M;

        public override async Task<Metal> Process(double temperature, TimeSpan fuelBurningTimeRemain)
        {
            if (temperature > MinimalProcessTemperature &&
                fuelBurningTimeRemain.CompareTo(MinimalProcessTemperature) >= 0)
            {
                await Task.Delay(ProcessTime);
                return new Copper();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
