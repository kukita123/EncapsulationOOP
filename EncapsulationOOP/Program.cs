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
            #region Triangle
            //Triangle t1 = new Triangle();
            //t1.A = 1.7;
            //t1.TriangeType();
            //Console.WriteLine(t1.Area());

            //Triangle t2 = new Triangle(5, 6, 7);
            //t2.TriangeType();
            //Console.WriteLine(t2.Perimeter());
            //Console.WriteLine("Changing t2 side:");
            //t2.A = 6;
            //t2.TriangeType();
            //Console.WriteLine(t2.Perimeter());
            #endregion
            #region Car
            Car car1 = new Car();
            Car car2 = new Car("Fiat", "500e", 4, 180);
            Car car3 = new Car("BMW", "E46", 5, 266);

            if(car1.MaxSpeed > car2.MaxSpeed)
                Console.WriteLine("Fastest car is {0} {1}", car1.Brand, car1.Model);
            else
                Console.WriteLine("Fastest car is {0} {1}", car2.Brand, car2.Model);

            if (car1.MaxSpeed > car3.MaxSpeed)
                Console.WriteLine("Fastest car is {0} {1}", car1.Brand, car1.Model);
            else
                Console.WriteLine("Fastest car is {0} {1}", car3.Brand, car3.Model);

            #endregion
            #endregion

        }
    }
}
