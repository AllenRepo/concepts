using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_await.console
{
    public class Program
    {
        static void Main(string[] args)
        {
            WaitAsync().Wait();
        }

        static async Task WaitAsync()
        {
            var counter = 0;
            while (counter < 5)
            {
                System.Diagnostics.Debug.WriteLine(++counter);
                await Task.Delay(1000);
            }
        }
    }
}
