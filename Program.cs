using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transport;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------CargaisonRoutiere--------------------
            Cargaison C1 = new CargaisonRoutiere(80);
            C1.Add(new Marchandise(60, 70));
            C1.Add(new Marchandise(90, 50));
            C1.Add(new Marchandise(99, 60));
            C1.Afficher();
            Console.WriteLine("cout de la " + C1.ToString()+ " est " +C1.count());

            //-------------------CargaisonAereinne--------------------

            Cargaison A1 = new CargaisonAereinne(90);
            A1.Add(new Marchandise(60, 90));
            A1.Add(new Marchandise(90, 50));
            A1.Add(new Marchandise(99, 60));
            A1.Afficher();
            Console.WriteLine("cout de la " + A1.ToString() + " est " + A1.count());

            try
            {
                Marchandise m = C1.consulterMarchandise(9);
                Console.WriteLine(m);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           

            Console.ReadKey();
        }
    }
}
