using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Да се състави програма, описваща клас SalesPerson (продавач). 
Данните на класа са: име и фамилия на продавач, месечните продажби в 
продължение на една година (масив от 12 елемента от тип double). 
Добавете валидация на данните - името и фамилията на продавача да съдържат 
поне 3 символа.
Методите на класа включват въвеждане и извеждане на данни за обектите от класа, 
намиране на общата и средната сума на продажбите за 12-те месеца, конструктори. 
Тествайте дефинираните методи, като създадете поне два обекта от класа и 
сравните техните средномесечни продажби*/
namespace EncapsulationOOP
{
    class SalesPerson
    {
        private string _name;
        private string _family;
        private double[] _sales;
        public SalesPerson()
        {
            this._name = "";
            this._family = "";
            _sales = new double[12]; //!!!!!!!!!!!!!
        }
        public SalesPerson(string name, string family)
        {
            this._name = name;
            this._family = family;
            _sales = new double[12];
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Family
        {
            get { return this._family; }
            set { this._family = value; }
        }
        public double[] Sales
        {
            get { return this._sales; }
            set
            {
                for (int i = 0; i < 12; i++)
                {
                    if (value[i] > 0)
                        this._sales[i] = value[i];
                }
            }
        }
    }
}
