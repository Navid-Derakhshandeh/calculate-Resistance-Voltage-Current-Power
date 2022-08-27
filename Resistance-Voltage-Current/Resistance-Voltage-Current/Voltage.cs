//Navid-Derakhshandeh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Resistance_Voltage_Current
{
    class Voltage
    {
        private double V;
        public Voltage()
        {
            Console.WriteLine("Please Enter the Current Number : ");
            double I = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Resistance Number : ");
            double R = Double.Parse(Console.ReadLine());

            V = I * R;

            Console.WriteLine("Voltage Equal by : {0}.", V);
        }
    }
}
