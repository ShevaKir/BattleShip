using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BattleShipLibrary
{
    class GridShip
    {
        private List<Coordinate> _grid;
        private int _height = 3;            //высота грида
        private int _weight = 3;            //ширина грида

        public GridShip(ISizeDeck ship, int sizeField)
        {
            if (ship.CountDeck < sizeField)
            {
                if (ship.Orientation == Orientation.Horizontal)
                {
                    _weight += ship.CountDeck - 1;
                }
                else
                {
                    _height += ship.CountDeck - 1;
                }
            }
            FillGrid(ship);
        }

        private void FillGrid(ISizeDeck ship)
        {
            for (int y = ship.FirstDeck.y - 1; y < _height; y++)
            {
                for (int x = ship.FirstDeck.x - 1; y < _weight; y++)
                {
                    _grid.Add(new Coordinate(x, y));
                }
            }
        }
        
    }
}
