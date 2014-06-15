using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Projet_2._0
{
    class AI : Movable
    {
        public Texture2D texture, texture1, texture2;
        public Rectangle hitbox;
        public Vector2 Acceleration;
        public float speed;

        public AI(Texture2D texture1,Texture2D texture2, Rectangle hitbox)
            : base(texture1, hitbox)
        {
            this.texture1 = texture1;
            this.texture2 = texture2;
            this.hitbox = hitbox;
            this.Position = new Vector2(1000, 370);
            this.Velocity = new Vector2(3, 0);
            this.Acceleration = new Vector2(10, 10);
            this.speed = 0.01f;
            this.texture = texture1;
        }
        public void update(GameTime gametime, int leftborne, int rightborne)
        {
            if (Position.X < leftborne || Position.X > rightborne)
            {
                Velocity.X = -Velocity.X;
                if (texture == texture2)
                {
                    texture = texture1;
                }
                else
                {
                    texture = texture2;
                }
            }
            Position += Velocity;// *speed;
        }
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, Position, Color.White);
        }
    }
}
