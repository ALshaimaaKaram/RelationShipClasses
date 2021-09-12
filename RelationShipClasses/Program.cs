using System;

namespace RelationShipClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            _2DPoint p1 = new _2DPoint(1, 5);
            _2DPoint p2 = new _2DPoint(3, 6);
            Line line = new Line(p1, p2);


            Console.WriteLine("The length is " + line.GetLength());


            Rectangle rectangle = new Rectangle(p1, p2);
            Console.WriteLine("The Area is " + rectangle.CalculateArea());

            //Console.WriteLine(Math.Tan(45 * (Math.PI / 180)));


            Square square = new Square(10);
            square.display();
        }
    }
}
