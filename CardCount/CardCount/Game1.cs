using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace CardCount
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        Vector2 dealerPosition = new Vector2(800,100);
        Vector2 handPosition = new Vector2(800,600);
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        List<Card> deck = new List<Card>();
        List<Card> playerHand = new List<Card>();
        List<Card> dealer = new List<Card>();
        int bank = 500;
        bool start = true;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = 1000;
            graphics.PreferredBackBufferWidth = 2000;
        }
        public void Deal()
        {
            Card temp;
            for(int i = 1; i < 5; i++)
            {
                temp = deck[i - 1];
                if (i % 2 == 0)
                {
                    dealer.Add(temp);                   
                }
                else
                {
                    playerHand.Add(temp);
                }
                deck.RemoveAt(i - 1);
            }
            foreach (Card c in playerHand)
            {
                c.position = handPosition;
            }
            foreach (Card c in dealer)
            {
                c.position = dealerPosition;
            }

            start = false;
        }
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
 
        {
            Card temp;
            int m, n;
            Random rand = new Random();
            for(int i = 0; i < 10000; i++)
            {
                m = rand.Next(0, 51) + 1;
                n = rand.Next(0, 51) + 1;
                if (m != n)
                {
                    temp = deck[m];
                    deck[m] = deck[n];
                    deck[n] = temp;
                }
            }
        }
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            for(int i = 1;i < 5; i++)
            {
                for(int j = 1; j < 14; j++)
                {
                    Card temp = new Card(i, j, this);
                    temp.LoadContent();
                    //temp.position = new Vector2((j*153)-153,(i*212)-212);
                    temp.position = new Vector2(1000, 400);
                    deck.Add(temp);
                }
            }
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            if(start == true)
            {
                Deal();
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            foreach(Card c in deck)
            {
                c.Draw(spriteBatch);
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
