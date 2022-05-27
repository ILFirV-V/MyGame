using System;
using MyGame.Models;

namespace MyGame.Controllers
{
    class PhysicsController
    {
        public static bool VictoryGame;
        public static bool EssenceInAir(int positionX, int positionY)
        {
            var changedPositionY = (int)Math.Ceiling(positionY / 30.0);
            if (Map.getMapPieceType(positionX / 30, changedPositionY + 1) == 1)
                return true;
            return false;
        }

        public static bool InConflictStairsUp(int positionX, int positionY)
        {
            var changedPositionY = (int)Math.Ceiling((positionY + 25) / 30.0);
            if (Map.getMapPieceType(positionX / 30, changedPositionY - 1) == 2)
            {
                return false;
            }
            return true;
        }

        public static bool InConflictStairsDown(int positionX, int positionY)
        {
            var changedPositionY = (int)Math.Ceiling(positionY / 30.0);
            if (Map.getMapPieceType(positionX / 30, changedPositionY + 1) == 2)
            {
                return false;
            }
            return true;
        }

        public static bool InConflictLeftAndRight(int positionX, int positionY, int direction)
        {
            var possibleDifference = 0;
            while(possibleDifference < 3)
            {
                var changedPositionY = (int) Math.Ceiling((positionY + 25) / 30.0);
                var changedPositionX = (int) Math.Floor((positionX) / 30.0);
                if (changedPositionX == 0)
                    changedPositionX = 1;
                if (changedPositionX == 51)
                    changedPositionX = 50;
                if (Map.getMapPieceType(changedPositionX + direction, positionY / 30) == 15
                    || (Map.getMapPieceType(changedPositionX + direction * possibleDifference, changedPositionY) == 4)
                    || (Map.getMapPieceType(changedPositionX + direction * possibleDifference, changedPositionY) == 19))
                    return true;
                possibleDifference += 1;
            }
            return false;
        }

        public static void CheckVictoryGame(Player player)
        {
            var changedPositionY = (int)Math.Ceiling((player.PositionY + 25) / 30.0);
            var changedPositionX = (int)Math.Floor(player.PositionX / 30.0);
            if (Map.getMapPieceType(changedPositionX, changedPositionY) == 10 && player.IsHaveKey)
            {
                VictoryGame = true;
            }
        }
    }
}
