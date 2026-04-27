using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Да се състави програма, описваща клас за леки автомобили, 
в който има име на автомобила, брой места и максимална скорост и съдържа необходимите свойства. 
Да се дефинират обекти за поне две коли и те да се сравнят според максималната им скорост, 
като се изведат съответните съобщения - напр. име на по-бързия автомобил.
 */
namespace EncapsulationOOP
{
    class Car
    {
        private string _brand;
        private string _model;
        private int _seats;
        private int _maxSpeed;
        public Car()
        {
            this._brand = "Mercedes";
            this._model = "S klass";
            this._seats = 5;
            this._maxSpeed = 260;
        }
        public Car(string brand, string model, int seats, int maxSpeed)
            :this()
        {
            this._brand = brand;
            this._model = model;
            if (seats > 0 && seats <= 7)
                this._seats = seats;
            if (maxSpeed > 0 && maxSpeed < 280)
                this._maxSpeed = maxSpeed;
        }
        public string Brand
        {
            set { this._brand = value; }
            get { return this._brand; }
        }
        public string Model
        {
            set { this._model = value; }
            get { return this._model; }
        }
        public int Seats
        {
            set 
            {
                if (value > 0 && value <= 7)
                   this._seats = value;
            }
            get
            {
                return this._seats;
            }
        }
        public int MaxSpeed
        {
            set
            {
                if (value > 0 && value < 280)
                    this._maxSpeed = value;
            }
            get
            {
                return this._maxSpeed;
            }
        }
    }
}
