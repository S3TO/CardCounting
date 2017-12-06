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
    class Background : GameObject
    {
        public Background(Game myGame): base(myGame)
        {
            textureName = "Table";
        }
        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
        }
    }
}
