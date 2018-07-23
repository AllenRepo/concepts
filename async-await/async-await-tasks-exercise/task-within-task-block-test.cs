using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace async_await_tasks_exercise
{
    [TestClass]
    public class task_within_task_block_test
    {
        [TestMethod]
        public void should_succeed_in_parallel()
        {
            //Arrange
            var testContainers = new List<TaskTestContainer>
            {
                new TaskTestContainer(),
                new TaskTestContainer(),
                new TaskTestContainer()
            };

            //Act
            method1(testContainers)
                .Wait();

            //Assert
            Assert.AreEqual(testContainers[0].Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreEqual(testContainers[1].Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreEqual(testContainers[2].Result, TaskTestContainer.TASK_DONE_RESULT);
        }

        public Task method1(List<TaskTestContainer> testContainers)
        {
            Task.Run(() => TaskTestHelper.Action(testContainers[0])())
                .Wait();
            return method2(testContainers);
        }

        public Task method2(List<TaskTestContainer> testContainers)
        {
            Task.Run(() => TaskTestHelper.Action(testContainers[1])())
                .Wait();
            return method3(testContainers);
        }

        public Task method3(List<TaskTestContainer> testContainers)
        {
            Task.Run(() => TaskTestHelper.Action(testContainers[2])())
                .Wait();
            return Task.CompletedTask;
        }
    }
}
