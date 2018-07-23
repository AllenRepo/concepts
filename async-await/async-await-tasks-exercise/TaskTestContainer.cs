using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_await_tasks_exercise
{
    public class TaskTestContainer
    {
        public const int DELAY_TIME_MILLISECONDS = 100;
        public const string TASK_DEFAULT_RESULT = "default";
        public const string TASK_DONE_RESULT = "done";

        public int ThreadId { get; set; } = 0;
        public long ElapsedTimeMilliseconds { get; set; } = 0;
        public string Result { get; set; } = TASK_DEFAULT_RESULT;
        public DateTime StartTime { get; set; }
        public long StartTick { get { return StartTime.Ticks; } }
        public DateTime StopTime { get; set; }
        public long StopTick { get { return StopTime.Ticks; } }
    }
    
    public class TaskTestHelper
    {
        public static Action Action(TaskTestContainer testContainer)
        => () =>
        {
            testContainer.ThreadId = Environment.CurrentManagedThreadId;
            testContainer.StartTime = DateTime.Now;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Task.Delay(TaskTestContainer.DELAY_TIME_MILLISECONDS)
                .Wait();
            testContainer.Result = TaskTestContainer.TASK_DONE_RESULT;
            stopWatch.Stop();
            testContainer.StopTime = DateTime.Now;
            testContainer.ElapsedTimeMilliseconds = stopWatch.ElapsedMilliseconds;
        };

        public static Task ActionTask(TaskTestContainer testContainer)
        {
            Action(testContainer)();
            return Task.CompletedTask;
        }

        public static async Task ActionTaskAsync(TaskTestContainer testContainer)
        {
            testContainer.ThreadId = Environment.CurrentManagedThreadId;
            testContainer.StartTime = DateTime.Now;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            await Task.Delay(TaskTestContainer.DELAY_TIME_MILLISECONDS);
            testContainer.Result = TaskTestContainer.TASK_DONE_RESULT;
            stopWatch.Stop();
            testContainer.StopTime = DateTime.Now;
            testContainer.ElapsedTimeMilliseconds = stopWatch.ElapsedMilliseconds;
        }

        public static Func<string> Func(TaskTestContainer testContainer)
        => () => {
            testContainer.ThreadId = Environment.CurrentManagedThreadId;
            testContainer.StartTime = DateTime.Now;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Task.Delay(TaskTestContainer.DELAY_TIME_MILLISECONDS)
                .Wait();
            testContainer.Result = TaskTestContainer.TASK_DONE_RESULT;
            stopWatch.Stop();
            testContainer.StopTime = DateTime.Now;
            testContainer.ElapsedTimeMilliseconds = stopWatch.ElapsedMilliseconds;
            return TaskTestContainer.TASK_DONE_RESULT;
        };

        public static Task<string> FuncTask(TaskTestContainer testContainer)
        {
            return Task.FromResult(Func(testContainer)());
        }

        public static async Task<string> FuncTaskAsync(TaskTestContainer testContainer)
        {
            testContainer.ThreadId = Environment.CurrentManagedThreadId;
            testContainer.StartTime = DateTime.Now;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            await Task.Delay(TaskTestContainer.DELAY_TIME_MILLISECONDS);
            testContainer.Result = TaskTestContainer.TASK_DONE_RESULT;
            stopWatch.Stop();
            testContainer.StopTime = DateTime.Now;
            testContainer.ElapsedTimeMilliseconds = stopWatch.ElapsedMilliseconds;
            return await Task.FromResult(TaskTestContainer.TASK_DONE_RESULT);
        }
    }
}
