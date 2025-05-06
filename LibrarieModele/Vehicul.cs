using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace LibrarieModele
{
    public class Vehicul
    {
        // Constante pentru delimitarea în fișier
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char Separator_secundar = ',';
        private const int ID_VEHICUL = 0;
        private const int MARCA = 1;
        private const int MODEL = 2;
        private const int AN_FABRICATIE = 3;
        private const int NUMAR_INMATRICULARE = 4;
        private const int STARE_TEHNICA = 5;
        private const int CULOARE = 6;
        private const int Optiuni_Vehicule = 7;




        public int ID { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }
        public string NumarInmatriculare { get; set; }
        public string StareTehnica { get; set; }
        public Culoare Culoare { get; set; }
        public ArrayList OptiuniVehicule { get; set; }
        // Constructor fără parametri


        public string OptiuniVehiculeAsString
        {
            get
            {
                return string.Join(Separator_secundar.ToString(), OptiuniVehicule.ToArray());
            }
        }
        public Vehicul()
        {
            ID = 0;
            Marca = string.Empty;
            Model = string.Empty;
            AnFabricatie = 0;
            NumarInmatriculare = string.Empty;
            StareTehnica = "Necunoscut";
            Culoare = Culoare.Rosu;
            OptiuniVehicule = new ArrayList();
        }






        // Constructor cu parametri
        public Vehicul(int id, string marca, string model, int anFabricatie, string numarInmatriculare, string stareTehnica, Culoare culoare, ArrayList optiuniVehicule)
        {
            ID = id;
            Marca = marca;
            Model = model;
            AnFabricatie = anFabricatie;
            NumarInmatriculare = numarInmatriculare;
            StareTehnica = stareTehnica;
            Culoare = culoare;
            OptiuniVehicule = optiuniVehicule;
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

            // Validare pentru Culoare
            this.Culoare = (Culoare)Enum.Parse(typeof(Culoare), dateFisier[CULOARE]);


            this.OptiuniVehicule = new ArrayList();
            this.OptiuniVehicule.AddRange(dateFisier[Optiuni_Vehicule].Split(Separator_secundar));

        }
        public string OptiuniVehiculeToString()
        {
            return string.Join(", ", OptiuniVehicule.ToArray());
        }

        public string Info()
        {
            return $"ID: {ID}\n Marca: {Marca}\n Model: {Model}\n An: {AnFabricatie}\n Nr. Inmatriculare: {NumarInmatriculare}\n Stare: {StareTehnica}\n Culoare: {Culoare}\n Optiuni Vehicule: {OptiuniVehiculeAsString}\n";
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectVehiculPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}",
                SEPARATOR_PRINCIPAL_FISIER,
                ID,
                Marca,
                Model,
                AnFabricatie,
                NumarInmatriculare,
                StareTehnica,
                Culoare,
                OptiuniVehiculeAsString);
            return obiectVehiculPentruFisier;
        }

        public string GetCuloareToString()
        {

            switch(Culoare)
            {
                case Culoare.Rosu:
                    return "Rosu";
                case Culoare.Alb:
                    return "Alb";
                case Culoare.Negru:
                    return "Negru";
                case Culoare.Albastru:
                    return "Albastru";
                case Culoare.Verde:
                    return "Verde";
                default:
                    return "Necunoscut";
            }
            
        }

        /*public static Vehicul CitireDelaTastatura()
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
            Console.Write("Introdu Culoare (Rosu, Alb, Negru, Albastru, Verde, Galben, Gri): ");
            Culoare culoare = (Culoare)Enum.Parse(typeof(Culoare), Console.ReadLine(), true);

            return new Vehicul(id, marca, model, anFabricatie, numarInmatriculare, stareTehnica, culoare,optiuniVehicule);
        }*/
    }
}
