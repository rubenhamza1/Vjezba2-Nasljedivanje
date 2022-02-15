using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba2
{
    class ProgramskiJezik
    {
        double postotak;

        public double Postotak { get => postotak; set => postotak = value; }
    }

    class Proceduralni : ProgramskiJezik
    {

    }

    class Objektni : ProgramskiJezik
    {

    }

    class Funkcionalni : ProgramskiJezik
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();

            Console.WriteLine("Unesi vrijednost postotka za x: ");
            int p = Convert.ToInt32(Console.ReadLine());
            x.Postotak = p;
            Console.WriteLine("Unesi vrijednost postotka za y: ");
            y.Postotak = p;
            Console.WriteLine("Unesi vrijednost postotka za z: ");
            z.Postotak = p;

            Console.ReadKey();

        }


    }
    
}
