using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace async_await_tasks_exercise
{
    [TestClass]
    public class tpl_parallel_for_test
    {
        private const int CORRECT_SUM = 49995000;
        private List<int> CollectionOfInts;
        private int Result = 0;

        [TestInitialize]
        public void init()
        {
            this.CollectionOfInts = new List<int>();
            for (var x = 0; x < new int[10000].Length; x++)
            {
                this.CollectionOfInts.Add(x);
            }
        }

        [TestMethod]
        public void should_sum_imperatively()
        {
            //Arrange
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            //Act
            foreach(var x in this.CollectionOfInts)
            {
                Result += x;
            }
            stopwatch.Stop();

            //Assert
            Assert.AreEqual(CORRECT_SUM, this.Result);
        }

        [TestMethod]
        public void should_sum_using_parallel_foreach()
        {
            //Arrange
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            //Act
            Parallel.ForEach(this.CollectionOfInts, 
                () =>
                {
                    return 0;
                },
                (x, state, total) =>
                {
                    return total += x;
                },
                (total)=>
                {
                    lock(this.CollectionOfInts)
                    {
                        Result += total;
                    }
                });
            stopwatch.Stop();

            //Assert
            Assert.AreEqual(CORRECT_SUM, this.Result);
        }

        [TestMethod]
        public void should_sum_using_parallel_linq()
        {
            //Arrange
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            //Act
            this.Result = this.CollectionOfInts.AsParallel().Sum();
            stopwatch.Stop();

            //Assert
            Assert.AreEqual(CORRECT_SUM, this.Result);
        }

        [TestMethod]
        public void should_sum_declaratively()
        {
            //Arrange
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var add = (Func<int, int, int>)((a, b) => a + b);
            var reduce = (Func<IEnumerable<int>, Func<int, int, int>, int>)((collection, func) =>
            {
                var enumerator = collection.GetEnumerator();
                var result = enumerator.Current;
                while(enumerator.MoveNext())
                {
                    result = func(result, enumerator.Current);
                }
                return result;
            });

            //Act
            this.Result = reduce(CollectionOfInts, add);

            //Assert
            Assert.AreEqual(CORRECT_SUM, this.Result);
        }

        [TestCleanup]
        public void cleanup()
        {
            this.Result = 0;
        }
    }
}
