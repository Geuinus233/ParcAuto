using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Vehicul
    {
        // Constante pentru delimitarea în fișier
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID_VEHICUL = 0;
        private const int MARCA = 1;
        private const int MODEL = 2;
        private const int AN_FABRICATIE = 3;
        private const int NUMAR_INMATRICULARE = 4;
        private const int STARE_TEHNICA = 5;

        public int ID { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }
        public string NumarInmatriculare { get; set; }
        public string StareTehnica { get; set; }

        // Constructor fără parametri
        public Vehicul()
        {
            ID = 0;
            Marca = string.Empty;
            Model = string.Empty;
            AnFabricatie = 0;
            NumarInmatriculare = string.Empty;
            StareTehnica = "Necunoscut";
        }

        // Constructor cu parametri
        public Vehicul(int id, string marca, string model, int anFabricatie, string numarInmatriculare, string stareTehnica)
        {
            ID = id;
            Marca = marca;
            Model = model;
            AnFabricatie = anFabricatie;
            NumarInmatriculare = numarInmatriculare;
            StareTehnica = stareTehnica;
        }

        // Constructor care preia date dintr-o linie de fișier
        public Vehicul(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            
            this.ID = int.Parse(dateFisier[ID_VEHICUL]);
            this.Marca = dateFisier[MARCA];
            this.Model = dateFisier[MODEL];
            this.AnFabricatie = int.Parse(dateFisier[AN_FABRICATIE]);
            this.NumarInmatriculare = dateFisier[NUMAR_INMATRICULARE];
            this.StareTehnica = dateFisier[STARE_TEHNICA];
        }

        public string Info()
        {
            return $"ID: {ID}, Marca: {Marca}, Model: {Model}, An: {AnFabricatie}, Nr. Inmatriculare: {NumarInmatriculare}, Stare: {StareTehnica}";
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectVehiculPentruFisier= string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                SEPARATOR_PRINCIPAL_FISIER,
                ID,
                Marca,
                Model,
                AnFabricatie,
                NumarInmatriculare,
                StareTehnica);
            return obiectVehiculPentruFisier;
        }
        public static Vehicul CitireDelaTastatura()
        {
            Console.Write("Introdu ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Introdu Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Introdu Modelul: ");
            string model = Console.ReadLine();
            Console.Write("Introdu An Fabricatie: ");
            int anFabricatie = int.Parse(Console.ReadLine());
            Console.Write("Introdu Numar Inmatriculare: ");
            string numarInmatriculare = Console.ReadLine();
            Console.Write("Introdu Stare Tehnica: ");
            string stareTehnica = Console.ReadLine();

            return new Vehicul(id, marca, model, anFabricatie, numarInmatriculare, stareTehnica);
        }
    }
}
