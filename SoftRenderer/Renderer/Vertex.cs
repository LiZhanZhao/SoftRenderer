﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SoftRenderer.Math;

namespace SoftRenderer.Renderer
{
    public struct Vertex
    {
        public Vector4 pos;
        public Vector2 uv;
        public Vector4 normal;
        public Color color;

        public Vertex(Vector4 p, Vector2 uv, Vector4 n, Color c)
        {
            this.pos = p;
            this.uv = uv;
            this.normal = n;
            this.color = c;
        }
    }

    
}
