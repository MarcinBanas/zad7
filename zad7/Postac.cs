using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace zad7
{
    class Postac : ICloneable, IComparable<Postac>, IPrintable
    {
        public int Id;
        public string Tekst;
        public int[] Tab = new int[10];

        public Postac() { }
        public Postac(int id, string tekst, int[] tab)
        {
            Id = id;
            Tekst = tekst;
            Tab = tab;
        }

        public object Clone()
        {
            Postac copyPostac = new Postac();
            copyPostac.Id = this.Id;
            copyPostac.Tekst = this.Tekst;
            for (int i = 0; i < copyPostac.Tab.Length; i++)
            {
                copyPostac.Tab[i] = this.Tab[i];
            }
            return copyPostac;
        }

        public int CompareTo(Postac other)
        {
            if (string.Compare(this.Tekst, other.Tekst) > 0)
            {
                return 1;
            }
            else if (string.Compare(this.Tekst, other.Tekst) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public void Print()
        {

            Console.WriteLine("Postac: " + this.Tekst);
            Console.WriteLine("Id: " + this.Id);
            for (int i = 0; i < this.Tab.Length; i++)
            {
                Console.WriteLine("Statystyka" + " " + i + ": " + this.Tab[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
