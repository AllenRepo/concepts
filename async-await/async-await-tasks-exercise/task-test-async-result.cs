using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace async_await_tasks_exercise
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var result = TestAsync().Result;
            var result2 = await TestAsync();
        }

        public async Task<int> TestAsync()
        {
            await Task.Delay(1000);
            return await Task.Run<int>(() => 100);
        }
    }
}
