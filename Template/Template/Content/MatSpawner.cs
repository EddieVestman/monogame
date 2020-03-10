using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Content
{
    class MatSpawner
    {
        private List<Mat> Spawner = new List<Mat>();
        Random random = new Random();


        public void Update()
        {
            Mat mat = new Mat();
            mat.meatballPos.X = random.Next(graphics.PreferredBackBufferWidth);

        }

    }
}
