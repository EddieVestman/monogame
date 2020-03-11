using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    class MatSpawner
    {
        private List<Mat> Spawner = new List<Mat>();
        Random random = new Random();
        Texture2D meatballtexture;

       /* protected override void LoadContent()
        {
            meatballtexture = Content.Load<Texture2D>("meatball");
        }
        public void Update()
        {
            Mat mat = new Mat(meatballtexture);
            mat.meatballPos.X = random.Next(graphics.PreferredBackBufferWidth);

        }

        public void Draw()
        {
        
        }
        */
    }
}
