using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4PratikEncapsulation
{
    public class Car
    {
        //Field tanımlamaları
        private string _trademark;
        private string _model;
        private string _color;
        private int _doorNumber;
       
        //Constructor tanımlaması
        public Car(string trademark, string model, string color, int doorNumber)
        {
            Trademark = trademark;
            Model = model;
            Color = color;
            DoorNumber = doorNumber; 
        }
        //Propetry tanımlamaları
        public string Trademark { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
        
        public int DoorNumber
        {
            get
            {
                return _doorNumber;
            }
            set//Kapsülleme işlemi
            {
                if (value == 2 || value == 4)
                {
                    _doorNumber = value;
                }
                else
                {
                    Console.WriteLine("Araba kapı sayısı 2 veya 4 olmalıdır.");
                    _doorNumber = -1; // Geçersiz bir değer atanabilir
                }
            }
        }

        public void Display()
        {
            Console.WriteLine($"Kayıdı Oluşturulan arabanın markası {Trademark}, Modeli {Model}, Rengi {Color}, Kapı Sayısı {DoorNumber}");
        }
    }
}
