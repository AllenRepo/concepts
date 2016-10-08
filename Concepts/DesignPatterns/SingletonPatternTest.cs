using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class SingletonPatternTest
    {
        /*
            Singleton Pattern
            definition :    In software engineering, the singleton pattern is a design pattern that restricts the instantiation of a class to one object. 
                            This is useful when exactly one object is needed to coordinate actions across the system.
            solves :        ensure class has only one instance
                            make the class itself responsible for keeping track of its sole instance
            real world :    
            ex :            
            related :       abstract factory, factory method, builder
            category :      
            hint :          
            other :         Singletons should only be created when they are first needed (e.g. lazy construction)
                            
                            Singleton
                                + Instance()
                                + OtherOperations()
                                - Singleton()


            use when :      there must be one and only one instance of a class
                            the class must be accessible to clients
                            the class should not require parameters as part of its ocnstruction
                            when creating the instance is expensive, a Singleton can improve performance
            consequences :  singletons introduce tight coupling among collaboration classes
                            singletons are notoriously difficult to test
                                commonly regarded as an anti-pattern
                            using an IOC Container to avoid the coupling and testability issues
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }

    public class LazySingleton
    {
        private LazySingleton()
        {

        }
        private static LazySingleton Instance
        {
            get { return Nested.instance; }
        }

        private class Nested
        {
            static Nested()
            {
                //A static constructor is used to initialize any static data, or to perform a particular action that needs to be performed once only. 
                //It is called automatically before the first instance is created or any static members are referenced.

            }
            internal static readonly LazySingleton instance = new LazySingleton();
        }
    }
}
