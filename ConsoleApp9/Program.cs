using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value of players: ");
            int Playervalue = Int32.Parse(Console.ReadLine());
            PlayerValueCorrector.Corrector(ref Playervalue);
            Game game = new Game(Playervalue);
            int move = 1;
            List<Karta> GameTable = new List<Karta>();
            while (true)
            {
                int CurrentPlayer = -1;
                Console.WriteLine("\t\t\t\t\tMove " + move + "\n\n");
                int x = 0, MaxPower = 0;
                foreach (Player player in game.PlayerList)
                {
                    if (player.PlayerCards.Count > 0)
                    {
                        Console.Write((x + 1) + " Player put a " + player.PlayerCards[0].suit + " "
                        + player.PlayerCards[0].number + "     ");
                        GameTable.Add(player.PlayerCards[0]);
                        if (player.PlayerCards[0].power > MaxPower)
                        {
                            MaxPower = player.PlayerCards[0].power;
                            CurrentPlayer = x;
                        }
                        player.PlayerCards.RemoveAt(0);
                        Console.WriteLine("(" + player.PlayerCards.Count + ") cards in have " + "\n");
                        
                    }
                    else Console.WriteLine("For " + (x + 1) + " Player GAME is OVER!");
                    x++;
                }
                game.PlayerList[CurrentPlayer].PlayerCards.AddRange(GameTable);
                Console.WriteLine(CurrentPlayer + 1 + " Player takes all of cards\n-------------------------------------------");
                GameTable.Clear();
                if (game.PlayerList[CurrentPlayer].PlayerCards.Count == 36)
                {
                    Console.WriteLine("\n\n\n\t\t\tPlayer " + CurrentPlayer + " win this game!\n\n\n");
                    break;
                }
                System.Threading.Thread.Sleep(2000);
                move++;
            }

        }
    }
}
