using System;
using System.Collections.Generic;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] characters = new string[3] { "Mag", "Knight", "Sorc" };
            Random rnd = new Random();
            Postac[] postacie = new Postac[100];
            for (int i = 0; i < postacie.Length; i++)
            {
                postacie[i] = new Postac(i, characters[rnd.Next(0,3)],tab);
            }
            List<Postac> lista = new List<Postac>();
            for (int i = 0; i < postacie.Length; i++)
            {
                lista.Add((Postac)postacie[i].Clone());
            }
            for (int i = 0; i < postacie.Length; i++)
            {
                for (int j = 0; j < postacie[j].Tab.Length; j++)
                {
                    postacie[i].Tab[j] = 0;
                }
            }
            lista.Sort();
            foreach (var item in lista)
            {
                item.Print();
            }

            
        }
    }
}
