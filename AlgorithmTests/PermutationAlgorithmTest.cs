using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTests
{
    [TestClass]
    public class PermutationAlgorithmTest
    {
        [TestMethod]
        public void should_generate_permutations()
        {
            //Arrange
            var str = "abc";
            var str2 = "ab";

            //Act
            var result = GetPermutation(str, 0);
            var result2 = GetPermutation(str2, 0);
            //Assert
        }

        public IEnumerable<string> GetPermutation(string str, int index)
        {
            if (index >= str.Length -1)
            {
                return new string[0];
            }

            var list = new List<string>();
            var partialStr = str.Remove(index, 1);
            for (int i = 0; i < str.Length; i++)
            {
                list.Add(partialStr.Insert(i, str[index].ToString()));
            }

            return GetPermutation(str, ++index).Concat(list);
        }
    }
}
