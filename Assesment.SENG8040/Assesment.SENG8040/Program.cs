using System;
using static System.Net.Mime.MediaTypeNames;

namespace Assesment.SENG8040
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                bool output = false;
                int result = 0;
                int sideA, sideB, sideC = 0;
                do
                {
                    Console.WriteLine("Please enter the options (1 or 2) to continue/exit\n");

                    Console.WriteLine("1.Enter triangle dimensions.");
                    Console.WriteLine("2.Exit.");

                    output = int.TryParse(Console.ReadLine(), out result);
                }
                while (!output);


                if (output && result == 1)
                {
                    bool sideACheck, sideBCheck, sideCCheck = false;
                    bool sidesCheckPass = false;
                    do
                    {
                        Console.Write("Please input side A of triangle: ");
                        sideACheck = int.TryParse(Console.ReadLine(), out sideA);

                        Console.Write("Please input side B of triangle: ");
                        sideBCheck = int.TryParse(Console.ReadLine(), out sideB);

                        Console.Write("Please input side C of triangle: ");
                        sideCCheck = int.TryParse(Console.ReadLine(), out sideC);

                        sidesCheckPass = (sideACheck && sideBCheck && sideCCheck);
                    }
                    while (!sidesCheckPass);

                    if (sidesCheckPass)
                    {
                        string message = TriangleSolver.Analyze(sideA, sideB, sideC);
                        Console.WriteLine(message);
                    }

                }
                else
                {
                    Environment.Exit(0);
                }
                Console.WriteLine("Do You want to continue the same, press Y/N\n");
            }
            while (Console.ReadLine().ToUpper() == "Y");
        }
    }
}
