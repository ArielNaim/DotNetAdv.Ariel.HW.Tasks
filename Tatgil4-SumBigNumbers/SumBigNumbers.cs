using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tatgil4_SumBigNumbers
{
    public class SumBigNumbers
    {
        public long Sum { get; set; }
        public long SumTask { get; set; }
       private object lockObject = new object();

        public SumBigNumbers(long num)
        {

            for (int i = 0; i < num / 200000; i++)
            {
                    new Thread(() => SumNumbers(i * 200000, (i + 1) * 200000)).Start();
            }
            new Thread(() => SumNumbers((num % 200000), num)).Start();

        }
        private void SumNumbers(long minNum, long maxNum)
        {
            for (long i = minNum; i <= maxNum; i++)
            {
                lock (lockObject)
                {
                    AddToSum(i);
                }
            }
           
        }
        private void AddToSum(long num)
        {
                Sum = Sum + num;
        }
        public SumBigNumbers(long num, int zero)//add the int so i will have two of the same - its not nedd
        {
            for (long i = 0; i < num / 200000; i++)
            {
                Task.Run(() => SumNumbersTasks(i * 200000, (i + 1) * 200000));
            }
            Task.Run(() => SumNumbersTasks((num % 200000), num));
        }
        private void SumNumbersTasks(long minNum, long maxNum)
        {
            for (long i = minNum; i <= maxNum; i++)
            {
                AddToSumTask(i);
            }
        }
        private void AddToSumTask(long num)
        {
            lock (lockObject)
            {
                SumTask = SumTask + num;
            }
        }
    }
}
