using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Да се създаде клас за ученици Student с полета за име,
 * клас и среден успех на ученик. Да се създаде масив с поне 
 * 10 ученици, да се създадат методи за зареждане на масива
 * с данни, за намиране на учениците с най-висок и най-нисък успех
 * и за подреждаме на учениците по низходяш ред на успеха им. 
 * В класа да има всички задължителни методи - конструктори, 
 * методи за достъп, Метод за извеждане данните на един обект.
 * Всичко разработено да се приложи и тества.
 */
namespace EncapsulationOOP
{
    class Student
    {
        private string _name;
        private string _grade;
        private double _marks;
        public Student()
        {
            this._name = "John Doe";
            this._grade = "9th grade";
            this._marks = 2;
        }
        public Student(string name, string grade, double marks)
        {
            this._name = name;
            this._grade = grade;
            if (marks >= 2 && marks <= 6)
                this._marks = marks;
            else
                this._marks = 2;
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Grade
        {
            get { return this._grade; }
            set { this._grade = value; }
        }
        public double Marks
        {
            get { return this._marks; }
            set
            {
                if (value >= 2 && value <= 6)
                    this._marks = value;
                else
                    this._marks = 2;
            }
        }
        public void DisplayStudent()
        {
            Console.WriteLine(" Student's name: {0}", this.Name);
            Console.WriteLine(" Student's grade: {0}", this.Grade);
            Console.WriteLine(" Student's marks: {0}", this.Marks);
        }
        public string ToString()
        {
            return " Student's name: " + this.Name +
                ", student's grade: " + this.Grade +
                ", student's marks: " + this.Marks;
        }
    }
}
