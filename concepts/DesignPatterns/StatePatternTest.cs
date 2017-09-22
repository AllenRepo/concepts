using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class StatePatternTest
    {
        /*
            State Pattern
            definition :    the state pattern, which closely resembles Strategy Pattern, is a behavioral software design pattern, also known as the objects for states pattern. 
                            This pattern is used in computer programming to encapsulate varying behavior for the same object based on its internal state. 
                            This can be a cleaner way for an object to change its behavior at runtime without resorting to large monolithic conditional statements 
                            and thus improve maintainability
            solves :        multiple state
            real world :    work item tracking
            ex :            
            related :       chain of responsibility, command, interpreter, iterator, mediator,
                            memento, observer, state, strategy, template method, visitor
            category :      
            hint :          different states inherit from a common interface
                            these states have access to the main context and are in charge of moving to the next state.
                            
            other :         
            intent :        change behavior of the object with each state
                            encapsulate the logic of each state into a single object
                            allow for dynamic state discovery
                            make unit testing easier
            benefits :      separation of concerns
                            localization of state-specific behavior
                            transition between states is explicit and clear
                            reuse of the state objects
                            simplify the program
                            easier maintainability
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
