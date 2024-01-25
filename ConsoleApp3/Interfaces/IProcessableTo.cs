using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IProcessableTo <TProduct> where TProduct : Material
    {       
        int MinimalProcessTemperature { get; }
        TimeSpan ProcessTime { get; }
        Task<TProduct> Process(double temperature, TimeSpan fuelBurningTimeRemain);
    }
}
