namespace chsharp_geometria
{
    internal class Rettangolo
    {
        private int baseRettangolo;
        private int altezzaRettangolo;

        public Rettangolo(int inputB, int inputA)
        {
            this.baseRettangolo = inputB;
            this.altezzaRettangolo = inputA;
        }

        public int calcolaArea()
        {
            return this.baseRettangolo * this.altezzaRettangolo;
        }

        public int calcolaPerimetro()
        {
            return 2 * this.baseRettangolo + 2*this.altezzaRettangolo;
        }

        public void stampaRettangolo()
        {
            Console.WriteLine("base: {0}, altezza: {1}, area: {2}, perimetro: {3}", this.baseRettangolo, this.altezzaRettangolo, this.calcolaArea(), this.calcolaPerimetro());
        }

        public void disegnaRettangolo()
        {
            string baseDisegnata = "";
            string altezzaDisegnata = "";
            for (int i = 0; i < this.baseRettangolo; i++)
            {
                baseDisegnata += "-";
                if(i == 0 || i == this.baseRettangolo -1)
                {
                    altezzaDisegnata += "|";
                } else
                {
                    altezzaDisegnata += " ";
                }
            }

            for (int i = 0; i < this.altezzaRettangolo; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(baseDisegnata);
                    Console.WriteLine(altezzaDisegnata);
                }
                else if(i == this.altezzaRettangolo - 1)
                {
                    Console.WriteLine(altezzaDisegnata);
                    Console.WriteLine(baseDisegnata);
                }
                else
                {
                    Console.WriteLine(altezzaDisegnata);
                }
            }
        }
    }
}