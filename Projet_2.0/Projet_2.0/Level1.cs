using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Projet_2._0
{
    public class Level1
    {
        List<Rectangle> level1 = new List<Rectangle>();

        public Level1(Vector2 Position)
        {
            level1.Add(new Rectangle(0, 970, 120, 80));
            level1.Add(new Rectangle(Res.gI().ScaleX(120), Res.gI().ScaleY(970), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(240), Res.gI().ScaleY(970), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(360), Res.gI().ScaleY(970), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(480), Res.gI().ScaleY(970), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(720), Res.gI().ScaleY(970), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(840), Res.gI().ScaleY(970), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(960), Res.gI().ScaleY(970), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1080), Res.gI().ScaleY(970), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1200), Res.gI().ScaleY(970), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1320), Res.gI().ScaleY(970), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1560), Res.gI().ScaleY(730), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1560), Res.gI().ScaleY(810), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1560), Res.gI().ScaleY(890), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1560), Res.gI().ScaleY(970), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(840), Res.gI().ScaleY(890), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(960), Res.gI().ScaleY(890), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(960), Res.gI().ScaleY(810), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1080), Res.gI().ScaleY(810), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1080), Res.gI().ScaleY(730), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1320), Res.gI().ScaleY(810), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1320), Res.gI().ScaleY(570), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1440), Res.gI().ScaleY(570), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1200), Res.gI().ScaleY(490), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1320), Res.gI().ScaleY(490), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1080), Res.gI().ScaleY(410), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1200), Res.gI().ScaleY(410), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(840), Res.gI().ScaleY(410), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(960), Res.gI().ScaleY(410), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(840), Res.gI().ScaleY(330), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(480), Res.gI().ScaleY(410), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(600), Res.gI().ScaleY(410), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(120), Res.gI().ScaleY(330), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(240), Res.gI().ScaleY(330), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(120), Res.gI().ScaleY(250), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(360), Res.gI().ScaleY(130), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(600), Res.gI().ScaleY(130), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(840), Res.gI().ScaleY(130), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1080), Res.gI().ScaleY(130), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1320), Res.gI().ScaleY(210), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            level1.Add(new Rectangle(Res.gI().ScaleX(1560), Res.gI().ScaleY(210), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
        }

        public List<Rectangle> getList()
        {
            return level1;
        }
    }
}
