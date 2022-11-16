using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{

//    Задан класс Building, который описывает здание.Класс содержит следующие элементы:
//    адрес здания;
//    длина здания;
//    ширина здания;
//    высота здания.
//    В классе Building нужно реализовать следующие методы:
//    конструктор с 4 параметрами;
//    свойства get/set для доступа к полям класса;
//    метод Print(), который выводит информацию о здании.
    internal class Building
    {
        string address;//адрес
        double lenght; //длина
        double width;//ширина
        double height;//высота
        
        string Address
        {
            get { return address; }
            set { address = value; }
        }
        double Lenght
        {
            get { return lenght; }
            set 
            {   if (value <= 0) lenght = 0;
                else lenght = value; 
            }
        }
        double Width
        {
            get { return width; }
            set
            {
                if (value <= 0) width = 0;
                else width = value;
            }
        }
        double Height
        {
            get { return height; }
            set
            {
                if (value <= 0) height = 0;
                else height = value;
            }
        }

        public Building(string address, double lenght, double width, double height)
        {
            Address = address;
            Lenght = lenght;
            Width = width;
            Height = height;           
        }

        public string Print()
        {
            return $"{Address} {Lenght} {Width} {Height}";
        }

    }
}
