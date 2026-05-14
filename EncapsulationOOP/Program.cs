using System;
/*
 * Да се създаде клас за ученици Student с полета за име,
 * клас и среден успех на ученик. Да се създаде масив с поне 
 * 10 ученици, да се създадат методи за зареждане на масива
 * с данни, за намиране на учениците с най-висок и най-нисък успех
 * и за подреждане на учениците по низходяш ред на успеха им. 
 * В класа да има всички задължителни компоненти - конструктори, 
 * методи за достъп, метод за извеждане данните на един обект.
 * Всичко разработено да се приложи и тества.
 */
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
        static double DistanceBetweenPoints(Point first, Point second)
        {
            return Math.Sqrt(Math.Pow(first.X - second.X, 2) + Math.Pow(first.Y - second.Y, 2));
        }
        static void InputStudentsData(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Enter name: ");
                students[i].Name = Console.ReadLine();
                Console.Write("Enter grade: ");
                students[i].Grade = Console.ReadLine();
                Console.Write("Enter marks: ");
                students[i].Marks = double.Parse(Console.ReadLine());
            }
        }
        static Student MaxMarkStudent(Student[] students)
        {
            Student maxMarkStudent = new Student();
            double maxMark = 2;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Marks > maxMark)
                {
                    maxMarkStudent = students[i];
                    maxMark = students[i].Marks;
                }                    
            }
            return maxMarkStudent;
        }
        static Student MinMarkStudent(Student[] students)
        {
            Student minStudent = new Student();
            double min = 6;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Marks < min)
                {
                    min = students[i].Marks;
                    minStudent = students[i];
                }
            }
            return minStudent;
        }
        static void SortStudents(Student[]students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0; j < students.Length - 1; j++)
                {
                    if (students[j].Marks < students[j + 1].Marks)
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
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

            ////да се създаде масив от 5 коли, да се зареди
            //// със стойности и да се приложи сравнение на
            //// всяка кола с останалите
            //Car[] cars = new Car[5];
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    cars[i] = new Car();
            //}
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine("Enter Brand - car number [{0}]: ", i);
            //    cars[i].Brand = Console.ReadLine();
            //    Console.WriteLine("Enter Model - car number [{0}]: ", i);
            //    cars[i].Model = Console.ReadLine();
            //    Console.WriteLine("Enter Seats - car number [{0}]: ", i);
            //    cars[i].Seats = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Max Speed - car number [{0}]: ", i);
            //    cars[i].MaxSpeed = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(cars[2].MaxSpeed);
            //for (int i = 0; i < cars.Length - 1; i++)
            //{
            //    for (int j = 0; j < cars.Length; j++)
            //    {
            //        CompareCars(cars[i], cars[j]);
            //    }
            //}
            #endregion
            #region Point
            //Point p1 = new Point();
            //Point p2 = new Point(2, 3);
            //Console.WriteLine(p1.DistanceToPoint(p2));
            //Console.WriteLine(p2.DistanceToPoint(p1));
            //Console.WriteLine(DistanceBetweenPoints(p1, p2));

            //Random r = new Random();
            //int n = r.Next(5, 10);

            //Point[] points = new Point[n];

            //for (int i = 0; i < points.Length; i++)
            //{
            //    points[i] = new Point(r.Next(-10, 10), r.Next(-10, 10));
            //    Console.WriteLine("points[{0}] coordinates: ({1}, {2})", i, points[i].X, points[i].Y);
            //}
            //Console.WriteLine();

            //double min = DistanceBetweenPoints(points[0], points[1]);
            //for (int i = 0; i < points.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < points.Length; j++)
            //    {
            //        double newDistance = DistanceBetweenPoints(points[i], points[j]);
            //        if (newDistance < min)
            //            min = newDistance;
            //    }
            //}
            //Console.WriteLine("Min distance between points is: {0}", min);

            //Console.WriteLine();
            #endregion

            #region Student

            //Student student1 = new Student("Mariana Hristozkova", "101A", 3.67);
            //student1.DisplayStudent();
            //Console.WriteLine(student1.ToString());

            //Student[] students = new Student[3];

            //for (int i = 0; i < students.Length; i++)
            //{
            //    students[i] = new Student();
            //}

            //InputStudentsData(students);

            //foreach (var item in students)
            //{
            //    item.DisplayStudent();
            //}

            //Console.WriteLine("Max marks student: {0}",MaxMarkStudent(students).ToString());
            //Console.WriteLine("Min marks student: {0}", MinMarkStudent(students).ToString());

            //SortStudents(students);
            //Console.WriteLine("After sorting:");

            //foreach (var item in students)
            //{
            //    item.DisplayStudent();
            //}
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
            //Car car1 = new Car();
            //Car car2 = new Car("Fiat", "500e", 4, 180);
            //Car car3 = new Car("BMW", "E46", 5, 266);

            //if (car1.MaxSpeed > car2.MaxSpeed)
            //    Console.WriteLine("Fastest car is {0} {1}", car1.Brand, car1.Model);
            //else
            //    Console.WriteLine("Fastest car is {0} {1}", car2.Brand, car2.Model);

            //if (car1.MaxSpeed > car3.MaxSpeed)
            //    Console.WriteLine("Fastest car is {0} {1}", car1.Brand, car1.Model);
            //else
            //    Console.WriteLine("Fastest car is {0} {1}", car3.Brand, car3.Model);

            ////да се създаде масив от 5 коли, да се зареди
            //// със стойности и да се приложи сравнение на
            //// всяка кола с останалите

            ////objects array:
            //Car[] cars = new Car[5];
            ////constructor for every object in the array cars
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    cars[i] = new Car();
            //}
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.Write("Enter Brand: ");
            //    cars[i].Brand = Console.ReadLine();
            //    Console.Write("Enter Model: ");
            //    cars[i].Model = Console.ReadLine();
            //    Console.Write("Enter Seats: ");
            //    cars[i].Seats = int.Parse(Console.ReadLine());
            //    Console.Write("Enter Max Speed: ");
            //    cars[i].MaxSpeed = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine(cars[0].MaxSpeed);
            //Console.WriteLine(cars[3].MaxSpeed);

            ////CompareCars(cars[0], cars[1]);
            //for (int i = 0; i < cars.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < cars.Length; j++)
            //    {
            //        CompareCars(cars[i], cars[j]);
            //    }
            //}
            #endregion
            #region Point
            //Random r = new Random();
            //Point[] points = new Point[10];
            //for (int i = 0; i < points.Length; i++)
            //{
            //    points[i] = new Point(r.Next(-20, 20) + r.NextDouble(), r.Next(-20, 20) + r.NextDouble());
            //}
            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.WriteLine("points[{0}] coordinates: ({1}, {2})", i, Math.Round(points[i].X, 2), Math.Round(points[i].Y, 2));
            //}

            //double min = DistanceBetweenPoints(points[0], points[1]);
            //for (int i = 0; i < points.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < points.Length; j++)
            //    {
            //        if (DistanceBetweenPoints(points[i], points[j]) < min)
            //            min = DistanceBetweenPoints(points[i], points[j]);
            //    }
            //}
            //Console.WriteLine("Minimum distance: {0}", Math.Round(min, 2));
            //Point A = new Point(5, 4);
            //Point B = new Point(-3, 3);
            //Console.WriteLine(A.DistanceToPoint(B));
            //Console.WriteLine(B.DistanceToPoint(A));

            #endregion
            #region Student
            Student student1 = new Student("Mariana Hristozkova", "101A", 3.67);
            student1.DisplayStudent();
            Console.WriteLine(student1.ToString());

            Student[] students = new Student[3];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }

            InputStudentsData(students);

            Console.WriteLine(MaxMarkStudent(students).ToString());
            MinMarkStudent(students).DisplayStudent();

            SortStudents(students);
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].ToString());
            }
            #endregion
            #endregion

        }
    }
}
