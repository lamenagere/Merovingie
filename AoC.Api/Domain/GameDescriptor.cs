﻿using AoC.Api.Domain;
using Common.Enums;
using Common.Helpers;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Domain

{
    [Serializable]
    [XmlRoot]
    public class GameDescriptor
    {
        #region Properties

        [XmlArrayItem]
        public List<Carry> Carries;
        public List<Tree> Trees;
        public List<GoldMine> GoldMines;

        public List<TownHall> TownHalls;
        public List<Farm> Farms;

        public List<Worker> Workers;

        public SerializableDictionary<ResourcesType, int> Resources;

        #endregion

        public GameDescriptor()
        {
            Carries = new List<Carry>();
            Trees = new List<Tree>();
            GoldMines = new List<GoldMine>();

            TownHalls = new List<TownHall>();
            Farms = new List<Farm>();

            Workers = new List<Worker>();

            Resources = new SerializableDictionary<ResourcesType, int>();
        }
    }
}
