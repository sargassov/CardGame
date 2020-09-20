using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class ShuffleCardClass
    {
        static public List<Karta> ShuffleCardMethod(ref List<Karta>koloda)
        {
            Random rnd = new Random();
            List<Karta> SecondKoloda = new List<Karta>();
            for(int x = 0; x < 36; x++)
            {
                int ConcreteCard = rnd.Next(0, koloda.Count - 1);
                SecondKoloda.Add(koloda[ConcreteCard]);
                koloda.RemoveAt(ConcreteCard);
            }

            return SecondKoloda;
        }
    }
}
