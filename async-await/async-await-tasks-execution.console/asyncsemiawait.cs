using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace async_await_tasks_execution.console
{
    public class asyncsemiawait
    {
        public void test()
        {
            Console.WriteLine($"{nameof(asyncsemiawait)} started");
            var task1 = method1();
            var task2 = method2();
            var task3 = method3();

            Console.WriteLine("hello main");

            Task.WhenAny(task1, task2, task3)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            Console.WriteLine($"{nameof(asyncsemiawait)} ended");
        }

        public async Task method1()
        {
            Console.WriteLine("hello1");
            foreach (var i in new int[10])
            {
                await Task.Delay(1000);
                Console.WriteLine("1000");
            }
        }

        public async Task method2()
        {
            Console.WriteLine("hello2");
            foreach (var i in new int[10])
            {
                await Task.Delay(500);
                Console.WriteLine("500");
            }
        }

        public async Task method3()
        {
            Console.WriteLine("hello3");
            foreach (var i in new int[10])
            {
                await Task.Delay(100);
                Console.WriteLine("100");
            }
        }
    }
}
