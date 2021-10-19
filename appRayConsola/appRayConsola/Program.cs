using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appRayConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Papeleria a = new Papeleria();
            Papeleria[]arreglopape = new Papeleria[5];
            for (int i = 0; i < arreglopape.Length; i++)
            {
                arreglopape[i] = new Papeleria();
                Console.WriteLine("Ingresa el color del lustrina");
                arreglopape[i].ColordeLustrina = " ";
                a.ColordeLustrina = Console.ReadLine();
                Console.WriteLine("Ingresa el tipo y color de la pluma");
                arreglopape[i].Pluma = " ";
                a.Pluma = Console.ReadLine();
                Console.WriteLine("Ingresa tipo de cuaderno");
                arreglopape[i].Cuaderno = " ";
                a.Cuaderno = Console.ReadLine();
                
            }
            for (int i = 0; i < arreglopape.Length; i++)
            {
                Console.WriteLine(arreglopape[i].ToString());
            }
           
            Console.ReadKey();

        }
			

        
    }     
} 

