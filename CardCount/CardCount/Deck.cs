using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CardCount
{
    class Deck : GameObject
    {
        public List<Card> deck = new List<Card>();
        public Deck(Game myGame) : base(myGame)
        {

        }
    }
}
