﻿using Common.Enums;
using Common.Helpers;
using System.Collections.Generic;

namespace AoC.Api.EventArgs
{
    public class ResourcesChangedArgs
    {
        public SerializableDictionary<ResourcesType, int> CurrentResources;
    }

    public class BuildingResourcesChangedArgs : ResourcesChangedArgs
    {
        public int BuildingId { get; set; }
    }
}