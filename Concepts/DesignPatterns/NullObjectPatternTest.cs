using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class NullObjectPatternTest
    {
        /*
            Null Object Pattern aka stub, active nothing, active null
            definition :    a Null Object is an object with defined neutral ("null") behavior. 
                            The Null Object design pattern describes the uses of such objects and their behavior (or lack thereof).
            solves :        null reference exceptions
            real world :    
            ex :            implementing a Null Startegy object, Null Command object
            related :       
            category :      
            hint :          strategy, command, state
            other :         use when :
                                when an object requires a collaborator
                                when handling of null should be abstracted from the client

                            NullObject is often a singleton
                                no behavior or state to vary over instances
                                multiple instances would be identical anyway

            consequences :  code cleaner
                            fewer null checks
                            less branching in the code = lower complexity
                            caller don't need to call whether they have a NullObject or a RealObject

       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
