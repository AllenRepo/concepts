using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace async_await_tasks_exercise
{
    [TestClass]
    public class test_exception_startnew_test
    {
        [TestMethod]
        public void should_capture_exception_in_aggregate_exception()
        {
            //Arrange
            var exResult = (Exception)null;
            var task = ExceptionTask();

            //Act
            try
            {
                task.Wait();
            }
            catch (AggregateException ex)
            {
                exResult = ex;
            }

            Assert.IsInstanceOfType(exResult.InnerException, typeof(NotImplementedException));
        }

        public Task ExceptionTask()
        {
            //Equivalent to Task.Run
            //Task.Factory.StartNew(someAction,
            //    CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
            return Task.Factory.StartNew(() =>
            {
                throw new NotImplementedException();
            });
        }
    }
}
