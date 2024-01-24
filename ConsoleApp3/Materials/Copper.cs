using ConsoleApp3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Materials
{
    public class Copper : Metal
    {
        public override string Name => "Медь";

        public override string Description => "Медь, оранжево-красный металл, дарит не только прочность оружию и броне, но и уникальные магические свойства, придавая владельцу силу и стойкость в бескрайних приключениях.";

        public override decimal Price => 50;
    }
}
