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
    class Chip : GameObject
    {
        public float worth;
        public bool inPlay = false;
        Rectangle rectangle;
        public Chip(float worth,Game myGame) : base(myGame)
        {
            this.worth = worth;
            switch (worth)
            {
                case 2.5f: textureName = "2.5";break; 
                case 5: textureName = "Five"; break;
                case 10: textureName = "Ten"; break;
                case 25: textureName = "TwentyFive";break;
                case 50: textureName = "Fifty"; break;
                case 100: textureName = "Hundred";break;
                default: break;
            }
        }
        public void Update(float deltaTime,MouseState mouse)
        {
                mouse = Mouse.GetState();
                rectangle = new Rectangle((int)position.X, (int)position.Y,
                    texture.Width, texture.Height);
                Rectangle mouseRectangle = new Rectangle(mouse.X, mouse.Y, 15, 15);

        }
    }
}
