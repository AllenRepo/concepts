using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace async_await.net.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpGet]
        public void SynchronousBlockDeadlock()
        {
            //This is bad!, Deadlock!
            this.SynchronousBlockDeadlockAsync().Wait();
        }

        public async Task SynchronousBlockDeadlockAsync()
        {
            var counter = 0;
            while (counter < 5)
            {
                System.Diagnostics.Debug.WriteLine(++counter);
                await Task.Delay(1000);
            }
        }

        [HttpGet]
        public void WaitTaskNonBlock()
        {
            try
            {
                //When to use Task vs async await (this requires good understanding of how it works, when in doubt use async/await with configureawait(false)
                //Only pass throughts should be Tasks for the reason of excpetions
                //When to not use async/await http://blog.stephencleary.com/2016/12/eliding-async-await.html

                //Guide : https://msdn.microsoft.com/library/hh191443(vs.110).aspx
                //Guide : https://msdn.microsoft.com/en-us/magazine/jj991977.aspx
                //State Machine : https://www.red-gate.com/simple-talk/dotnet/net-framework/the-overhead-of-asyncawait-in-net-4-5/

                //Swallowed Exception : http://forloop.co.uk/blog/beware-mixing-tasks-with-async/await#sthash.isqZqxQP.MPjOuAfp.dpbs

                //Async Aawait vs Task.ContinueWith
                //Source : Stephen Cleary https://stackoverflow.com/questions/8767218/is-async-await-keyword-equivalent-to-a-continuewith-lambda
                //The await keyword also makes use of a "scheduling context" concept. The scheduling context is SynchronizationContext.Current if it exists, falling back on TaskScheduler.Current. The continuation is then run on the scheduling context. So a closer approximation would be to pass TaskScheduler.FromCurrentSynchronizationContext into ContinueWith, falling back on TaskScheduler.Current if necessary.
                //The actual async / await implementation is based on pattern matching; it uses an "awaitable" pattern that allows other things besides tasks to be awaited. Some examples are the WinRT asynchronous APIs, some special methods such as Yield, Rx observables, and special socket awaitables that don't hit the GC as hard. Tasks are powerful, but they're not the only awaitables.
                //One more minor nitpicky difference comes to mind: if the awaitable is already completed, then the async method does not actually return at that point; it continues synchronously.So it's kind of like passing TaskContinuationOptions.ExecuteSynchronously, but without the stack-related problems.
                //Source : Jon Skeet https://stackoverflow.com/questions/18965200/difference-between-await-and-continuewith
                //They're very similar in that they both schedule a continuation, but as soon as the control flow gets even slightly complex, await leads to much simpler code. Additionally, as noted by Servy in comments, awaiting a task will "unwrap" aggregate exceptions which usually leads to simpler error handling. Also using await will implicitly schedule the continuation in the calling context (unless you use ConfigureAwait). It's nothing that can't be done "manually", but it's a lot easier doing it with await.
                //I suggest you try implementing a slightly larger sequence of operations with both await and Task.ContinueWith - it can be a real eye - opener.
                this.WaitTaskNonBlockAsync()
                    .ContinueWith(t => System.Diagnostics.Debug.WriteLine(t.Result + "done!"));
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Task<int> WaitTaskNonBlockAsync()
        {
            int counter = 0;
            while (counter < 5)
            {
                System.Diagnostics.Debug.WriteLine(++counter);
                Task.Delay(1000);
            }
            return Task.FromResult(counter);
        }

        [HttpGet]
        public async Task AsyncAllTheWay()
        {
            //better, but should add .ConfigureAwait(false)
            await this.AsyncAllTheWayAsync();
        }

        public async Task AsyncAllTheWayAsync()
        {
            var counter = 0;
            while (counter < 5)
            {
                System.Diagnostics.Debug.WriteLine(++counter);
                await Task.Delay(1000);
            }
        }

        [HttpGet]
        public void SynchronousBlockAwaitFalse()
        {
            //fair, but should be async all the way
            this.SynchronousBlockAwaitFalseAsync().Wait();
        }

        public async Task SynchronousBlockAwaitFalseAsync()
        {
            var counter = 0;
            while (counter < 5)
            {
                System.Diagnostics.Debug.WriteLine(++counter);
                await Task.Delay(1000)
                    .ConfigureAwait(false);
            }
        }

        [HttpGet]
        public void WaitAsyncNonBlockDeadlock()
        {
            //dead lock happens similary to SynchronousBlockDeadlock
            this.WaitAsyncNonBlockDeadlockAsync();
        }

        public async Task WaitAsyncNonBlockDeadlockAsync()
        {
            var counter = 0;
            while (counter < 5)
            {
                System.Diagnostics.Debug.WriteLine(++counter);
                //happens here when it tries to return to main thread, it may be sucessful a couple times because it utilize same thread, but once the thread switches, it then fails
                await Task.Delay(1000);
            }
        }

        [HttpGet]
        public void WaitAsyncNonBlockWaitFalse()
        {
            //better
            this.WaitAsyncNonBlockWaitFalseAsync();
        }

        public async Task WaitAsyncNonBlockWaitFalseAsync()
        {
            var counter = 0;
            while (counter < 5)
            {
                System.Diagnostics.Debug.WriteLine(++counter);
                await Task.Delay(1000)
                    .ConfigureAwait(false);
            }
        }
        
        [HttpGet]
        public void Manual()
        {
            var caller = new ManualCaller(ManualHandler);
            var asyncResult = caller.BeginInvoke(null, null);
            var result = caller.EndInvoke(asyncResult);
        }

        public int ManualHandler()
        {
            var counter = 0;
            while (counter < 5)
            {
                System.Diagnostics.Debug.WriteLine(++counter);
                System.Threading.Thread.Sleep(1000);
            }
            return counter;
        }

        public delegate int ManualCaller();


        [HttpGet]
        public void AsyncResultBlock()
        {
            var result = Helper().Result;
        }

        public async Task<int> Helper()
        {
            await Task.Delay(1000);
            return await Task.Run(() => 100);
        }
    }
}
