using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class ObserverPatternTest
    {
        /*
            Observer Pattern
            definition :    software design pattern in which an object, called the subject, maintains a list of its dependents, 
                            called observers, and notifies them automatically of any state changes, usually by calling one of their methods. 
                            It is mainly used to implement distributed event handling systems. 
                            
                            The Observer pattern is also a key part in the familiar model–view–controller (MVC) architectural pattern. 
                            The observer pattern is implemented in numerous programming libraries and systems, including almost all GUI toolkits.

                            The observer pattern can cause memory leaks, known as the lapsed listener problem, 
                            because in basic implementation it requires both explicit registration and explicit deregistration, 
                            as in the dispose pattern, because the subject holds strong references to the observers, keeping them alive. 
                            This can be prevented by the subject holding weak references to the observers.
            solves :        
            real world :    mvc, GUI controls
            ex :            
            related :       
            category :      Traditional
                                implementation
                                    abstract subject -> abstract observer <- observer -> main -> abstract subject
                                consequences
                                    multiple subjects for each observer
                                    disposed subjects & observers can hold references to each other
                                    mapping of subjects to their observers
                                    unexpected updates
                                    observing different properties separately
                            Events and Delegates
                                utilize event and eventHandler of .net to achieve
                            IObservable<T>
            hint :          IObservable<T> is the dual of IEnumerable
                                IObservable<T> provides a push based interface
                                IEnumerable<T> provides a pull based interface
            other :         use when :
                                one object is dependent on another object
                                when changing one object requires a change to many others
                                when changes to an object should allow notification to others without any knowledge of them
                            pitfalls
                                unexpected thread
                                multiple threads
                                memory leaks
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
