using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task2
{
    public static class TasksExample
    {
        public static void Run(Videogame[] x)
        {
            var random = new Random();
            var tasks = new List<Task<Videogame>>();

            Console.WriteLine(x[1].Title);

            foreach (var y in x)
            {
                var task = Task.Run(() =>
                {
                    Console.WriteLine($"computing result for {y.Title}");
                    Task.Delay(TimeSpan.FromSeconds(5.0 + random.Next(10))).Wait();
                    Console.WriteLine($"done computing result for {y.Title}");
                    y.CurrentValue= y.CurrentValue * 2;
                    return y;
                });

                tasks.Add(task);
            }

            var tasks2 = new List<Task<Videogame>>();
            foreach (var task in tasks.ToArray())
            {
                tasks2.Add(
                    task.ContinueWith(t => { Console.WriteLine($"Das Spiel {t.Result.Title} ist {t.Result.CurrentValue} EUR wert."); return t.Result; })
                );

            }

            Console.WriteLine("doing something else ...");

            var cts = new CancellationTokenSource();
            var primeTask = PrintCollectionValue(cts.Token,x);

            Console.ReadLine();
            cts.Cancel();
            Console.WriteLine("canceled printing collection value");

            Console.ReadLine();
        }

        public static Task<decimal> CalculateCollectionValue(CancellationToken ct,Videogame[] x)
        {
            return Task.Run(() =>
            {
                decimal result = 0;
                foreach (var y in x)
                {
                    result = result + y.CurrentValue;
                    
                }
                return result; 
            }, ct);
        }

        public static async Task PrintCollectionValue(CancellationToken ct, Videogame[] x)
        {
            while(true)
            {
                ct.ThrowIfCancellationRequested();

                //Task<decimal> futureData = CalculateCollectionValue(ct,x);
                // futureData.ContinueWith(t => Console.WriteLine(t.Result));

              decimal data = await CalculateCollectionValue(ct,x);
              Console.WriteLine(data);
              Task.Delay(TimeSpan.FromSeconds(2)).Wait();
            }
        }

    }
}
