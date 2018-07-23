using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace async_await_tasks_exercise
{
    [TestClass]
    public class task_exception_async_test
    {
        [TestMethod]
        public async Task should_capture_exception_directly()
        {
            var exceptionResult = (Exception)null;
            try
            {
                await ExceptionTaskAsync();
            }
            catch (NotImplementedException ex)
            {
                exceptionResult = ex;
            }

            Assert.IsInstanceOfType(exceptionResult, typeof(NotImplementedException));
        }

        [TestMethod]
        public void should_capture_exception_in_aggregate_exception()
        {
            var exceptionResult = (Exception)null;
            var task = ExceptionTaskAsync();
            try
            {
                task.Wait();
            }
            catch (AggregateException ex)
            {
                exceptionResult = ex;
            }

            Assert.IsInstanceOfType(exceptionResult.InnerException, typeof(NotImplementedException));
        }

        public async Task ExceptionTaskAsync()
        {
            await Task.Delay(100);
            throw new NotImplementedException();
        }
    }
}
