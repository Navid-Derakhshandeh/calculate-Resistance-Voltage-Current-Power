//Navid-Derakhshandeh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Resistance_Voltage_Current
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo conkey;
            do
            {


                try
                {


                    Console.WriteLine("              ##########################             ");
                    Console.WriteLine("                ######################             ");
                    Console.WriteLine("                    ##############                 ");
                    Console.WriteLine("                      V = I * R                                     ");
                    Console.WriteLine("                      R = V / I                                     ");
                    Console.WriteLine("                      I = V / R                                     ");
                    Console.WriteLine("                      P = V * I                                     ");
                    Console.WriteLine("                    ##############                 ");
                    Console.WriteLine("                ######################             ");
                    Console.WriteLine("              ##########################             ");
                    Console.WriteLine("Please choose your Formula : ");
                    Console.WriteLine("1.Resistance : ");
                    Console.WriteLine("2.Volatge : ");
                    Console.WriteLine("3.Current : ");
                    Console.WriteLine("4.Power : ");

                    int c = Int32.Parse(Console.ReadLine());

                    do
                    {
                        switch (c)
                        {
                            case 1:
                                Resistance obj1 = new Resistance();
                                break;
                            case 2:
                                Voltage obj2 = new Voltage();
                                break;
                            case 3:
                                Current obj3 = new Current();
                                break;
                            case 4:
                                Power obj4 = new Power();
                                break;
                            default:
                                Console.WriteLine("End");
                                break;
                        }
                    }
                    while
                    ((c != 1) && (c != 2) && (c != 3) && (c != 4));




                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                finally
                {
                    Console.WriteLine("Enter Any Key That You Want, For Run Program Again.");
                }
                conkey = Console.ReadKey();
            } while (conkey.Key != ConsoleKey.Escape);
            
        }
    }
}
