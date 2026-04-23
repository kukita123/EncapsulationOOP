using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Да се състави програма, описваща клас и обекти за триъгълници, която посредством свойства 
изчислява лицето по три страни и вида на триъгълника.
 */
namespace EncapsulationOOP
{
    class Triangle
    {
        #region 9a
        //private double _a;
        //private double _b;
        //private double _c;
        //private bool IsExists(double a, double b, double c)
        //{
        //    if (a > 0 && b > 0 && c > 0 &&
        //        a + b > c &&
        //        a + c > b && 
        //        b + c > a)
        //        return true;
        //    return false;
        //}
        //public Triangle()
        //{
        //    this._a = 1;
        //    this._b = 1;
        //    this._c = 1;
        //}
        //public Triangle(double a, double b, double c)
        //    :this()
        //{
        //    if(IsExists(a, b,c))
        //    {
        //        this._a = a;
        //        this._b = b;
        //        this._c = c;
        //    }
        //}
        //public double A
        //{
        //    get { return this._a; }
        //    set 
        //    { 
        //        if(IsExists(value, this._b, this._c))
        //            this._a = value; 
        //    }
        //}
        //public double B
        //{
        //    get { return this._b; }
        //    set { this._b = value; }
        //}
        //public double C
        //{
        //    get { return this._c; }
        //    set { this._c = value; }
        //}
        //public double Perimeter()
        //{
        //    return A + B + C;  //this._a + this._b + this._c;
        //}
        //public double Area()
        //{
        //    double p = Perimeter() / 2;
        //    return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        //}
        //public string Type()
        //{
        //    if (A == B && B == C)
        //        return "Equalateral";
        //    else if (A != B && B != C)
        //        return "Versatile";
        //    else 
        //        return "Isosceles";
        //}
        #endregion

        #region 9b
        private double _a;
        private double _b;
        private double _c;

        //set, get:
        public double A
        {
            set //верификация:
            {
                if (IsExists(value, this._b, this._c))
                    this._a = value;
            }
            get { return this._a; }
        }
        public double B
        {
            set //верификация:
            {
                if (IsExists(this._a, value, this._c))
                    this._b = value;
            }
            get { return this._b; }
        }
        public double C
        {
            set //верификация:
            {
                if (IsExists(this._a, this._b, value))
                    this._c = value;
            }
            get { return this._c; }
        }

        //constructors:
        public Triangle()
        {
            this._a = 1;
            this._b = 1;
            this._c = 1;
        }
        public Triangle(double a, double b, double c)
            : this()
        {
            if (IsExists(a, b, c))
            {
                this._a = a;
                this._b = b;
                this._c = c;
            }
        }
        private bool IsExists(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
        }
        public double Perimeter()
        {
            return A + B + C; //by using get methods
            //return this._a + this._b + this._c;  //by using fields
        }
        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));//get!!!
            //return Math.Sqrt(p * (p - this._a) * (p - this._b) * (p - this._c));//fields!!!
        }
        public void TriangeType()
        {
            if(A == B && B == C)
                Console.WriteLine("Triangle is equalateral");
            else if(A !=B && B !=C)
                Console.WriteLine("Triangle is versatile");
            else
                Console.WriteLine("Triangle is isosceles");
        }
        #endregion
    }
}
