using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Projet_2._0
{
    class AI_moderate : Movable
    {
        public Texture2D texture;
        public Rectangle hitbox;

        public AI_moderate(Texture2D texture, Rectangle hitbox)
            : base(texture, hitbox)
        {
            this.texture = texture;
            this.hitbox = hitbox;
        }

        public void update(GameTime gametime, Casper casper)
        {
            if (hitbox.Intersects(casper.Hitbox))
            {
                Game1.GetGame().Exit();
            }
        
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, hitbox, Color.White);
        }
    }
}
