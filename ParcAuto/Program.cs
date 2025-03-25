using StocareDate;
using System;
using System.Configuration;
using LibrarieModele;

namespace ParcAuto
{
    class Program
    {
        static void Main()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            if (string.IsNullOrEmpty(numeFisier))
            {
                Console.WriteLine("Eroare!!!");
                return;
            }
            AdministrareVehicule_Memorie administrare1Vehicule = new AdministrareVehicule_Memorie();
            AdministrareVehicule_FisierText administrareVehicule = new AdministrareVehicule_FisierText(numeFisier);

            Vehicul vehiculNou = new Vehicul();
            int nrVehicul = 0;

            string optiune;

            do
            {
                Console.WriteLine("C. Citire informatii vehicul de la tastatura");
                Console.WriteLine("I. Afisarea informatiilor despre ultimul vehicul introdus");
                Console.WriteLine("A. Afisare vehicule din fisier");
                Console.WriteLine("S. Salvare vehicul in fisier");
                Console.WriteLine("H. Salvare vehicul in memorie");
                Console.WriteLine("L. Afisare vehicul din memorie");
                Console.WriteLine("F. Cautare vehicul dupa numar de inmatriculare");
                Console.WriteLine("X. Inchidere program");

                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "C":
                        vehiculNou = Vehicul.CitireDelaTastatura();
                        break;
                    case "I":
                        AfisareVehicul(vehiculNou);
                        break;
                    case "A":
                        Vehicul[] vehiculs = administrareVehicule.GetVehicule(out nrVehicul);
                        AfisareVehicule(vehiculs, nrVehicul);
                        break;
                    case "S":
                        int idVehicul = ++nrVehicul;
                        vehiculNou.ID = idVehicul;
                        administrareVehicule.AddVehicul(vehiculNou);
                        Console.WriteLine("Vehiculul a fost adaugat cu succes!!!");
                        break;
                    case "H":
                        administrare1Vehicule.AdaugaVehicul(vehiculNou);
                        Console.WriteLine("Vehiculul a fost adaugat in memorie cu succes!!!");
                        break;
                    case "L":
                        Vehicul[] vehiculeMemorie = administrare1Vehicule.GetVehicule(out nrVehicul);
                        AfisareVehicule(vehiculeMemorie, nrVehicul);
                        break;
                    case "F":
                        Console.Write("Introduceti numarul de inmatriculare pentru cautare: ");
                        string numarCautat = Console.ReadLine();
                        Vehicul vehiculGasit = administrare1Vehicule.CautaDupaNumarInmatriculare(numarCautat);
                        if (vehiculGasit != null)
                        {
                            Console.WriteLine("Vehicul gasit: " + vehiculGasit.Info());
                        }
                        else
                        {
                            Console.WriteLine("Vehiculul nu a fost gasit.");
                        }
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune nedefinita");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        public static void AfisareVehicul(Vehicul vehicul)
        {
            string infoVehicul = string.Format("ID: {0}, Marca: {1}, Model: {2}, An: {3}, Nr. Inmatriculare: {4}, Stare: {5}, Culoare: {6}",
                vehicul.ID, vehicul.Marca, vehicul.Model, vehicul.AnFabricatie, vehicul.NumarInmatriculare, vehicul.StareTehnica, vehicul.Culoare);
            Console.WriteLine(infoVehicul);
        }

        public static void AfisareVehicule(Vehicul[] vehicule, int nrVehicule)
        {
            Console.WriteLine("Vehicule sunt: ");
            for (int i = 0; i < nrVehicule; i++)
            {
                string infoVehicul = vehicule[i].Info();
                Console.WriteLine(infoVehicul);
            }
        }
    }
}
