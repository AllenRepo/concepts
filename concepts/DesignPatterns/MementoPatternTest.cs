using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class MementoPatternTest
    {
        /*
            Memento Pattern
            definition :    The memento pattern is a software design pattern that provides the ability to restore an object to its previous state 
                            The originator is some object that has an internal state. The caretaker is going to do something to the originator, 
                            but wants to be able to undo the change. The caretaker first asks the originator for a memento object. 
                            Then it does whatever operation (or sequence of operations) it was going to do. To roll back to the state before the operations, 
                            it returns the memento object to the originator. The memento object itself is an opaque object (one which the caretaker cannot, 
                            or should not, change). When using this pattern, care should be taken if the originator may change other objects or resources - 
                            the memento pattern operates on a single object.

                            "without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later." -gang of four
            solves :        undo via rollback
            real world :    
            ex :            
            related :       command - commands can use Mementos to provide Undo functionality
                            iterator - a memento can represent each iteration state
            category :      
            hint :          originator, caretaker, and memento
            other :         use when : track state and to restore previous state
                                       you want to abstract and reuse the undo/redo functionality

                            undo/redo stack
            alternatives :  1. store reverse operations, ie. 1 + 1, store -1 operation
                            2. iterative memento, ie. version control such as git where it detects changes
            collaboration : when a change occurs
                                a caretaker requests a Memento from the Originator
                                the caretaker stores one ore more Mementos until they are needed
                                If or when required, the caretaker passes a Memento back to the Originator
                                Mementos should be Value Objects, holding state but no behavior
                                Only the Originator that created a Memento should assign or retrieve its state.
            consequences :  creating and restoring state may be expensive
                            not appropriate when state contains a large amount of info.
                            may be difficult to ensure only Originator can access Memento's state
                            caretaker responsible for managing Mementos, but has no idea how big or small they are
                            Memento pattern shields other objects from potentially complex internal state of the Originator
                            As opposed to the Originator maintaining versions of its internal state, the Memento pattern keeps Originator simpler
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
