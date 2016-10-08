using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.Priciples
{
    [TestClass]
    public class OpenClosed
    {
        /*
            Definition : 
            In object-oriented programming, the open/closed principle states "software entities (classes, modules, functions, etc.) should be open for extension, 
            but closed for modification"; that is, such an entity can allow its behaviour to be extended without modifying its source code. 
            This is especially valuable in a production environment, where changes to source code may necessitate code reviews, unit tests, 
            and other such procedures to qualify it for use in a product: code obeying the principle doesn't change when it is extended, and therefore needs no such effort

            -----------------------------------------------------------------------------------------------------
            
            definition :    a class should be open for extensibility and closed for modification (originally in context of inheritance)
            should :        favour Composition over inheritance
                            strategy pattern favours Composition
            ok when :       bug fixing
            how :           change members/methods to be virtual, this is more of an inheritance approach. (try Composition)
        */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
