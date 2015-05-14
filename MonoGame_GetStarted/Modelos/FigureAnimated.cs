using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoGame_GetStarted.Modelos
{
    public class FigureAnimated : Figure
    {
        public int frameCount { get; set; }
        private float timePerFrame { get; set; }
        private int frame { get; set; }
        private float totalElapsed { get; set; }

        public FigureAnimated(string resource, int frameCount, int framesPerSec)
            : base(resource)
        {
            this.frameCount = frameCount;
            this.timePerFrame = 1.0f / framesPerSec;            
        }

        public override void initialize()
        {
            base.initialize();
            this.frame = 0;
            this.totalElapsed = 0;            
        }

        public void update(float elapsed)
        {
            //base.update(move);
            totalElapsed += elapsed;
            if (totalElapsed > timePerFrame)
            {
                frame++;
                //Los frames son circulares, al llegar al último volvemos al primero.
                frame = frame % frameCount;
                totalElapsed -= timePerFrame;
            }
        }

        public virtual void draw(SpriteBatch spriteBatch)
        {
            draw(spriteBatch, frame);
        }

        public virtual void draw(SpriteBatch spriteBatch, int frame)
        {
            int frameWidth = texture.Width / frameCount;
            Rectangle sourceRect = new Rectangle(frameWidth * frame, 0, frameWidth, texture.Height);
            spriteBatch.Draw(texture, position, sourceRect, Color.White, 0, new Vector2(0, 0), 1, SpriteEffects.None, 1);
        }
    }
}