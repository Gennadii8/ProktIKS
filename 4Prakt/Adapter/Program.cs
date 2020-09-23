﻿using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Kost kost = new Kost();
            Gamer g1 = new Gamer("Ivan");
            Console.WriteLine("You have {0} points for player {1}", g1.SeansGame(kost), g1.ToString());

            Monet mon = new Monet();
            IGame bmon = new AdapterGame(mon);
            Console.WriteLine("Coin show \"{0}\" for player {1}", g1.SeansGame(bmon), g1.ToString());
        }
    }
}
