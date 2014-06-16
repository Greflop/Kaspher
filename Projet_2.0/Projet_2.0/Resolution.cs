using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Projet_2._0
{
    class Resolution
    {
        public double ScreenWidth;
        public double ScreenHeight;

        public Resolution()
        {
            ScreenWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            ScreenHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
        }

        public int new_resolution_X(int x)
        {
            return x*Convert.ToInt32(ScreenWidth / 1680);
        }
        public int new_resolution_Y(int y)
        {
            return y * Convert.ToInt32(ScreenHeight / 1050);
        }
    }
}
