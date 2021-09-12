﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationShipClasses
{
    class Line
    {
        //Composation
        _2DPoint p1, p2;

        public Line()
        {

        }

        public Line(_2DPoint p1, _2DPoint p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public int GetLength()
        {
            int len = (int)Math.Sqrt((Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2)));

            return len;
        }
    }
}
