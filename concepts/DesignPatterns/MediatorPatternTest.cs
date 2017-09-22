using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class MediatorPatternTest
    {
        /*
            Mediator Pattern
            definition :    The essence of the Mediator Pattern is to "define an object that encapsulates how a set of objects interact". 
                            It promotes loose coupling by keeping objects from referring to each other explicitly, and it allows their interaction to be varied independently.
                            With the mediator pattern, communication between objects is encapsulated with a mediator object. Objects no longer communicate directly with each other, 
                            but instead communicate through the mediator. This reduces the dependencies between communicating objects, thereby lowering the coupling.
            solves :        Usually a program is made up of a large number of classes. So the logic and computation is distributed among these classes. However, 
                            as more classes are developed in a program, especially during maintenance and/or refactoring, 
                            the problem of communication between these classes may become more complex. 
                            This makes the program harder to read and maintain. Furthermore, it can become difficult to change the program, 
                            since any change may affect code in several other classes.
            real world :    air plane acknolodgin other air planes
            ex :            
            related :       
            category :      
            hint :          
            other :         use when : many similar objects need to communicate
                            pro : decoupled "colleagues", hide all coordination between colleagues.
                                  mediator's one-to-many relationship with colleagues is preferred to cleeagues relating in a many-to-many fashion
                            con : the mediator can become very large and very complicated as more colleagues are handled, ie. lots of "ifs" to determine which colleague
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
