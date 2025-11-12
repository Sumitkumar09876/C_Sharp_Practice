using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Q2 Main Method
            List<Vehicle> Vehicles = new List<Vehicle>();
            Vehicles.Add(new Car(80, 4));
            for(int i = 0; i < Vehicles.Count; i++)
            {
                Vehicles[i].Go();
            }
            Car cr = new Car(80,40);
            cr.ShowFuelType();
            cr.Stop();
        }
    }
}
