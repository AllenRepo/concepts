using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class StrategyPatternTest
    {
        /*
            Strategy Pattern aka Policy Pattern
            definition :     software design pattern that enables an algorithm's behavior to be selected at runtime. 
                            The strategy pattern 
                                defines a family of algorithms,
                                encapsulates each algorithm, and
                                makes the algorithms interchangeable within that family.
                            Strategy lets the algorithm vary independently from clients that use it. 
            solves :        
            real world :    
            ex :            delegates in c# > 3.5 
                            service classes passed to constructors for ASP.NET MVC controllers
            variations :    Func or delegates in .NET
                            property injection
                            pass strategy on aa method rather than a constructor
            related :       
            category :      
            hint :          extract complex algorithms to its own class
                            ie. calculating shipping cost for FedEx, UPS, USPS, DHL
            other :         
            intent :        encapsulate a family of related algorithms
                            let the algorithm vary and evolve separate from the class using it
                            allow a class to maintain a single purpose
                            separate the calculation from the delivery of its results
            use when :      switch statements are a red flag
                            adding a new calculation will cause a class file to be modified
            consequences :  strategies may not use members of the containing class
                            tests may now be written for individual concrete strategies
                            strategies may be mocked when testing the Context class
                            adding a new Strategy does not modify the COntext class
            summary :       use it to decouple algorithm implementation from a class
                            switch statements are a red flag
                            simple pattern to master
                            several techniques for implementing
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
