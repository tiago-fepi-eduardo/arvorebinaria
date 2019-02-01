using System;

namespace ConsoleIrmaoIgual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#######");

            int[] param = { 1, 1, 1, 0, 1, 1, 1, 1 };
            int days = 1;

            Console.WriteLine("Entrada");
            Console.WriteLine(param[0] + " " + param[1] + " " + param[2] + " " + param[3] + " " + param[4] + " " + param[5] + " " + param[6] + " " + param[7]);

            int[] cells = cellCompete(param, days);

            Console.WriteLine("Resultado");
            Console.WriteLine(cells[0] + " " + cells[1] + " " + cells[2] + " " + cells[3] + " " + cells[4] + " " + cells[5] + " " + cells[6] + " " + cells[7]);

            Console.Read(); //Pause
        }

        public static int[] cellCompete(int[] states, int days)
        {
            for (int d = 0; d < days; d++)
            {
                int[] newStates = new int[8];
                int nextCell = 0;
                int beforeCell = 0;

                for (int i = 0; i < states.Length; i++)
                {
                    if (i == 0)
                        beforeCell = 0;
                    else
                        beforeCell = states[i - 1];

                    if (i == states.Length - 1)
                        nextCell = 0;
                    else
                        nextCell = states[i + 1];

                    if (beforeCell == nextCell)
                        newStates[i] = 0;
                    else
                        newStates[i] = 1;
                }
                states = newStates;
            }
            return states;
        }

    }
}
