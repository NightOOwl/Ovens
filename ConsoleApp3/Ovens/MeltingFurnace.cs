using ConsoleApp3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// Предоставляет экземпляр  плавильной печи для обработки полезных ископаемых
    /// </summary>
    public class MeltingFurnace : Oven<Metal>
    {
        public override float Efficiency => 0.56f;

        public override List<ICombustible> Fuel => Fuel;

        public override List<IProcessable<Metal>> Sourse => Sourse;

        public override List<Metal> Product => Product;

        public override Task HeatTreat()
        {
            double temperature = Efficiency * Fuel.First().heatCapacity;
            if (Fuel.Count > 0 && Sourse.Count >0 && Product.Count < Capacity)
            {
                Fuel.Last().Burn();
                return Sourse.Last().Process(temperature, Fuel.First().combustionTime);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }

}
