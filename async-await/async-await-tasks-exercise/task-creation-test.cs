using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace async_await_tasks_exercise
{
    [TestClass]
    public class task_creation_test
    {
        [TestMethod]
        public void should_fail_with_new_constructor()
        {
            //This operation is banned from use
            var mainThreadId = Environment.CurrentManagedThreadId;

            //Arrange
            var actionTestContainer = new TaskTestContainer();
            var actionTask = new Task(TaskTestHelper.Action(actionTestContainer));

            var funcTestContainer = new TaskTestContainer();
            var funcTask = new Task<string>(TaskTestHelper.Func(funcTestContainer));

            //Assert
            Assert.AreEqual(actionTestContainer.Result, TaskTestContainer.TASK_DEFAULT_RESULT);
            Assert.AreEqual(actionTestContainer.ThreadId, 0);
            Assert.IsTrue(actionTestContainer.ElapsedTimeMilliseconds == 0);

            Assert.AreEqual(funcTestContainer.Result, TaskTestContainer.TASK_DEFAULT_RESULT);
            //Assert.AreEqual(funcTask.Result, TaskTestContainer.TASK_DONE_RESULT); //deadlocks
            Assert.AreEqual(funcTestContainer.ThreadId, 0);
            Assert.IsTrue(funcTestContainer.ElapsedTimeMilliseconds == 0);
        }

        [TestMethod]
        public void should_succeed_with_task_method()
        {
            //This operation is banned from use
            var mainThreadId = Environment.CurrentManagedThreadId;

            //Arrange
            var actionTestContainer = new TaskTestContainer();
            var actionTask = TaskTestHelper.ActionTask(actionTestContainer);

            var funcTestContainer = new TaskTestContainer();
            var funcTask = TaskTestHelper.FuncTask(funcTestContainer);

            //Assert
            Assert.AreEqual(actionTestContainer.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(actionTestContainer.ThreadId, mainThreadId);
            Assert.IsTrue(actionTestContainer.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);

            Assert.AreEqual(funcTestContainer.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreEqual(funcTask.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(funcTestContainer.ThreadId, mainThreadId);
            Assert.IsTrue(funcTestContainer.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);
        }


        [TestMethod]
        public void should_succeed_with_new_constructor_started()
        {
            //This operation is banned from use
            var mainThreadId = Environment.CurrentManagedThreadId;

            //Arrange
            var actionTestContainer = new TaskTestContainer();
            var actionTask = new Task(TaskTestHelper.Action(actionTestContainer));

            var funcTestContainer = new TaskTestContainer();
            var funcTask = new Task<string>(TaskTestHelper.Func(funcTestContainer));

            //Act
            actionTask.Start(); //deadlocks without start
            funcTask.Start(); //deadlocks without start
            actionTask.Wait();
            funcTask.Wait();

            //Assert
            Assert.AreEqual(actionTestContainer.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(actionTestContainer.ThreadId, mainThreadId);
            Assert.IsTrue(actionTestContainer.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);

            Assert.AreEqual(funcTestContainer.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreEqual(funcTask.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(funcTestContainer.ThreadId, mainThreadId);
            Assert.IsTrue(funcTestContainer.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);
        }

        [TestMethod]
        public void should_succeed_with_task_factory_startnew()
        {
            //This operation is banned from use
            var mainThreadId = Environment.CurrentManagedThreadId;

            //Arrange
            var actionTestContainer = new TaskTestContainer();
            var actionTask = Task.Factory.StartNew(TaskTestHelper.Action(actionTestContainer));

            var funcTestContainer = new TaskTestContainer();
            var funcTask = Task.Factory.StartNew(TaskTestHelper.Func(funcTestContainer));

            //Act
            actionTask.Wait();
            funcTask.Wait();

            //Assert
            Assert.AreEqual(actionTestContainer.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(actionTestContainer.ThreadId, mainThreadId);
            Assert.IsTrue(actionTestContainer.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);

            Assert.AreEqual(funcTestContainer.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreEqual(funcTask.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(funcTestContainer.ThreadId, mainThreadId);
            Assert.IsTrue(funcTestContainer.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);
        }

        [TestMethod]
        public void should_succeed_with_task_run()
        {
            //This operation is banned from use
            var mainThreadId = Environment.CurrentManagedThreadId;

            //Arrange
            var actionTestContainer = new TaskTestContainer();
            var actionTask = Task.Run(TaskTestHelper.Action(actionTestContainer));

            var funcTestContainer = new TaskTestContainer();
            var funcTask = Task.Run(TaskTestHelper.Func(funcTestContainer));

            //Act
            actionTask.Wait();
            funcTask.Wait();

            //Assert
            Assert.AreEqual(actionTestContainer.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(actionTestContainer.ThreadId, mainThreadId);
            Assert.IsTrue(actionTestContainer.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);

            Assert.AreEqual(funcTestContainer.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreEqual(funcTask.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(funcTestContainer.ThreadId, mainThreadId);
            Assert.IsTrue(funcTestContainer.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);
        }

        [TestMethod]
        public async Task should_succeed_with_async_task()
        {
            //This is the preferred way
            var mainThreadId = Environment.CurrentManagedThreadId;

            //Arrange
            var actionTestContainer = new TaskTestContainer();
            await TaskTestHelper.ActionTaskAsync(actionTestContainer);

            var funcTestContainer = new TaskTestContainer();
            var funcAwaitedTask = await TaskTestHelper.FuncTaskAsync(funcTestContainer);

            //Assert
            Assert.AreEqual(actionTestContainer.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(actionTestContainer.ThreadId, mainThreadId);
            Assert.IsTrue(actionTestContainer.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);

            Assert.AreEqual(funcTestContainer.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreEqual(funcAwaitedTask, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(funcTestContainer.ThreadId, mainThreadId);
            Assert.IsTrue(funcTestContainer.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);
        }

        [TestMethod]
        public void should_succeed_with_startnew_async_task()
        {
            //This is the preferred way
            var mainThreadId = Environment.CurrentManagedThreadId;

            //Arrange
            var actionTestContainer = new TaskTestContainer();
            Task.Factory.StartNew(async delegate
            {
                //returns Task<Task>, call Unwrap to encapsulate in a proxy task
                await TaskTestHelper.ActionTask(actionTestContainer);
            }).Unwrap().Wait();

            var actionTestContainer2 = new TaskTestContainer();
            Task.Factory.StartNew(async delegate
            {
                //returns Task<Task>, call Unwrap to encapsulate in a proxy task
                await TaskTestHelper.FuncTask(actionTestContainer2);
            }).Unwrap().Wait();

            var funcTestContainer = new TaskTestContainer();
            var funcAwaitedTask = Task.Factory.StartNew(() => TaskTestHelper.ActionTaskAsync(funcTestContainer))
                .Unwrap();
            funcAwaitedTask.Wait();

            var funcTestContainer2 = new TaskTestContainer();
            var funcAwaitedTask2 = Task.Factory.StartNew(() => TaskTestHelper.FuncTaskAsync(funcTestContainer2))
                .Unwrap();
            funcAwaitedTask2.Wait();

            //Assert
            Assert.AreEqual(actionTestContainer.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(actionTestContainer.ThreadId, mainThreadId);
            Assert.IsTrue(actionTestContainer.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);

            Assert.AreEqual(actionTestContainer2.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(actionTestContainer2.ThreadId, mainThreadId);
            Assert.IsTrue(actionTestContainer2.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);

            Assert.AreEqual(funcTestContainer.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreEqual(funcAwaitedTask2.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(funcTestContainer.ThreadId, mainThreadId);
            Assert.IsTrue(funcTestContainer.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);

            Assert.AreEqual(funcTestContainer2.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreEqual(funcAwaitedTask2.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(funcTestContainer2.ThreadId, mainThreadId);
            Assert.IsTrue(funcTestContainer2.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);
        }

        [TestMethod]
        public void should_succeed_with_run_async_task()
        {
            //This is the preferred way
            var mainThreadId = Environment.CurrentManagedThreadId;

            //Arrange
            var actionTestContainer = new TaskTestContainer();
            Task.Run(async delegate
            {
                //returns Task<Task>, call Unwrap to encapsulate in a proxy task
                await TaskTestHelper.ActionTask(actionTestContainer);
            }).Wait();

            var actionTestContainer2 = new TaskTestContainer();
            Task.Run(async delegate
            {
                //returns Task<Task>, call Unwrap to encapsulate in a proxy task
                await TaskTestHelper.FuncTask(actionTestContainer2);
            }).Wait();

            var funcTestContainer = new TaskTestContainer();
            var funcAwaitedTask = Task.Run(() => TaskTestHelper.ActionTaskAsync(funcTestContainer));
            funcAwaitedTask.Wait();

            var funcTestContainer2 = new TaskTestContainer();
            var funcAwaitedTask2 = Task.Run(() => TaskTestHelper.FuncTaskAsync(funcTestContainer2));
            funcAwaitedTask2.Wait();

            //Assert
            Assert.AreEqual(actionTestContainer.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(actionTestContainer.ThreadId, mainThreadId);
            Assert.IsTrue(actionTestContainer.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);

            Assert.AreEqual(actionTestContainer2.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(actionTestContainer2.ThreadId, mainThreadId);
            Assert.IsTrue(actionTestContainer2.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);

            Assert.AreEqual(funcTestContainer.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreEqual(funcAwaitedTask2.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(funcTestContainer.ThreadId, mainThreadId);
            Assert.IsTrue(funcTestContainer.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);

            Assert.AreEqual(funcTestContainer2.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreEqual(funcAwaitedTask2.Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreNotEqual(funcTestContainer2.ThreadId, mainThreadId);
            Assert.IsTrue(funcTestContainer2.ElapsedTimeMilliseconds >= TaskTestContainer.DELAY_TIME_MILLISECONDS);
        }
    }
}
