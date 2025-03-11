
using System;
using System.Collections.Generic;
using System.Linq;


namespace LibrarieModele
{
    
    public class Vehicul
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }
        public string NumarInmatriculare { get; set; }
        public string StareTehnica { get; set; }

        public Vehicul()
        {
            ID = 0;
            Marca = string.Empty;
            Model = string.Empty;
            AnFabricatie = 0;
            NumarInmatriculare = string.Empty;
            StareTehnica = "Necunoscut";
        }

        public Vehicul(int id, string marca, string model, int anFabricatie, string numarInmatriculare, string stareTehnica)
        {
            ID = id;
            Marca = marca;
            Model = model;
            AnFabricatie = anFabricatie;
            NumarInmatriculare = numarInmatriculare;
            StareTehnica = stareTehnica;
        }

        


        public string Info()
        {
            return $"ID: {ID}, Marca: {Marca}, Model: {Model}, An: {AnFabricatie}, Nr. Inmatriculare: {NumarInmatriculare}, Stare: {StareTehnica}";
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


