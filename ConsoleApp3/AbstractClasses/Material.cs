using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Material
    {
        /// <summary>
        /// Название материала
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Описание материала
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Стоимость за единицу ресурса
        /// </summary>
        public abstract decimal Price { get; }

    }
}
