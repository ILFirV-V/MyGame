using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.Models;

namespace MyGame.Controllers
{
    class GameControllers
    {
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
            var changedPositionY = (int)Math.Ceiling((positionY + 25) / 30.0);
            var changedPositionX = (int)Math.Floor(positionX / 30.0);
            if (changedPositionX == 0)
                changedPositionX = 1;
            if (changedPositionX == 51)
                changedPositionX = 50;
            if (Map.getMapPieceType(changedPositionX + direction, positionY / 30) == 15
                || (Map.getMapPieceType(changedPositionX + direction, changedPositionY) == 4))
                return true;
            return false;
        }
    }
}
