using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationShipClasses
{
    //Inherit
    class Square : Rectangle
    {
        public Square()
        {

        }

        public Square(int var)
        {
            base.var = var;
        }

        public void display()
        {
            Console.WriteLine("The X is " + this.var);
        }
    }
}
