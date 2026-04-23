using System;

namespace EncapsulationOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 9a
            //Triangle t1 = new Triangle();
            //Triangle t2 = new Triangle(5, 6, 7);
            //Console.WriteLine(t1.Type());
            //Console.WriteLine(t2.Type());
            //t1.A = 10;
            //t1.B = 11;
            //t1.C = 11;
            //Console.WriteLine(t1.Type());
            //Console.WriteLine(t1.Area());
            //t1.A = 560;
            //Console.WriteLine(t1.A);
            #endregion

            #region 9b
            Triangle t1 = new Triangle();
            t1.A = 1.7;
            t1.TriangeType();
            Console.WriteLine(t1.Area());

            Triangle t2 = new Triangle(5, 6, 7);
            t2.TriangeType();
            Console.WriteLine(t2.Perimeter());
            Console.WriteLine("Changing t2 side:");
            t2.A = 6;
            t2.TriangeType();
            Console.WriteLine(t2.Perimeter());
            #endregion

        }
    }
}
