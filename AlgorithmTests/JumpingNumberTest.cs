using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmTests
{
    [TestClass]
    public class JumpingNumberTest
    {
        [TestMethod]
        public void test()
        {
            var results = compute(100);
            var text = string.Join(" ", results.ToArray());
        }

        public List<int> compute(int max)
        {
            var results = new List<int> { 0 };
            for (int i = 0; i < 10; i++)
            {
                results.AddRange(bfs(max, i));
            }
            return results;
        }

        public List<int> bfs(int max, int root)
        {
            var results = new List<int>();
            var queue = new Queue<int>();
            queue.Enqueue(root);

            while(queue.Count != 0)
            {
                var current = queue.Dequeue();
                if (current <= max)
                {
                    results.Add(current);
                    int lastDigit = current % 10;
                    if (lastDigit > 0)
                    {
                        queue.Enqueue((current * 10) + (lastDigit - 1));
                    }
                    if (lastDigit < 9)
                    {
                        queue.Enqueue((current * 10) + (lastDigit + 1));
                    }
                }
            }
            return results;
        }
    }
}
