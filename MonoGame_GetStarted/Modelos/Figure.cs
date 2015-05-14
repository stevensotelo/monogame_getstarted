using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoGame_GetStarted.Modelos
{
    public class Figure
    {
        public Texture2D texture { get; set; }
        public Vector2 position { get; set; }
        public string resource { get; set; }
        public Color color { get; set; }

        public Figure(string resource)
        {
            this.resource = resource;
            this.color = Color.White;
        }

        public Figure(string resource, Color color)
        {
            this.resource = resource;
            this.color = color;
        }


        public virtual void initialize()
        {
            position = Vector2.Zero;
        }

        public virtual void load(ContentManager content)
        {
            texture = content.Load<Texture2D>(resource);
        }

        public virtual void update(Vector2 move)
        {
            position = position + move;
        }

        public virtual void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, color);
        }
    }
}
