using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcAuto
{
    public class Revizie
    {
        public int ID { get; set; }
        public int IDVehicul { get; set; }
        public DateTime DataRevizie { get; set; }
        public string Detalii { get; set; }

        public Revizie()
        {
            ID = 0;
            IDVehicul = 0;
            DataRevizie = DateTime.Now;
            Detalii = string.Empty;
        }

        public Revizie(int id, int idVehicul, DateTime dataRevizie, string detalii)
        {
            ID = id;
            IDVehicul = idVehicul;
            DataRevizie = dataRevizie;
            Detalii = detalii;
        }

        public string Info()
        {
            return $"ID: {ID}, Vehicul ID: {IDVehicul}, Data Revizie: {DataRevizie.ToShortDateString()}, Detalii: {Detalii}";
        }
    }
}