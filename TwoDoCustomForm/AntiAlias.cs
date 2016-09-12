using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDoCustomForm
{
    internal class AntiAlias : IDisposable
    {
        private Graphics graphics;
        private SmoothingMode Mode;

        public AntiAlias(Graphics g)
        {
            graphics = g;
            Mode = g.SmoothingMode;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        public void Dispose()
        {
            graphics.SmoothingMode = Mode;
        }
    }
}
