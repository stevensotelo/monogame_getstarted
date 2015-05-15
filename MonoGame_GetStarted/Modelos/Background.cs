using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoGame_GetStarted.Modelos
{
    public class Background
    {
        private Texture2D texture;
        private Rectangle rect1;
        private Rectangle rect2;
        private int r1x;
        private int r2x;
        private int velocity;

        public Background(int velocity)
        {
            this.velocity = velocity;
        }        

        public virtual void initialize()
        {
            r1x = 0;
            rect1 = new Rectangle(r1x, 0, 800, 600);

            r2x = r1x + rect1.Width;
            rect2 = new Rectangle(r2x, 0, 800, 600);
        }

        public virtual void load(ContentManager content)
        {
            texture = content.Load<Texture2D>("images/background/background");
        }

        public virtual void update(GraphicsDevice gd)
        {
            r1x -= velocity;
            r2x -= velocity;

            rect1 = new Rectangle(r1x, 0, 800, 600);
            rect2 = new Rectangle(r2x, 0, 800, 600);

            if (rect1.X + rect1.Width == 0)
                r1x = gd.Viewport.Width;

            if (rect2.X + rect2.Width == 0)
                r2x = gd.Viewport.Width;
        }

        public virtual void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rect1, Color.White);
            spriteBatch.Draw(texture, rect2, Color.White);
        }
    }
}
