using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface ICombustible
    {
        /// <summary>
        /// Максимальная температура горения 
        /// </summary>
         double HeatCapacity { get; }

        /// <summary>
        /// Время горения единицы ресурса
        /// </summary>
        TimeSpan CombustionTime { get; }

        Task Burn();
    }
}
