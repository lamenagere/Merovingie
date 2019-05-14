﻿using Common.Enums;
using Common.Struct;
using System;
using System.Collections.Generic;

namespace AoC.Api.Domain
{
    public class Tree : PassiveBuilding
    {
        #region Propriétés
        public int WoodStock { get; set; }
        public Coordinates RallyPoint { get; set; }
        #endregion


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="position"></param>
        /// <param name="Quantity"></param>
        public Tree(String Name, Coordinates position, int stockQty = 100)
            : base(Name, position, ResourcesType.Wood, 20)
        {
            WoodStock = stockQty;
        }

        public Tree() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quantityToCollect"></param>
        /// <returns></returns>
        public override KeyValuePair<ResourcesType, int> Remove(int quantityToCollect)
        {
            int quantityCollected;

            // S'il ne reste pas assez, on récolte ce qu'il reste dans la mine
            if (WoodStock <= quantityToCollect)
            {
                quantityCollected = WoodStock;
            }
            // Sinon, on retire la quantité désirée au stock de la mine
            else
            {
                quantityCollected = quantityToCollect;
            }

            // Retire la quantité collectée au stock
            WoodStock -= quantityCollected;
            // Si le stock est à 0, on détruit la mine
            if (WoodStock == 0) DestroyBuilding();

            // Retourne la ressource associée à la quantité collectée
            return new KeyValuePair<ResourcesType, int>(ResourcesType.Wood, quantityCollected);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override bool DestroyBuilding()
        {
            return base.DestroyBuilding();
        }
    }
}
