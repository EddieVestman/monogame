using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Template
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    /// 

        // Game World
        
        
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D bulldog;
        Rectangle bulldogPos;
        Texture2D meatballtexture;
        Vector2 meatballPos;
        Mat meatball;
        Random random = new Random();



        //KOmentar
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            //graphics.IsFullScreen = true;
            graphics.ApplyChanges();
            

            
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            bulldogPos = new Rectangle(new Point(0,0), new Point(180, 180));
            bulldogPos.Y = graphics.PreferredBackBufferHeight - bulldogPos.Height;
            bulldogPos.X = graphics.PreferredBackBufferWidth /2 - bulldogPos.Width /2;

            meatballtexture = Content.Load<Texture2D>("meatball");
            meatball = new Mat(meatballtexture);

            meatballPos.X = random.Next(graphics.PreferredBackBufferWidth);
            meatballPos.Y = -20;

            meatball.meatballPos = meatballPos;

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
            bulldog = Content.Load<Texture2D>("bulldog");
            meatballtexture = Content.Load<Texture2D>("meatball");



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


        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
              KeyboardState kstate = Keyboard.GetState();
	        if (kstate.IsKeyDown(Keys.Right) && bulldogPos.X < graphics.PreferredBackBufferWidth -bulldogPos.Width )
		        bulldogPos.X+= 17;
	        if (kstate.IsKeyDown(Keys.Left) && bulldogPos.X > 0)
		        bulldogPos.X-= 17;

            meatball.Update();


            //LoadContent();
            base.Update(gameTime);
        }
       

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Pink);
            spriteBatch.Begin();
	        spriteBatch.Draw(bulldog, bulldogPos, Color.White);
            meatball.Draw(spriteBatch);





            spriteBatch.End();
            // TODO: Add your drawing code here.

            base.Draw(gameTime);

            
        }
    }
}
