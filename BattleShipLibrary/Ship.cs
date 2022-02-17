using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BattleShipLibrary
{
    public class Ship : ISizeDeck
    {
        private Dictionary<Coordinate, Deck> _decks;

        public Ship(Coordinate coordinate, int quantilytyDeck, Orientation orientation)
        {
            if (quantilytyDeck < 0)
            {
                throw new ArgumentException(nameof(quantilytyDeck));
            }

            _decks = new Dictionary<Coordinate, Deck>(quantilytyDeck);
            CountDeck = quantilytyDeck;
            Orientation = orientation;

            if (orientation == Orientation.Horizontal)
            {
                CreateShip(coordinate);
            }
            else
            {
                CreateShip(coordinate);
            }          
        }

        private void CreateShip(Coordinate coordinate)
        {
            for (int i = coordinate.x; i < CountDeck; i++)
            {
                Deck deck = new Deck(new Coordinate(i, coordinate.y));
                _decks.Add(deck.CoordinateDeck, deck);
            }
        }

        public Orientation Orientation { get; }

        public int CountDeck { get; }

        public Coordinate FirstDeck => _decks.First().Key;


        public Coordinate LastDeck => _decks.Last().Key;

        public IEnumerable<Coordinate> GetCoordinatesShip => _decks.Keys.AsEnumerable();

        public int CountDamageDeck 
        { 
            get 
            {
                int count = 0;

                foreach (var item in _decks)
                {
                    if (item.Value.StateDeck == StateDeck.Damage)
                    {
                        count++;
                    }
                }

                return count;
            } 
        }

        public void SetHitDeck(Coordinate shot)
        {
            if (_decks.ContainsKey(shot))
            {
                _decks[shot].StateDeck = StateDeck.Damage;
            }
        }

        public bool IsAliveShip()
        {
            return CountDeck - CountDamageDeck == 0;
        }
    }
}
