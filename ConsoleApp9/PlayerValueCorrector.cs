using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class PlayerValueCorrector
    {
        static public int Corrector(ref int PlayerValue)
        {
            if (PlayerValue < 2 || PlayerValue > 18) {
                Console.WriteLine("Value of Players is incorrect. Write again: ");
                PlayerValue = Int32.Parse(Console.ReadLine());
                PlayerValueCorrector.Corrector(ref PlayerValue);
            }
            return PlayerValue;
        }
    }
}
