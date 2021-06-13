using System;

namespace ข้อ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] allnum = new int[3, 3]; int r0 = 0, c0 = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    allnum[i, j] = int.Parse(Console.ReadLine());
                    if (allnum[i, j] == 0) { c0 = j; r0 = i; }
                }
            }
            int num = int.Parse(Console.ReadLine());
            bool a = true;

            for (int t = 0; t < 3; t++)
            {
                if (num == allnum[t, c0] || num == allnum[r0, t]) { Console.WriteLine("The number is available"); a = false; }
            }
            if (a == true)
            {

                allnum[r0, c0] = num;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(allnum[i, j]);
                        Console.Write(" ");

                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
