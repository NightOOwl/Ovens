﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IProcessable <TProduct> where TProduct : class
    {
        int MinimalProcessTemperature { get; }
        TimeSpan ProcessTime { get; }
        Task<TProduct> Process(double temperature, TimeSpan fuelBurningTimeRemain);
    }
}
