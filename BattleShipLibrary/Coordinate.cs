using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipLibrary
{   //
    public struct Coordinate
    {
        public Coordinate(int x, int y)
        {
            if(x < 0 || y < 0)
            {
                throw new ArgumentException("Coordinates must not be less than zero ");
            }

            this.x = x;
            this.y = y;
        }

        public int x;
        public int y;
    }
}
