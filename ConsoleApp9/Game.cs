using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Game
    {
        public List<Player> PlayerList = new List<Player>();
        public List<Karta> koloda = new List<Karta>();

        public Game(int PlayerValue)
        {
            SuitList suitlist = new SuitList();
            NumberList numberlist = new NumberList();

            for(short CountSuit = 0; CountSuit < suitlist.ListOfSuit.Count; CountSuit++)
            {
                for (short CountNumber = 0; CountNumber < numberlist.ListOfNumbers.Count; CountNumber++)
                {
                    koloda.Add(new Karta(suitlist.ListOfSuit[CountSuit], numberlist.ListOfNumbers[CountNumber], CountNumber + 1));
                }              
            }

            koloda = ShuffleCardClass.ShuffleCardMethod(ref koloda);

            for (short CountPlayer = 0; CountPlayer < PlayerValue; CountPlayer++)
            {
                PlayerList.Add(new Player());
            }
            for(int CountPlayer = 0, xx = 0; xx < 36; xx++, CountPlayer++)
            {
                if (CountPlayer == PlayerList.Count) CountPlayer = 0;
                PlayerList[CountPlayer].PlayerCards.Add(koloda[0]);
                koloda.RemoveAt(0);
            }

        }

        

        
    }
}
