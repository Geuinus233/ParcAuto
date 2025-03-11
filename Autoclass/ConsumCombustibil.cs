using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConsumCombustibil
{
    public int ID { get; set; }
    public int IDVehicul { get; set; }
    public double CantitateLitri { get; set; }
    public DateTime DataAlimentare { get; set; }

    public ConsumCombustibil()
    {
        ID = 0;
        IDVehicul = 0;
        CantitateLitri = 0;
        DataAlimentare = DateTime.Now;
    }

    public ConsumCombustibil(int id, int idVehicul, double cantitateLitri, DateTime dataAlimentare)
    {
        ID = id;
        IDVehicul = idVehicul;
        CantitateLitri = cantitateLitri;
        DataAlimentare = dataAlimentare;
    }

    public string Info()
    {
        return $"ID: {ID}, Vehicul ID: {IDVehicul}, Cantitate: {CantitateLitri} L, Data Alimentare: {DataAlimentare.ToShortDateString()}";
    }
}