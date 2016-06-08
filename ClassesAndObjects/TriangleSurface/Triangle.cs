using System;

namespace TriangleSurface
{
    class Triangle
    {
        static double BaseByHeight(double Base, double Height)
        {
            return 0.5 * (Base * Height);
        }
        static double ThreeSides(double a, double b, double c)
        {
            double semiP = (a + b + c) / 2;
            return Math.Sqrt(semiP * (semiP - a) * (semiP - b) * (semiP - c));
        }
        static double SideAngleSide(double a, double b, double C)
        {
           return (a * b * Math.Sin(C *( Math.PI / 180))) / 2.0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(BaseByHeight(23.2, 5));
            Console.WriteLine("{0:0.00}", ThreeSides(11,12,13));
            Console.WriteLine("{0:0.00}",SideAngleSide(10,7,25));
        }
    }
}
