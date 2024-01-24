using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Oven <TProduct> where TProduct : class
    {
        /// <summary>
        /// Размер отсеков для ресурсов
        /// </summary>
        public int Capacity { get => 64; }

        /// <summary>
        /// Эффективность использования горючего
        /// </summary>
        public abstract float Efficiency { get; }

        /// <summary>
        ///  Загруженное топливо
        /// </summary>
        public abstract List<ICombustible> Fuel { get; }

        /// <summary>
        /// Загруженное сырье
        /// </summary>
        public abstract List<IProcessable<TProduct>> Sourse { get; }

        /// <summary>
        /// Обработанный продукт 
        /// </summary>
        public abstract List<TProduct> Product { get; }

        public abstract Task HeatTreat();
    }
}
