﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Interfaces
{
    public interface IStackable <Resoure> where Resoure : Material
    {
        List<Resoure> Stack(params Resoure[] resourсes);
    }
}
