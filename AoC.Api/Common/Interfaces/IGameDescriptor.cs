﻿using AoC.Common.Descriptors;
using Common.Enums;
using Common.Helpers;
using System.Collections.Generic;

namespace AoC.Common.Interfaces
{
    public interface IGameDescriptor
    {
        List<CarryDescriptor> Carries { get; set; }
        List<TreeDescriptor> Trees { get; set; }
        List<GoldMineDescriptor> GoldMines { get; set; }
        List<TownHallDescriptor> TownHalls { get; set; }
        List<FarmDescriptor> Farms { get; set; }
        List<WorkerDescriptor> Workers { get; set; }
        SerializableDictionary<ResourcesType, int> Resources { get; set; }
        int MaxPopulation { get; set; }
        int ActualPopulation { get; set; }

    }
}