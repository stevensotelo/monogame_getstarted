using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoGame_GetStarted.Modelos
{
    public class PlayerAnimated : FigureAnimated
    {
        public PlayerAnimated(int frameCount, int framesPerSec)
            : base("images/player/guy",frameCount,framesPerSec)
        {

        }

        public void initialize(GraphicsDeviceManager graphics)
        {
            base.initialize();
            position = new Vector2(graphics.PreferredBackBufferWidth / 2, 50);
        }
    }
}
