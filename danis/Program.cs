using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danis
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patrias Dannis P");
            Console.WriteLine("22.11.4961");
           
            
            
            // Membuat objek Taxi
            Taxi taxi = new Taxi();

            //set nilai properties
            taxi.DriverName = "Danis";
            taxi.OnDuty = true;
            taxi.NumPassanger = 10;
            //pemanggilan method 
            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPasanger();
            Console.ReadKey();
        }
    }
}
