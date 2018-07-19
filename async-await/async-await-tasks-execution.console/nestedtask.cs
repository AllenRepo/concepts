using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace async_await_tasks_execution.console
{
    public class nestedtask
    {

        public void test()
        {
            Console.WriteLine($"{nameof(nestedtask)} started");
            var task1 = method1();

            Task.WhenAny(task1)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            Console.WriteLine($"{nameof(nestedtask)} ended");
        }

        public Task method1()
        {
            foreach (var i in new int[10])
            {
                Task.Delay(1000);
                Console.WriteLine("1000");
            }
            return method2();
        }

        public Task method2()
        {
            foreach (var i in new int[10])
            {
                Task.Delay(500);
                Console.WriteLine("500");
            }
            return method3();
        }

        public Task method3()
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
