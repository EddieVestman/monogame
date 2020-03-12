using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Template
{
    class meatballspawner
    {
        private List<Mat> Spawner = new List<Mat>();
        Random random = new Random();

        private Vector2 position;
        private Texture2D texture;
        GraphicsDeviceManager graphics;
        float timer = 1;



        public void Update()
        {
            if (timer <=1 && Spawner.Count < 3)
            {
                Mat mat = new Mat(texture, position);
                mat.meatballPos = new Vector2(random.Next(graphics.PreferredBackBufferWidth-150),-100 );
                Spawner.Add(mat);
                timer += 2;
            }
            for (int i = 0; i < Spawner.Count; i++)
            {
                Spawner[i].Update();
            }
            timer -= 1f / 60;
        }
        public meatballspawner(GraphicsDeviceManager graphics, Texture2D meatballtexture)
        {
            this.graphics = graphics;
            texture = meatballtexture;
        }
        public void Draw(SpriteBatch spritebatch)
        {
            for(int i =0; i<Spawner.Count;i++)
            {
                Spawner[i].Draw(spritebatch);
            }
        }
    }
}
