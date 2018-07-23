using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace async_await_tasks_exercise
{
    [TestClass]
    public class test_exception_new_test
    {
        [TestMethod]
        public void should_capture_exception_in_aggregate_exception()
        {
            //Arrange
            var exThrownAtWait = (Exception)null;
            var task = ExceptionTask();

            //Act
            task.Start(); //exception not thrown here

            try
            {
                task.Wait();
            }
            catch (AggregateException ex)
            {
                exThrownAtWait = ex;
            }
            Assert.IsInstanceOfType(exThrownAtWait.InnerException, typeof(NotImplementedException));
        }

        public Task ExceptionTask()
        {
            return new Task(() =>
            {
                throw new NotImplementedException();
            });
        }
    }
}
