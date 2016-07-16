﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SoftRenderer.Math;

namespace SoftRenderer.Renderer
{
    class TestData
    {
        

        //顶点坐标
        public static Vector4[] pointList = {
                                            new Vector4(-1,  1, -1, 1),
                                            new Vector4(-1, -1, -1, 1),
                                            new Vector4(1, -1, -1, 1),
                                            new Vector4(1, 1, -1, 1),

                                            new Vector4( -1,  1, 1, 1),
                                            new Vector4(-1, -1, 1, 1),
                                            new Vector4(1, -1, 1, 1),
                                            new Vector4(1, 1, 1, 1)
                                        };
        //三角形顶点索引 12个面
        public static int[] indexs = {   0,1,2,
                                   0,2,3,
                                   //
                                   7,6,5,
                                   7,5,4,
                                   //
                                   0,4,5,
                                   0,5,1,
                                   //
                                   1,5,6,
                                   1,6,2,
                                   //
                                   2,6,7,
                                   2,7,3,
                                   //
                                   3,7,4,
                                   3,4,0
                               };
    }
}
