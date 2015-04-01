﻿using UnityEngine;

namespace Snipe
{
    public class Dice
    {
        private static readonly int maxDistance = 6;

        public static bool RollForHit(Cell location, Cell target)
        {
            int xDifference = (int)Mathf.Abs(location.Position.x - target.Position.x);
            int yDifference = (int)Mathf.Abs(location.Position.y - target.Position.y);

            int distance = Mathf.Max(xDifference, yDifference);

            Debug.Log("dist " + distance);

            if (distance > maxDistance)
            {
                return false;
            }

            float successChance = (1f / distance);
            float roll = UnityEngine.Random.RandomRange(0f, 1f);

            Debug.Log(roll + " <= " + successChance + "?");
            if (roll <= successChance)
            {
                return true;
            }

            return false;
        }
    }
}