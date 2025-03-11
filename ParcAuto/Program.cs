using StocareDate;
using System;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;
using StocareDate;
using LibrarieModele;
namespace ParcAuto
{

    class Program
    {
        static void Main()
        {
         
            /*Console.WriteLine("INtroduceti datele pentru un vehicul: ");
            Vehicul vehicul = Vehicul.CitireDelaTastatura();
            Console.WriteLine("Vehicul introdus: ");
            Console.WriteLine(vehicul.Info());

            Console.WriteLine();
            Console.WriteLine("Introuduceti datele pentru un utilizator: ");
            Utilizator utilizator = Utilizator.CitireDeLaTastatura();
            Console.WriteLine("Utilizatorul introdus: ");
            Console.WriteLine(utilizator.Info());*/
            
            AdministrareVehicule_Memorie administrare = new AdministrareVehicule_Memorie();

            administrare.AdaugaVehicul(new Vehicul(1, "Dacia", "Logan", 2015, "B123ABC", "Buna"));
            administrare.AdaugaVehicul(new Vehicul(2, "Volkswagen", "Golf", 2018, "CJ07XYZ", "Foarte Buna"));
            administrare.AdaugaVehicul(new Vehicul(3, "Ford", "Focus", 2020, "AB99DEF", "Excelenta"));

            Console.WriteLine("Toate vehiculele:");
            int nrVehicule;
            Vehicul[] listaVehicule = administrare.GetVehicule(out nrVehicule);
            for (int i = 0; i < nrVehicule; i++)
            {
                Console.WriteLine(listaVehicule[i].Info());
            }

            Console.Write("Introduceti numarul de inmatriculare pentru cautare: ");
            string numarCautat = Console.ReadLine();
            Vehicul vehiculGasit = administrare.CautaDupaNumarInmatriculare(numarCautat);

            if (vehiculGasit != null)
            {
                Console.WriteLine("Vehicul gasit: " + vehiculGasit.Info());
            }
            else
            {
                Console.WriteLine("Vehiculul nu a fost gasit.");
            }
        }
        
        

    }





}