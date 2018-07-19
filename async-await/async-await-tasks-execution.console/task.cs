using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace async_await_tasks_execution.console
{
    public class task
    {
        public void test()
        {
            Console.WriteLine($"{nameof(task)} started");
            var task1 = plain1();
            var task2 = plain2();
            var task3 = plain3();

            Task.WhenAll(task1, task2, task3)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            Console.WriteLine($"{nameof(task)} ended");
        }

        public Task plain1()
        {
            foreach (var i in new int[10])
            {
                Task.Delay(1000);
                Console.WriteLine("1000");
            }
            return Task.CompletedTask;
        }

        public Task plain2()
        {
            foreach (var i in new int[10])
            {
                Task.Delay(500);
                Console.WriteLine("500");
            }
            return Task.CompletedTask;
        }

        public Task plain3()
        {
            foreach (var i in new int[10])
            {
                Task.Delay(100);
                Console.WriteLine("100");
            }
            return Task.CompletedTask;
        }
    }
}
