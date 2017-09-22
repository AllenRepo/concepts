using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class FlyWeightPatternTest
    {
        /*
            Flyweight Pattern
            definition :    A flyweight is an object that minimizes memory use by sharing as much data as possible with other similar objects; 
                            it is a way to use objects in large numbers when a simple repeated representation would use an unacceptable amount of memory. 
                            Often some parts of the object state can be shared, and it is common practice to hold them in external data structures and 
                            pass them to the flyweight objects temporarily when they are used.
            solves :        reduce storage costs for large number of objects
                            share objects to be used in multiple contexts simultaneously
                            retain object oriented granularity and flexibility
            real world :    word processor, each character and their font info.
                            string.intern for c#
            ex :            
            related :       composite, strategy, state
            category :      
            hint :          
            other :          *Flyweight objects are by definition value objects.
            consequences :  group of objects are replaced by a few shared objects once extrinsic state is removed
                            storage savings are derived from
                                reduced instances
                                amount of intrinsic state per object
                                whether extrinsic state is computed or stored
                            application can no longer depend on object's identity

        */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
