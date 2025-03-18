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
            /*Console.WriteLine("INtroduceti datele pentru un vehicul: ");
            Vehicul vehicul = Vehicul.CitireDelaTastatura();
            Console.WriteLine("Vehicul introdus: ");
            Console.WriteLine(vehicul.Info());

            Console.WriteLine();
            Console.WriteLine("Introuduceti datele pentru un utilizator: ");
            Utilizator utilizator = Utilizator.CitireDeLaTastatura();

            Console.WriteLine("Utilizatorul introdus: ");
            Console.WriteLine(utilizator.Info());*/
            //AdministrareVehicule_Memorie administrare = new AdministrareVehicule_Memorie();

            //administrare.AdaugaVehicul(new Vehicul(1, "Dacia", "Logan", 2015, "B123ABC", "Buna"));
            //administrare.AdaugaVehicul(new Vehicul(2, "Volkswagen", "Golf", 2018, "CJ07XYZ", "Foarte Buna"));
            //administrare.AdaugaVehicul(new Vehicul(3, "Ford", "Focus", 2020, "AB99DEF", "Excelenta"));

            /*Console.WriteLine("Toate vehiculele:");
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
            }*/
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            if (string.IsNullOrEmpty(numeFisier))
            {
                Console.WriteLine("NumeFisier не задан в файле конфигурации.");
                return;
            }

            AdministrareVehicule_FisierText administrareVehicule = new AdministrareVehicule_FisierText(numeFisier);

            Vehicul vehiculNou = new Vehicul();
            int nrVehicul = 0;

            string optiune;

            do
            {
                Console.WriteLine("C. Citire informatii vehicul de la tastatura");
                Console.WriteLine("I. Afisarea informatiilor despre ultimul vehicul introdus");
                Console.WriteLine("A. Afisare vehicule din fisier");
                Console.WriteLine("F. Salvare vehicul in fisier");
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
                    case "F":
                        int idVehicul = ++nrVehicul;
                        vehiculNou.ID = idVehicul;
                        administrareVehicule.AddVehicul(vehiculNou);
                        Console.WriteLine("Vehiculul a fost adaugat cu succes!!!");
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
            string infoVehicul = string.Format("Vehicul {1} {2} cu id-ul {0} ,Anul de fabricatie {3}, Numarul de inmatriculare: {4}, Starea: {5} ",
                vehicul.ID, vehicul.Marca, vehicul.Model, vehicul.AnFabricatie, vehicul.NumarInmatriculare, vehicul.StareTehnica);
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
