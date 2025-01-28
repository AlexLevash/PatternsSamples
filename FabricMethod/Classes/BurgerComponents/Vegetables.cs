﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Classes
{
    public class Vegetable : BurgerComponent
    {
        public VegetableType Type { get; set; }
        public Vegetable(VegetableType vegetableType)
        {
            Type = vegetableType;
        }
    }

    public enum VegetableType
    {
        Lettuce,
        Tomato,
        Pickle
    }
}
