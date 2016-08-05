﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.Rasterizetion
{
    public abstract class RenderTarget
    {
        virtual public void Write(int x, int y, System.Drawing.Color col){ }
        virtual public int Width() { return 0; }
        virtual public int Height() { return 0; }
    }
}
