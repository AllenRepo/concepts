using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace async_await_tasks_exercise
{
    [TestClass]
    public class task_within_task_non_block_test
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
            var task = method1(testContainers);

            //Assert
            Assert.AreEqual(testContainers[0].Result, TaskTestContainer.TASK_DEFAULT_RESULT);
            Assert.AreEqual(testContainers[1].Result, TaskTestContainer.TASK_DEFAULT_RESULT);
            Assert.AreEqual(testContainers[2].Result, TaskTestContainer.TASK_DEFAULT_RESULT);

            Task.Delay(TaskTestContainer.DELAY_TIME_MILLISECONDS * 2)
                .Wait();

            Assert.AreEqual(testContainers[0].Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreEqual(testContainers[1].Result, TaskTestContainer.TASK_DONE_RESULT);
            Assert.AreEqual(testContainers[2].Result, TaskTestContainer.TASK_DONE_RESULT);
        }

        public Task method1(List<TaskTestContainer> testContainers)
        {
            Task.Run(() => TaskTestHelper.Action(testContainers[0])());
            return method2(testContainers);
        }

        public Task method2(List<TaskTestContainer> testContainers)
        {
            Task.Run(() => TaskTestHelper.Action(testContainers[1])());
            return method3(testContainers);
        }

        public Task method3(List<TaskTestContainer> testContainers)
        {
            return Task.Run(() => TaskTestHelper.Action(testContainers[2])());
        }
    }
}
