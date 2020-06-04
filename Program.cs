using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivbyZero
{
    class Program
    {
        static double Div(int a,int b)
        {
            return Convert.ToDouble(a) / Convert.ToDouble(b);
        }
        static void Main(string[] args)
        {
            int a;
            int b;
            // int.TryParse(Console.ReadLine(), out a);
            // int.TryParse(Console.ReadLine(), out b);
            
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                double c = Div(a,b);
                Console.WriteLine("{0:f1}",c);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
