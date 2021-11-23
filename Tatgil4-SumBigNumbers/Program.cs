using System;

namespace Tatgil4_SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SumBigNumbers sumBigNumbers = new SumBigNumbers(1150000);
            SumBigNumbers sumBigNumbersTask = new SumBigNumbers(1150000, 0);
            Console.WriteLine(sumBigNumbers.Sum);
            Console.WriteLine(sumBigNumbersTask.SumTask);
            long sumTest = 0;
            for (int i = 0; i <= 1150000; i++)
            {
                sumTest = sumTest + i;
            }
            Console.WriteLine(sumTest);
        }
    }
}
