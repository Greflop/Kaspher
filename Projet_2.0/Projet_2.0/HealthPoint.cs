using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Projet_2._0.Menus;

namespace Projet_2._0
{
    public class HealthPoint
    {
        public int healthpoint;
        public Boolean respawn;

        public HealthPoint(int healthpoint)
        {
            this.healthpoint = healthpoint;
            respawn = false;
        }

        public void update(Casper casper, List<Rectangle> spikes)
        {
            foreach (Rectangle rect in spikes)
            {
                if (casper.Hitbox.Intersects(rect))
                {
                    //Game1.GetGame().Exit();
                    respawn = true;
                    healthpoint += -1;
                }
            }
        }

        public void draw(SpriteBatch spritebatch, Camera camera)
        {
            spritebatch.Draw(Content_Manager.getInstance().Textures["enemy1"], new Rectangle((int)camera.centre.X, (int)camera.centre.Y, Res.gI().ScaleX(44), Res.gI().ScaleY(40)), Color.White);
            if (healthpoint > 3)
                spritebatch.Draw(Content_Manager.getInstance().Textures["enemy1"], new Rectangle((int)camera.centre.X + Res.gI().ScaleX(44), (int)camera.centre.Y, Res.gI().ScaleX(44), Res.gI().ScaleY(40)), Color.White);
            if (healthpoint > 6)
                spritebatch.Draw(Content_Manager.getInstance().Textures["enemy1"], new Rectangle((int)camera.centre.X + Res.gI().ScaleX(44)*2, (int)camera.centre.Y, Res.gI().ScaleX(44), Res.gI().ScaleY(40)), Color.White);
            if (healthpoint > 9)
                spritebatch.Draw(Content_Manager.getInstance().Textures["enemy1"], new Rectangle((int)camera.centre.X + Res.gI().ScaleX(44)* 3, (int)camera.centre.Y, Res.gI().ScaleX(44), Res.gI().ScaleY(40)), Color.White);
            if (healthpoint > 12)
                spritebatch.Draw(Content_Manager.getInstance().Textures["enemy1"], new Rectangle((int)camera.centre.X + Res.gI().ScaleX(44) *4, (int)camera.centre.Y, Res.gI().ScaleX(44), Res.gI().ScaleY(40)), Color.White);
        }

    }
}
