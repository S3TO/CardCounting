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
    class Button
    {
        Texture2D texture;
        Vector2 position;
        Rectangle rectangle;

        Color color = new Color(255, 255, 255, 255);

        bool down;
        public bool isClicked;

        public Button()
        {

        }

        public void Load(Texture2D newTexture, Vector2 newPosition)
        {
            texture = newTexture;
            position = newPosition;
        }

        public void Update(MouseState mouse)
        {
            mouse = Mouse.GetState();

            rectangle = new Rectangle((int)position.X, (int)position.Y,
                texture.Width, texture.Height);

            Rectangle mouseRectangle = new Rectangle(mouse.X, mouse.Y,15, 15);

            if (mouseRectangle.Intersects(rectangle))
            {
                if (color.A == 255) down = false;
                if (color.A == 0) down = true;
                if (down) color.A += 3; else color.A -= 3;
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    isClicked = true;
                    color.A = 255;
                }
            }
            else if (color.A < 255)
                color.A += 3;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, color);
        }
    }
}
