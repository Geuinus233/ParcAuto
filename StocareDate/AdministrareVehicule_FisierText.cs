using LibrarieModele;
using System;
using System.IO;

namespace StocareDate
{
    public class AdministrareVehicule_FisierText
    {
        private const int NR_MAX_VEHICULE = 50;
        private string numeFisier;

        public AdministrareVehicule_FisierText(string numeFisier)
        {
            
            this.numeFisier = numeFisier;
            try
            {
                // se incearca deschiderea fisierului in modul OpenOrCreate
                // astfel incat sa fie creat daca nu exista
                using (Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate))
                {
                    // Fisierul a fost deschis cu succes
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Eroare la deschiderea fisierului: " + e.Message);
            }
        }

        public void AddVehicul(Vehicul vehicul)
        {
            try
            {
                // instructiunea 'using' va apela la final streamWriterFisierText.Close();
                // al doilea parametru setat la 'true' al constructorului StreamWriter indica
                // modul 'append' de deschidere al fisierului
                using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
                {
                    streamWriterFisierText.WriteLine(vehicul.ConversieLaSir_PentruFisier());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Eroare la scrierea in fisier: " + e.Message);
            }
        }

        public Vehicul[] GetVehicule(out int nrVehicule)
        {
            Vehicul[] vehicule = new Vehicul[NR_MAX_VEHICULE];
            nrVehicule = 0;

            try
            {
                // instructiunea 'using' va apela streamReader.Close()
                using (StreamReader streamReader = new StreamReader(numeFisier))
                {
                    string linieFisier;

                    // citeste cate o linie si creaza un obiect de tip Vehicul
                    // pe baza datelor din linia citita
                    while ((linieFisier = streamReader.ReadLine()) != null)
                    {
                        vehicule[nrVehicule++] = new Vehicul(linieFisier);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Eroare la citirea din fisier: " + e.Message);
            }

            return vehicule;
        }
    }
}
