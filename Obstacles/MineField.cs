﻿using CAB201_Assignment.Utils;
using CAB201_Assignment.ObstacleMap;

/**
 * pattern
 * x.x
 * .x.
 * x.x
 */

namespace Obstacles
{
    class MineField : Obstacle
    {
        private char _marker = 'x';
        public override char Marker
        {
            get
            {
                return _marker;
            }
        }
        protected override void InitializeObstacle()
        {
            Util.PromptCoordinates("Balls");
        }

        public override List<int[]> GetVision(CharMap charMap)
        {
            // Originally it was int[,] but in reality the size of the vision would be unknown.
            // Especially for more complex objects.
            List<int[]> vision = new List<int[]>() { _coordinates };
            return vision;
        }
    }
}
