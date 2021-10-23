﻿using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();

            if (int.TryParse(line,out int numberOfCards))
            {
                string[] pickedCards = CardPicker.PickSomeCards(numberOfCards);
                foreach (var item in pickedCards)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("The number you entered is invalid!");
            }
        }
    }
}
