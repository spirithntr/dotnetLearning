using System;

namespace balance
{
    class Program
    {
        static void Main(string[] args)
        {
            // array of debt records
            int [][] records = new int [][] {
                new int[] { 100, 200, 300, -500},
                new int[] { 200, -200},
                new int[] { 300, 400, -600}
            };
            int sum = 0;
            foreach (int[] person in records) {
                foreach (int debt in person) {
                    sum+=debt;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
