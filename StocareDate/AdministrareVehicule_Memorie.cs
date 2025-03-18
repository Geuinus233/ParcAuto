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
        private const int NR_MAX_VEHICULE = 50;
        private Vehicul[] vehicule;
        private int nrVehicule;

        public AdministrareVehicule_Memorie()
        {
            vehicule = new Vehicul[NR_MAX_VEHICULE];
            nrVehicule = 0;
        }

        public void AdaugaVehicul(Vehicul vehicul)
        {
            
                vehicule[nrVehicule] = vehicul;
                nrVehicule++;
            
        }

        public Vehicul[] GetVehicule(out int nrVehicule)
        {
            nrVehicule = this.nrVehicule;
            return vehicule;
        }

        public Vehicul CautaDupaNumarInmatriculare(string numar)
        {
            for (int i = 0; i < nrVehicule; i++)
            {
                if (vehicule[i].NumarInmatriculare.Equals(numar, StringComparison.OrdinalIgnoreCase))
                {
                    return vehicule[i];
                }
            }
            return null;
        }
    }
}