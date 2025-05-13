using LibrarieModele;
using System;
using System.Collections.Generic;
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
        public Vehicul GetCar(int ID)
        {
            // Folosește 'using' pentru a închide automat StreamReader
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // Citește fiecare linie din fișier
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    // Creează un obiect de tip Comanda pe baza liniei citite
                    Vehicul vehicul = new Vehicul(linieFisier);

                    // Verifică dacă ID-ul comenzii corespunde
                    if (vehicul.ID == ID)
                        return vehicul;
                }
            }

            // Returnează null dacă nu a fost găsită nicio comandă cu ID-ul specificat
            return null;
        }
       
 public bool UpdateVehicul(Vehicul vehiculActualizat)
        {
            Vehicul[] vehicule = GetVehicule(out int nrVehicule);
            bool actualizare = false;

            using (StreamWriter streamWriter = new StreamWriter(numeFisier, false))
            {
                for (int i = 0; i < nrVehicule; i++)
                {
                    Vehicul vehiculScriereInFis = vehicule[i];
                    if (vehiculScriereInFis.ID == vehiculActualizat.ID)
                    {
                        vehiculScriereInFis = vehiculActualizat;
                        actualizare = true;
                    }
                    streamWriter.WriteLine(vehiculScriereInFis.ConversieLaSir_PentruFisier());
                }
            }
            return actualizare;
        }
        
        
        public Vehicul GetVehiculByIndex(int index)
        {
            try
            {
                using(StreamReader sr= new StreamReader(numeFisier))
                {
                    string linieFisier;
                  
                    while ((linieFisier = sr.ReadLine()) != null)
                    {
                        Vehicul vehicul= new Vehicul(linieFisier);
                        if (vehicul.ID == index)
                        {
                            return vehicul;
                        }
                    }
                }
            }
            catch(Exception)
            {

            }
            return null;
        }
    }
}
