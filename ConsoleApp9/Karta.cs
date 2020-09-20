using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Karta
    {
        public string suit { get; set; }
        public string number { get; set; }

        public int power { get; set; }
        public Karta(string SetSuit, string SetNumber, int SetPower)
        {
            suit = SetSuit;
            number = SetNumber;
            power = SetPower;

        }
    }
}
