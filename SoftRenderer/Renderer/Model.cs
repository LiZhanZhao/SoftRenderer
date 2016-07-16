﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SoftRenderer.Math;
namespace SoftRenderer.Renderer
{
    class Model : Node
    {
        private Mesh _mesh;

        public Model()
        {
            _mesh = null;
        }

        public void SetMesh(Vertex[] v, int[] indexs)
        {
            _mesh = new Mesh(v, indexs);
        }

        public void SetMesh(Vector4[] posList, int[] indexs)
        {
            List<Vertex> vertexList = new List<Vertex>();
            for (int i = 0; i < posList.Length; i++)
            {
                Vertex v = new Vertex();
                v.pos = posList[i];
                vertexList.Add(v);
            }
            SetMesh(vertexList.ToArray(), indexs);
        }

        public Mesh GetMesh()
        {
            return _mesh;
        }
    }
}