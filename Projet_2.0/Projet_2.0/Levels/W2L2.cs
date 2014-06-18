using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Projet_2._0.Levels
{
    public class W2L2
    {
        List<Rectangle> w2l2 = new List<Rectangle>();

        public W2L2(Vector2 Position)
        {
            w2l2.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(0), Res.gI().ScaleX(25), Res.gI().ScaleY(1050)));
            w2l2.Add(new Rectangle(Res.gI().ScaleX(1025), Res.gI().ScaleY(0), Res.gI().ScaleX(2520), Res.gI().ScaleY(25)));
            w2l2.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(0), Res.gI().ScaleX(2520), Res.gI().ScaleY(25)));
            w2l2.Add(new Rectangle(Res.gI().ScaleX(2491), Res.gI().ScaleY(0), Res.gI().ScaleX(25), Res.gI().ScaleY(1050)));
            w2l2.Add(new Rectangle(Res.gI().ScaleX(125), Res.gI().ScaleY(701), Res.gI().ScaleX(25), Res.gI().ScaleY(350)));
            w2l2.Add(new Rectangle(Res.gI().ScaleX(1704), Res.gI().ScaleY(701), Res.gI().ScaleX(25), Res.gI().ScaleY(350)));
            w2l2.Add(new Rectangle(Res.gI().ScaleX(237), Res.gI().ScaleY(701), Res.gI().ScaleX(25), Res.gI().ScaleY(350)));
            w2l2.Add(new Rectangle(Res.gI().ScaleX(2370), Res.gI().ScaleY(0), Res.gI().ScaleX(25), Res.gI().ScaleY(404)));
            w2l2.Add(new Rectangle(Res.gI().ScaleX(1705), Res.gI().ScaleY(329), Res.gI().ScaleX(690), Res.gI().ScaleY(25)));
            w2l2.Add(new Rectangle(Res.gI().ScaleX(1412), Res.gI().ScaleY(789), Res.gI().ScaleX(160), Res.gI().ScaleY(86))); 
        }

        public List<Rectangle> getList()
        {
            return w2l2;
        }
    }
}
