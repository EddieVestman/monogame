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

        List<Mat> Meatballs = new List<Mat>();

        meatballspawner mbs;



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

         /*   for (int i = 0; i < 1; i++)
            {
                meatballPos.X = random.Next(graphics.PreferredBackBufferWidth);
                meatballPos.Y = -20;
                meatball = new Mat(meatballtexture,meatballPos);

                Meatballs.Add(meatball);
            }
            */
            //meatball.meatballPos = meatballPos;

            base.Initialize();
        }

       
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            bulldog = Content.Load<Texture2D>("bulldog");
            meatballtexture = Content.Load<Texture2D>("meatball");
            mbs = new meatballspawner( graphics,  meatballtexture);


        }

      
        protected override void UnloadContent()
        {
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

            mbs.Update();

            //meatball.Update();

          /*  if(Meatballs.Count<2)
            {
                meatballPos.X = random.Next(graphics.PreferredBackBufferWidth);
                meatballPos.Y = -20;
                meatball = new Mat(meatballtexture, meatballPos);

                Meatballs.Add(meatball);
            }

            foreach (Mat kB in Meatballs)
            {
                kB.Update();
            }
            */
            
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

            mbs.Draw(spriteBatch);
            
          /*  foreach(Mat kB in Meatballs)
            {
                kB.Draw(spriteBatch);
            }
            */
          //  meatball.Draw(spriteBatch);





            spriteBatch.End();
            // TODO: Add your drawing code here.

            base.Draw(gameTime);

            
        }
    }
}
