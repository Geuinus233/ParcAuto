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
                using (StreamReader streamReader = new StreamReader(numeFisier))
                {
                    string linieFisier;
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
            Array.Resize(ref vehicule, nrVehicule);
            return vehicule;
        }

        public Vehicul CautaVehiculDupaNumarInmatriculare(string numarInmatriculare)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(numeFisier))
                {
                    string linieFisier;
                    while ((linieFisier = streamReader.ReadLine()) != null)
                    {
                        Vehicul vehicul = new Vehicul(linieFisier);
                        if (vehicul.NumarInmatriculare.Equals(numarInmatriculare, StringComparison.OrdinalIgnoreCase))
                        {
                            return vehicul;
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Eroare la citirea din fisier: " + e.Message);
            }
            return null;
        }
    }
}
