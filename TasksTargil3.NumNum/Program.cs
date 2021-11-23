using System;
using System.Collections.Generic;

namespace TasksTargil3.NumNum
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Targil 3 NumNum 

            var numlist = new List<NumNum>();
            for (int i = 1; i <= 4; i++)
            {
                var numnum = new NumNum($"NumNum{i}");
                numlist.Add(numnum);
            }
            Console.WriteLine("Start Threadind");
            foreach (var item in numlist)
            {
                item.thread.Start();
                item.thread.Join();
            }
            Console.WriteLine("Threads Starded");

            var numTasklist = new List<NumNumTask>();
            for (int i = 1; i <= 4; i++)
            {
                var numTask = new NumNumTask($"NumTask{i}");
                numTasklist.Add(numTask);
            }
            Console.WriteLine("Start Tasking");
            foreach (var item in numTasklist)
            {
                item.task.RunSynchronously();
            }
            Console.WriteLine("Tasks Starded");

            #endregion
        }
    }
}
