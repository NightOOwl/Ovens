using ConsoleApp3.AbstractClasses;
using ConsoleApp3.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            AA();
        }
        static async void AA()
        {
            MeltingFurnace oven = new MeltingFurnace();
            List<Coal> coals = new List<Coal>();
            for (int i = 0; i < 10; i++)
            {
                coals.Add(new Coal());
            }
            List<CopperOre> ores = new List<CopperOre>();
            for (int i = 0; i < 10; i++)
            {
                ores.Add(new CopperOre());
            }
            oven.AddFuel(coals);
            oven.AddSource(ores);
            await oven.HeatTreat();
            List<Metal> copper = oven.ExtractProduct(5);
            await Console.Out.WriteLineAsync(copper.Last().Name);
        }
    }
 }

