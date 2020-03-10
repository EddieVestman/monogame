using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    class Mat
    {
        Vector2 position;
        Texture2D texture;

        public Mat(Texture2D texture)
        {
            this.texture = texture;
        }
        public Vector2 meatballPos { set { position = value; } }

        public void Update ()
        {
            position.Y += 10;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle(position.ToPoint(), new Point(200, 200)), Color.White);
        }
    }
}
