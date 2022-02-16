using System;

namespace BattleShipLibrary
{
    public class Deck
    {
        public Deck(Coordinate coordinateDeck)
        {
            CoordinateDeck = coordinateDeck;
            StateDeck = StateDeck.Whole;
        }

        public Coordinate CoordinateDeck { get; private set; }

        public StateDeck StateDeck { get; set; }
    }
}
