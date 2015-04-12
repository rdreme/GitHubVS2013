using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pulse para empezar.");
            Console.ReadKey();
            ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();
            for (int i=0;i<100;i++)
            {
                Console.WriteLine("Llamada a servicio: " + i.ToString() + " : " + DateTime.Now.ToString());
                cliente.GetData(i);
                Console.WriteLine("Llegada del servicio: " + i.ToString() + " : " + DateTime.Now.ToString());
            }
            Console.WriteLine("Pulse para finalizar.");
            Console.ReadKey();

        }
    }
}
