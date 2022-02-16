using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipLibrary
{
    interface ISizeDeck
    {
        int CountDeck { get; }

        public Coordinate FirstDeck { get; }

        public Coordinate LastDeck { get; }

        public Orientation Orientation { get; }

    }
}
