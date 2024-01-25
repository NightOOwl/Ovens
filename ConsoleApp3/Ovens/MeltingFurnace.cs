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

       

        
    }

}
