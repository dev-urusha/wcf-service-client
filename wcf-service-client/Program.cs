using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcf_service_client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            double num1, num2, num3 = 0;

            Console.WriteLine($"Kindly enter the operation's name you want to perform: Add / Sub / Mul / Div");
            var requestedOperation = Console.ReadLine();

            Console.WriteLine($"Kindly enter the first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Kindly enter the second number: ");
            num2 = double.Parse(Console.ReadLine());

            switch (requestedOperation) 
            {
                case "Add":
                     num3 = client.Add(num1, num2);
                    break;
                case "Sub":
                    num3 = client.Sub(num1, num2);
                    break;
                case "Mul":
                    num3 = client.Mul(num1, num2);
                    break;
                case "Div":
                    num3 = client.Div(num1, num2);
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Result of the requested operation is {num3}");
            Console.ReadLine();

        }
    }
}
