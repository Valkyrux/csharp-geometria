using System;

namespace chsharp_geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la base del rettangolo");
            int inputBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci l'altezza del rettangolo");
            int inputAltezza = int.Parse(Console.ReadLine());
            Rettangolo primoRettangolo = new Rettangolo(inputBase, inputAltezza);
            Console.WriteLine("Il perimetro misura: {0}", primoRettangolo.calcolaPerimetro());
            Console.WriteLine("L'area misura: {0}", primoRettangolo.calcolaArea());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n--Rettangolo-{0}--", i);
                Rettangolo unRettangolo = new Rettangolo(new Random().Next(1, 20), new Random().Next(1, 20));
                unRettangolo.stampaRettangolo();
            }

            int baseDisegno = 5;
            int altezzaDisegno = 8;


            Rettangolo secondoRettangolo = new Rettangolo(baseDisegno, altezzaDisegno);
            Console.WriteLine("\nTriangolo disegnato base: {0}, altezza: {1}", baseDisegno, altezzaDisegno);
            secondoRettangolo.disegnaRettangolo();
        }
    }
}