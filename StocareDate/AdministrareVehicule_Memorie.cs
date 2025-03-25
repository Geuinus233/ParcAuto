using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;
namespace StocareDate
{


    public class AdministrareVehicule_Memorie
    {
        private List<Vehicul> vehicule;

        public AdministrareVehicule_Memorie()
        {
            vehicule = new List<Vehicul>();
        }

        public void AdaugaVehicul(Vehicul vehicul)
        {
            vehicule.Add(vehicul);
        }

        public Vehicul[] GetVehicule(out int nrVehicule)
        {
            nrVehicule = vehicule.Count;
            return vehicule.ToArray();
        }

        public Vehicul CautaDupaNumarInmatriculare(string numarInmatriculare)
        {
            foreach (Vehicul vehicul in vehicule)
            {
                if (vehicul.NumarInmatriculare.Equals(numarInmatriculare, StringComparison.OrdinalIgnoreCase))
                {
                    return vehicul;
                }
            }
            return null;
        }
    }
}