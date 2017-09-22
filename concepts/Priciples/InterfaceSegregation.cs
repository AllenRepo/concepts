using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.Priciples
{
    [TestClass]
    public class InterfaceSegregation
    {
        /*
            Definition : 
            states that no client should be forced to depend on methods it does not use. 
            ISP splits interfaces which are very large into smaller and 
            more specific ones so that clients will only have to know about the methods that are of interest to them. 
            Such shrunken interfaces are also called role interfaces. 
            ISP is intended to keep a system decoupled and thus easier to refactor, change, and redeploy.

            Typical Violation :
            An interface for the User Interface for an ATM, that handles all requests such as a deposit request, 
            or a withdrawal request, and how this interface needs to be segregated into individual and more specific interfaces.

            -----------------------------------------------------------------------------------------------------

            definition :    clients should not be forced to depend on methods they do not use
            
            favour role interfaces over header interfaces
                            header interface ie. C++ header files
                            role interface defines few members
        */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
