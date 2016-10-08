using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPattern.Test
{
    [TestClass]
    public class FacadePatternTest
    {
        /*
            Facade Pattern
            definition :    The facade pattern (or façade pattern) is a software design pattern commonly used with object-oriented programming. 
                            The name is by analogy to an architectural facade. 
                            A facade is an object that provides a simplified interface to a larger body of code, such as a class library.
            solves :        make complex code simpler to consume
            real world :    
            ex :            
            related :       adapter, flyweight, mediator
            category :      
            hint :          data access
                            file and stream io
                            pluralsight.com search with Lucene.NET
            other :         use to : encapsulates a complext api
            consequences :  facade will need to be updated
                            underlying APIs being wrapped will not be available through facade
        */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
