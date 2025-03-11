using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcAuto
{
    public class Utilizator
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Functie { get; set; }

        public Utilizator()
        {
            ID = 0;
            Nume = string.Empty;
            Prenume = string.Empty;
            Functie = string.Empty;
        }

        public Utilizator(int id, string nume, string prenume, string functie)
        {
            ID = id;
            Nume = nume;
            Prenume = prenume;
            Functie = functie;
        }

        public string Info()
        {
            return $"ID: {ID}, Nume: {Nume}, Prenume: {Prenume}, Functie: {Functie}";
        }

        public static Utilizator CitireDeLaTastatura()
        {
            Console.Write("Introdu ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Introdu Nume: ");
            string nume = Console.ReadLine();
            Console.Write("Introdu Prenume: ");
            string prenume = Console.ReadLine();
            Console.Write("Introdu Functie: ");
            string functie = Console.ReadLine();


            return new Utilizator(id, nume, prenume, functie);
        }
    }
}
