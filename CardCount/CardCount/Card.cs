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
    class Card : GameObject
    {
        protected string suitN;
        protected string valueN;
        public int value;
        public int suit;// 1 = clubs, 2 = diamonds, 3 = hearts, 4 = spades
        public Card(int suit, int value, Game myGame) : base(myGame)
        {
            this.value = value;
            this.suit = suit;
            switch (suit)
            {
                case 1: suitN = "c"; break;
                case 2: suitN = "d"; break;
                case 3: suitN = "h"; break;
                case 4: suitN = "s"; break;
                default: break;
            }
            switch (value)
            {
                case 1: valueN = "01"; break;
                case 2: valueN = "02"; break;
                case 3: valueN = "03"; break;
                case 4: valueN = "04"; break;
                case 5: valueN = "05"; break;
                case 6: valueN = "06"; break;
                case 7: valueN = "07"; break;
                case 8: valueN = "08"; break;
                case 9: valueN = "09"; break;
                case 10: valueN = "10"; break;
                case 11: valueN = "11"; break;
                case 12: valueN = "12"; break;
                case 13: valueN = "13"; break;
                default: break;
            }
            textureName = "c01";
        }
        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
        }
        public override void Draw(SpriteBatch batch)
        {
            if (texture != null)
            {
                Vector2 drawPosition = position;
                batch.Draw(texture, drawPosition, null, Color.White, 0f, Vector2.Zero, 0.2f, SpriteEffects.None, 0f);
            }
        }
    }
}
