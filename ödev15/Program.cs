﻿using System;

namespace Ornek214
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a;
            string s = " ";
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };

            Console.Write("Bir Sayı Giriniz: ");
            if (Byte.TryParse(Console.ReadLine(), out a) && a >= 1 && a <= 99)
            {
                if (a / 10 >= 1)
                {
                    s = Onlar[(a / 10) - 1];
                }

                if (a % 10 != 0)
                {
                    s = s + Birler[(a % 10) - 1];
                }

                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Uygun değer girmediniz.");
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}