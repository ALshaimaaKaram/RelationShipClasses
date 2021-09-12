using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationShipClasses
{
    class Rectangle
    {
        //Aggregation
        _2DPoint p1, p2;
        protected int var;

        public Rectangle()
        {

        }

        public Rectangle(_2DPoint p1, _2DPoint p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public int CalculateArea()
        {
            int area;

            int len = p1.x - p2.x;
            int wid = p1.y - p2.y;

            area = Math.Abs(len * wid);

            //double m = (p2.y - p1.y) / (p2.x - p1.x);
            //Math.Atan(m);

            return area;
        }

    }
}
