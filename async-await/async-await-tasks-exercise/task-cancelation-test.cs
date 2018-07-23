using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace async_await_tasks_exercise
{
    [TestClass]
    public class task_cancelation_test
    {
        [TestMethod]
        public void should_cancel_and_throw_aggregate_exception()
        {
            //Arrange
            var tokenSource = new CancellationTokenSource();

            try
            {
                tokenSource.Cancel();
                Task.Delay(100000000, tokenSource.Token)
                    .Wait();
                Assert.Fail("should've thrown OperationCanceledException.");
            }
            catch (AggregateException ex)
            {
                Assert.AreEqual((ex.InnerException as TaskCanceledException).CancellationToken, tokenSource.Token);
            }
        }

        [TestMethod]
        public void startnew_should_cancel_and_throw_aggregate_exception()
        {
            //Arrange
            var tokenSource = new CancellationTokenSource();

            try
            {
                var task = Task.Factory.StartNew(async () => await Task.Delay(100000000, tokenSource.Token))
                    .Unwrap();
                tokenSource.Cancel();

                task.Wait();

                Assert.Fail("should've thrown OperationCanceledException.");
            }
            catch (AggregateException ex)
            {
                Assert.AreEqual((ex.InnerException as TaskCanceledException).CancellationToken, tokenSource.Token);
            }
        }

        [TestMethod]
        public async Task async_should_cancel_and_throw_operation_cancelled_exception()
        {
            //Arrange
            var tokenSource = new CancellationTokenSource();

            try
            {
                tokenSource.Cancel();
                await Task.Delay(100000000, tokenSource.Token);
                Assert.Fail("should've thrown OperationCanceledException.");
            }
            catch (OperationCanceledException ex)
            {
                Assert.AreEqual(ex.CancellationToken, tokenSource.Token);
            }
        }
    }
}
