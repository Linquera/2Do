﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDoInterfaces
{
    public interface ICustomGridItem : ITwoDoXml
    {
        bool inControls();
        void SetToControls();
        void SetSize(Size size);
        void SetLocation(Point point);
        void ReloadDisplay();
        int GetItemIndex();
    }
}
