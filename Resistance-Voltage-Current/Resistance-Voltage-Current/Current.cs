//Navid-Derakhshandeh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistance_Voltage_Current
{
    class Current
    {
        private double I;
        public Current()
        {
            Console.WriteLine("Please Enter the Voltage Number : ");
            double V = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Resistance Number : ");
            double R = Double.Parse(Console.ReadLine());

            I = V / R;

            Console.WriteLine("Current Equal by : {0}.", I);
        }
    }
}
