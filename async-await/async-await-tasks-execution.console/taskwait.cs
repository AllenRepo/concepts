using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace async_await_tasks_execution.console
{
    public class taskwait
    {
        public void test()
        {
            Console.WriteLine($"{nameof(taskwait)} started");
            var task1 = method1();
            var task2 = method2();
            var task3 = method3();

            Task.WhenAll(task1, task2, task3)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            Console.WriteLine($"{nameof(taskwait)} ended");
        }

        public Task method1()
        {
            foreach (var i in new int[10])
            {
                Task.Delay(1000)
                    .Wait();
                Console.WriteLine("1000");
            }
            return Task.CompletedTask;
        }

        public Task method2()
        {
            foreach (var i in new int[10])
            {
                Task.Delay(500)
                    .Wait();
                Console.WriteLine("500");
            }
            return Task.CompletedTask;
        }

        public Task method3()
        {
            foreach (var i in new int[10])
            {
                Task.Delay(100)
                    .Wait();
                Console.WriteLine("100");
            }
            return Task.CompletedTask;
        }
    }
}
