﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Summoner
{
    public class SummonerLevelAndPoints : RiotGamesObject
    {
        #region Constructors and Callbacks

        public SummonerLevelAndPoints(TypedObject result)
        {
            base.SetFields<SummonerLevelAndPoints>(this, result);
        }

        public override void DoCallback(TypedObject obj)
        {
            return;
        }

        #endregion

        #region Member Properties

        /// <summary>
        /// Total influence points (IP) earned in lifetime.
        /// </summary>
        [InternalName("infPoints")]
        public int InfPoints { get; set; }

        /// <summary>
        /// Amount of experience points (default = 10 if summoner level is 30).
        /// </summary>
        [InternalName("expPoints")]
        public int ExpPoints { get; set; }

        /// <summary>
        /// Current level of summoner.
        /// </summary>
        [InternalName("summonerLevel")]
        public int SummonerLevel { get; set; }

        /// <summary>
        /// Summoner ID number.
        /// </summary>
        [InternalName("summonerId")]
        public int SummonerId { get; set; }

        #endregion
    }
}
