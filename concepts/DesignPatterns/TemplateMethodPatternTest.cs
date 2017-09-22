using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class TemplateMethodPatternTest
    {
        /*
            Template Method Pattern
            definition :    behavioral design pattern that defines the program skeleton of an algorithm in a method, 
                            called template method, which defers some steps to subclasses. 
                            It lets one redefine certain steps of an algorithm without changing the algorithm's structure.

                            *Hooks - methods declared in the abstract class that have no implementation
                                     allow sub-classes to "hook into" the behavior of the algorithm at various pointes (or to ignore the hooks entirely)
            solves :        
            real world :    
            ex :            chess, setupgame() -> taketurn(player) -> isgameover() -> displaywinner()
            related :       strategy, decorator, factory method
            category :      
            intent :        encapsulate and enfoce the workflow or process that is not variable
                            allow subclasses to alter specific behavior via concrete implementation
                            redefine one or more steps of an algorithm without altering its structure
            hint :          game process
                            asp.net web forms - PageLifeCycle
            use when :      modeling a process or algorithm of several steps
                            allow variation of the details of each step, while enforcing the structure and other of the steps themselves

                            two ore more classes should follow the same common algorithm or workflow
                            the workflow is invariant. subclasses may redefine certain steps, but may not change the algorithm's structure
                            some workflow steps may be encapsulated in the base class with a default implementation, and only overridden if necessary, allowing code reuse
            other :         
            consequences :  algorithm steps must be known and relatively inflexible at the time the pattern is applied
                            relies on inheritance, rather than composition, which can be a limitation -> try Strategy Pattern
                            single inheritance makes it difficult to merge two child algorithms into one -> try decorator pattern
            summary :       template method uses inheritance to define an algorithm in a superclass while delegating responsibility for detailed implementations to child classes
                            provide greater reuse but less flexibility than strategy pattern
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
