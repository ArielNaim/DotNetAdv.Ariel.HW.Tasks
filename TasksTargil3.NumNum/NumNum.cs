using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksTargil3.NumNum
{
    class NumNum
    {
         // Targil 3  Thread
        public int SleepTime { get; set; }
        public Thread thread;
        public NumNum(string threadSleep)
        {
            thread = new Thread(() => Sleep());
            SleepTime = new Random().Next(5000);
            thread.Name = threadSleep;
            double secend = SleepTime;
            Console.WriteLine($"Thread {thread.Name}  Sleep time is {secend / 1000} secends");
        }

        public void Sleep()
        {
            Console.WriteLine(thread.Name + " is going to sleep");
            Thread.Sleep(SleepTime);
            Console.WriteLine(thread.Name + " doun sleeping");
        }
    }
    public class NumNumTask
    {
        public int SleepTime { get; set; }
        public Task task;
        public NumNumTask(string taskSleep)
        {
            task = new Task(() => Sleep());
            SleepTime = new Random().Next(5000);
            double secend = SleepTime;
            Console.WriteLine($"Task {task.Id} Sleep time is {secend / 1000} secends");
        }
        public void Sleep()
        {
            Console.WriteLine(task.Id + " is going to sleep");
            Task.Delay(SleepTime);
            Console.WriteLine(task.Id + " doun sleeping");
        }
    }
}
