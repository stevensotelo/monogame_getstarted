using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoGame_GetStarted.Modelos
{
    public class MainFigure : Figure
    {
        public MainFigure():base("imagenes/smiley")
        {

        }

        public override void initialize()
        {
            position = Vector2.Zero;
        }

        public override void load(ContentManager content)
        {
            texture = content.Load<Texture2D>(resource);
        }
        
    }
}
