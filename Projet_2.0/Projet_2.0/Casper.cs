using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using Projet_2._0.Menus;
using Microsoft.Xna.Framework.Input;



namespace Projet_2._0
{
    public class Casper : Animated
    {
        public Texture2D casper;
        public Controls controls;
        public Camera camera;
        public Animation animation;
        public Vector2 previousPosition;
        public GameType gametype;
        public ParticleEngine particleEngine;

        public Casper(Texture2D casper, Rectangle hitbox) : base(2, casper, hitbox)
        {
            this.casper = casper;
            this.Position = new Vector2(840, 250);
            this.Velocity = new Vector2(0,0);
            this.Speed = 0.01f;
            camera = new Camera(Game1.GetGame().GraphicsDevice.Viewport);
            animation = new Animation();
            List<Texture2D> textures = new List<Texture2D>();
            textures.Add(Content_Manager.getInstance().Textures["particule"]);
            particleEngine = new ParticleEngine(textures, new Vector2(400, 240));

        }


        public void update(GameTime gametime, Controls controls, GameType gametype)
        {
            animation.update(gametime, gametype);
            previousPosition = Position;
            controls.update(gametime, gametype, this);
            Hitbox.X = (int)Position.X;
            Hitbox.Y = (int)Position.Y;
            previousPosition = Position;
            Position = controls.getPosition();
            Velocity = controls.getVelocity();
            casper = animation.getText(animation.getState(Position, previousPosition),gametype);
            camera.update(gametime, this.Position);
            particleEngine.EmitterLocation = new Vector2(Position.X + casper.Width/2, Position.Y + 25) ;
            particleEngine.Update();
        }

        public void Draw(SpriteBatch spritebatch, Color color)
        {

            //spritebatch.DrawString(fontdebug, Convert.ToString(Velocity.X), new Vector2(10, 10), Color.Red);
            //particuleengine.Draw(spritebatch);
            particleEngine.Draw(spritebatch);
            spritebatch.Draw(casper, Position, color);

        }
    }
}
