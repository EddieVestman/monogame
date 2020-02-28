using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template.Content
{
    class Mat
    {
        Vector2 position;
        Texture2D texture;
        Vector2 center;
        float angle = 0;

        public Mat(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.center = position;
        }
        public void Update()
        {
            angle -= .1f;
            position.X = center.X + (float)Math.Sin(angle) * 30;
            position.Y = center.Y + (float)Math.Cos(angle) * 30;
        }
        public void Draw (SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle(position.ToPoint(), new Point(15, 15)), Color.White);
        }
    }
}
