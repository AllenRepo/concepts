using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.Priciples
{
    [TestClass]
    public class DependencyInversion
    {
        /*
            Definition : 
            the dependency inversion principle refers to a specific form of decoupling software modules. 
            When following this principle, the conventional dependency relationships established from high-level, 
            policy-setting modules to low-level, dependency modules are inverted (i.e. reversed), 
            thus rendering high-level modules independent of the low-level module implementation details. The principle states:

                A. High-level modules should not depend on low-level modules. Both should depend on abstractions.
                B. Abstractions should not depend on details. Details should depend on abstractions.
            
            The principle inverts the way some people may think about object-oriented design, 
            dictating that both high- and low-level objects must depend on the same abstraction

            -----------------------------------------------------------------------------------------------------
            favour composition over inheritance

            definition :    high-level modules should not depend on low-level modules. Both should depend on abstractions
                            Abstractions should not depend upon details. Details should depend upon abstractions

            Composite Pattern :    
                            a composite class in charge of executing a collection of commands implementing the same interface
            Decorator Pattern :
                            compose commands implementing the same interface into nested structure
            
            *All details depend on abstractions but none of the abstractions depend on the detail

        */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
