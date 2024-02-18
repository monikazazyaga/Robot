using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RobotLibrary;

namespace RobotConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot1 = new Robot(0, 0, "Robot 1");
            Robot robot2 = new Robot(10, 100, "Robot 2");

            Thread thread1 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 5; i++) // пусть каждый робот сделает 5 шагов
                {
                    robot1.Move();
                    Console.WriteLine(robot1.GetInfo());
                    Thread.Sleep(1000); // задержка в 1 секунду между шагами
                }
            }));

            Thread thread2 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 5; i++) // пусть каждый робот сделает 5 шагов
                {
                    robot2.Move();
                    Console.WriteLine(robot2.GetInfo());
                    Thread.Sleep(1000); // задержка в 1 секунду между шагами
                }
            }));

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Работа потоков завершена.");

        }
    }
}
