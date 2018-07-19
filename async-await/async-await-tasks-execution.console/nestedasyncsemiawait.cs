using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace async_await_tasks_execution.console
{

    public class nestedasyncsemiawait
    {

        public void test()
        {
            Console.WriteLine($"{nameof(nestedasyncsemiawait)} started");
            var task1 = method1();

            Task.WhenAny(task1)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            Console.WriteLine($"{nameof(nestedasyncsemiawait)} ended");
        }

        public async Task method1()
        {
            method2();
            foreach (var i in new int[10])
            {
                await Task.Delay(1000);
                Console.WriteLine("1000");
            }
        }

        public async Task method2()
        {
            await method3();
            foreach (var i in new int[10])
            {
                await Task.Delay(500);
                Console.WriteLine("500");
            }
        }

        public async Task method3()
        {
            foreach (var i in new int[10])
            {
                await Task.Delay(100);
                Console.WriteLine("100");
            }
        }
    }
}
