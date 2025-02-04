﻿using P03_Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Raiding.Models
{
    public abstract class BaseHero : IHero
    {
        protected BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public string Name { get; private set; }

        public int Power { get; private set; }

        public abstract string CastAbility();
        
    }
}
