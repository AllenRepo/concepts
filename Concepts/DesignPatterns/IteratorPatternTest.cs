using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class IteratorPatternTest
    {
        /*
            Iterator Pattern aka Cursor
            definition :    Design pattern in which an iterator is used to traverse a container and access the container's elements. 
                            The iterator pattern decouples algorithms from containers; 
                            in some cases, algorithms are necessarily container-specific and thus cannot be decoupled.
            solves :        iterating collections
                            provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation
            real world :    
            ex :            
            related :       factory, composite
            category :      
            hint :          Aggregate Interface : IEnumerable
                            Iterator Interface : IEnumerator
            other :         without iterator you would need to traverse collection and get item by index

                            use when :
                            traversing a collection
                            abstract the collection iteration logic
                            *separate logic of iterating an aggregate (a collection) from the aggregate itself

            consequences :  each iterator implementation may traverse the aggregate in a different fashion
                            iterators reduce the surface area of the Aggregate Interface, simplifying it.
                            by separating iterattion from the aggregate itself, more than one traversal
                                operation can occur at the same time. Iterators keep track of their own traversal state.

       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
