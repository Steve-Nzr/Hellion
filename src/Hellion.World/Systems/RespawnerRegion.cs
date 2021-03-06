﻿using Hellion.Core.Structures;
using Hellion.World.Structures;

namespace Hellion.World.Systems
{
    public class RespawnerRegion : Region
    {
        /// <summary>
        /// Gets the region respawn time.
        /// </summary>
        public int RespawnTime { get; private set; }

        public RespawnerRegion(Vector3 middle, Vector3 northEast, Vector3 southWest, int respawnTime)
            : base(middle, northEast, southWest)
        {
            this.RespawnTime = respawnTime;
        }

        public override void Update()
        {
        }
    }
}
