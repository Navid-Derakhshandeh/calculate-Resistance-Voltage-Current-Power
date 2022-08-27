//Navid-Derakhshandeh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistance_Voltage_Current
{
    class Power
    {
        private double P;
        public Power()
        {
            Console.WriteLine("Please Enter the Voltage Number : ");
            double V = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Current Number : ");
            double I = Double.Parse(Console.ReadLine());

            P = V * I;

            Console.WriteLine("Power Equal by : {0}.", P);
        }
    }
}
