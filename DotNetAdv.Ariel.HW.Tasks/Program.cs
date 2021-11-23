using System;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace DotNetAdv.Ariel.HW.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Targil 1
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 5000; i++)
                {
                    Console.WriteLine(i);
                }
            });
            thread.Start();

            Task task = new Task(() =>
            {
                for (int i = 0; i < 5000; i++)
                {
                    Console.WriteLine(i);
                }
            });
            task.Start();

            #endregion

            #region Targil 2 - Wright File Name Thread

            Thread firstFileName = new Thread(() =>
            {
                DirectoryInfo directoryInfo1 = new DirectoryInfo(@"C:\Users\ariel\OneDrive\תמונות\אבובים בחצבני");
                var Files = directoryInfo1.GetFiles().Select(file => file.Name).Take(10);
                foreach (var file in Files)
                {
                    Console.WriteLine(file);
                }
            });
            Thread secoundFileName = new Thread(() =>
            {
                DirectoryInfo directoryInfo2 = new DirectoryInfo(@"C:\Users\ariel\OneDrive\DotNet.Ariel.Hw\תרגיל בית - מתקדם");
                var Files = directoryInfo2.GetFiles().Select(file => file.Name).Take(10);
                foreach (var file in Files)
                {
                    Console.WriteLine(file);
                }
            });
            firstFileName.Start();
            secoundFileName.Start();
            #endregion

            #region Targil 2 Task
            Task task1 = new Task(() =>
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\ariel\OneDrive\תמונות\אבובים בחצבני");
                var Filse = directoryInfo.GetFiles().Select(file => file.Name).Take(10);
                foreach (var file in Filse)
                {
                    Console.WriteLine(file);
                }
            });
            Task task2 = new Task(() =>
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\ariel\OneDrive\DotNet.Ariel.Hw\תרגיל בית - מתקדם");
                var Filse = directoryInfo.GetFiles().Select(file => file.Name).Take(10);
                foreach (var file in Filse)
                {
                    Console.WriteLine(file);
                }
            });
            task2.Start();
            task1.Start();
            #endregion


        }
    }
}
