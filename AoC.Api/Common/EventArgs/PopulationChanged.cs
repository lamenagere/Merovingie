﻿using AoC.Common.Interfaces;

namespace AoC.Api.EventArgs
{
    public class PopulationChangedEventArgs
    {
        public int CurrentPopulation { get; set; }
        public IUnit Unit { get; set; }
    }
}
