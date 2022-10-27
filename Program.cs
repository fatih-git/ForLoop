using System;

namespace ForLoop
{

    class Program
    {

        static void Main(string[] args)
        {
            
            for(int i=0; i<10; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            //Sonsuz döngü
            /*for(; ; )
            {
                Console.WriteLine("adsmfd");
            }*/

            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    continue;
                }

                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {

                if (i == 10)
                {
                    Console.Write("Breaking!");
                    break;
                }

                Console.Write(i + " ");
            }

        }

    }

}