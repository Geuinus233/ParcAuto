using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Utilizator
    {
        // Constante pentru delimitarea în fișier
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID_UTILIZATOR = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int FUNCTIE = 3;

        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Functie { get; set; }

        // Constructor fără parametri
        public Utilizator()
        {
            ID = 0;
            Nume = string.Empty;
            Prenume = string.Empty;
            Functie = string.Empty;
        }

        // Constructor cu parametri
        public Utilizator(int id, string nume, string prenume, string functie)
        {
            ID = id;
            Nume = nume;
            Prenume = prenume;
            Functie = functie;
        }

        // Constructor care preia date dintr-o linie de fișier
        public Utilizator(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            ID = int.Parse(dateFisier[ID_UTILIZATOR]);
            Nume = dateFisier[NUME];
            Prenume = dateFisier[PRENUME];
            Functie = dateFisier[FUNCTIE];
        }

        public string Info()
        {
            return $"ID: {ID}, Nume: {Nume}, Prenume: {Prenume}, Functie: {Functie}";
        }

        public string ConversieLaSir_PentruFisier()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER,
                ID,
                Nume,
                Prenume,
                Functie);
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



    





