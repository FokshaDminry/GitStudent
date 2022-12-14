using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadI
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreardInterface Ithread = new ThreardInterface();
            Ithread.Add(PrintZ);
            Ithread.Add(PrintX);
            Ithread.Add(PrintC);
            Ithread.Add(PrintV);
            Console.WriteLine($"Количество добавленных потоков: {Ithread.Amount} ");
            Ithread.Start(3);
            Thread.Sleep(1000);
            Ithread.Stop();
            void PrintZ()
            {

                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(300);
                    Console.WriteLine('Z');
                }

            }
            void PrintX()
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(300);
                    Console.WriteLine('X');
                }
            }
            void PrintC()
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(300);
                    Console.WriteLine('C');
                }
            }
            void PrintV()
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(300);
                    Console.WriteLine('V');
                }
            }
        }
    }

    class ThreardInterface 
    {
        public CancellationTokenSource cts;
        public int Amount;
        public List<Action> actions;
        public ThreardInterface()
        {
            cts = new CancellationTokenSource();
            Amount = 0;
            actions = new List<Action>();
        }
        public void Start(int maxConcurrent)
        {
            Task[] t = new Task[actions.Count];
            if (actions.Count >= maxConcurrent)
            {
                int tmp = 1;
                for (int i = 0; i < actions.Count; i++)
                {
                    t[i] = new Task(actions[i].Invoke, cts.Token);
                }
                for (int i = 0; i < actions.Count; i++)
                {
                    if (tmp <= maxConcurrent)
                    {
                        t[i].Start();
                        tmp++;
                    }
                    else
                    {
                        i--;
                        Task.WaitAny(t);
                        tmp--;
                    }
                } 
            }
        }
        public void Add(Action action)
        {
            actions.Add(action);
            Amount++;
        }
        public void Stop()
        {
            cts.Cancel();
            Console.WriteLine("Stop");
        }
        public void Clear()
        {
            actions.Clear();
            Amount = 0;
        }
    }
}
