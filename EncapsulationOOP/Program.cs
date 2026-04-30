using System;

namespace EncapsulationOOP
{
    class Program
    {
        static void CompareCars(Car car1, Car car2)
        {
            if (car1.MaxSpeed > car2.MaxSpeed)
                Console.WriteLine("The Fastets Car Is {0} {1}", 
                    car1.Brand, car1.Model);
            else
                Console.WriteLine("The Fastets Car Is {0} {1}", 
                    car2.Brand, car2.Model);
        }
        static void Main(string[] args)
        {
            #region 9a
            #region Triangle
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
            #region Car
            //Car car1 = new Car();
            //Car car2 = new Car("Kia", "Rio", 5, 180);
            //Car car3 = new Car("Fiat", "500e", 4, 160);
            //Car car4 = new Car("Porshe", "Cayen", 4, 260);

            //CompareCars(car1, car3);
            //CompareCars(car2, car3);
            //car3.MaxSpeed = 181;
            //CompareCars(car2, car3);

            #endregion
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

            if (car1.MaxSpeed > car2.MaxSpeed)
                Console.WriteLine("Fastest car is {0} {1}", car1.Brand, car1.Model);
            else
                Console.WriteLine("Fastest car is {0} {1}", car2.Brand, car2.Model);

            if (car1.MaxSpeed > car3.MaxSpeed)
                Console.WriteLine("Fastest car is {0} {1}", car1.Brand, car1.Model);
            else
                Console.WriteLine("Fastest car is {0} {1}", car3.Brand, car3.Model);

            //objects array:
            Car[] cars = new Car[5];
            //constructor for every object in the array cars
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = new Car();
            }
            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write("Enter Brand: ");
                cars[i].Brand = Console.ReadLine();
                Console.Write("Enter Model: ");
                cars[i].Model = Console.ReadLine();
                Console.Write("Enter Seats: ");
                cars[i].Seats = int.Parse(Console.ReadLine());
                Console.Write("Enter Max Speed: ");
                cars[i].MaxSpeed = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(cars[0].MaxSpeed);
            Console.WriteLine(cars[3].MaxSpeed);
            #endregion
            #endregion

        }
    }
}
