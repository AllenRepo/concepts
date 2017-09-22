using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.Priciples
{
    [TestClass]
    public class SingleResponsibility
    {
        /*
            Definition : 
            In object-oriented programming, the single responsibility principle states that every class should have responsibility over 
            a single part of the functionality provided by the software, and that responsibility should be entirely encapsulated by the class. 
            All its services should be narrowly aligned with that responsibility.

            Martin defines a responsibility as a reason to change, and concludes that a class or module should have one, and only one, reason to change. 
            As an example, consider a module that compiles and prints a report. Imagine such a module can be changed for two reasons. 
            First, the content of the report could change. Second, the format of the report could change. 
            These two things change for very different causes; one substantive, and one cosmetic. 
            The single responsibility principle says that these two aspects of the problem are really two separate responsibilities, 
            and should therefore be in separate classes or modules. It would be a bad design to couple two things that change for different reasons at different times.

            The reason it is important to keep a class focused on a single concern is that it makes the class more robust. Continuing with the foregoing example, 
            if there is a change to the report compilation process, there is greater danger that the printing code will break if it is part of the same class.

            -----------------------------------------------------------------------------------------------------
            definition :    class should only have a single responsibility
                                - a class should have only one reason to change
                                - do one thing, and do it well
                            separation of concerns
            real world :    unix -> linux (does one thing, and does it well)
            example :       separate caching, logging, storage, orchestration              

            code :          complex fileStore
                            break down to
                                messageStore -> storeLog, storeCache, fileStore
        */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
