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
        public Chip(float worth,Game myGame) : base(myGame)
        {
            this.worth = worth;
            switch (worth)
            {
                case 2.5f: textureName = "2.5";break; 
                case 5: textureName = "5"; break;
                case 10: textureName = "10"; break;
                case 25: textureName = "25";break;
                case 50: textureName = "50"; break;
                case 100: textureName = "100";break;
                default: break;
            }
        }
        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
        }
    }
}
