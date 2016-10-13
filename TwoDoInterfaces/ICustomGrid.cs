﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDoInterfaces
{
    public interface ICustomGrid
    {
        ContextMenuStrip FloatingMenu { get; set; }
        void OpenFloatingMenu(MouseEventArgs e);
    }
}