using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class LazyLoadPatternTest
    {
        /*
            Lazy Load Pattern
            definition :    design pattern commonly used in computer programming to defer initialization of an object until the point at which it is needed. 
                            It can contribute to efficiency in the program's operation if properly and appropriately used. The opposite of lazy loading is eager loading.
            solves :        performance
            real world :    
            ex :            
            related :       oppostie : eager loading
                            related : Lazy load -> proxy pattern
                                      ValueHolder -> strategy pattern
                                      ghost -> template method pattern
            category :      lazy initialization, virtual proxy, value holder, ghost
            hint :          Lazy<T>
            other :         beware of ripple loading : fetch a whole collection instaed of individual
                            use when :
                                1. fetaching an object requires an extra call for the data, and the data you're fetching isn't used when the main object is used.
                                2. avoid using it unless or until you need it, use it as a tuning mechanism
                                3. need to balance amount of data being fetched with number of data requests being made

                            Lazy initialization
                                using Lazy<T> to take care of initialization of object, Lazy<T> takes care of thread safety. Alternatively is to you a property initializer.

                            Virtual proxy
                                problem : may need to create many virtual proxies
                                problem : may have identity problem, resolve this by overriding equals() and gethashcode()
                                
                                Best done via code generation ie. T4
                                Many ORM tools create dynamic proxies at runtime (nHibernate, EntityFramework)

                                SomeClaas <- SomeClassProxy where both implements SomeClass, SomeClassProxy takes care of lazy loading and ultimately return instance of SomeClass

                                consequences   
                                    manage identity
                                    need to create virtual proxy for each class
                                    !!these problems are not present for collections, collections are value objects that do not have identity.
                                    !!typically there are far fewer collections than objects
                                    !!collections typically provide largest performance benefit from lazy loading
                            
                            Value Holder : use when < .net 4, otherwise use Lazy<T>
                                provides lazy loading functionality without encapsulation
                                calling code know it is working with a Value Holder type
                                requires creating several new types (similar to Lazy<T>)
                                    ValueHOlder (reusable)
                                    IValueHOlder (reusable)
                                    Factory or Mapper classes
                                ValueHOlder uses IValueLoader via Strategy Pattern to load value when accessed
                            
                            Ghosts / ghost object
                                A ghost is a real object in a partial state
                                Initially, the ghost only contains it id
                                    whenever any property is accessed, the ghost class loads all of its state
                                essentially, ghost object is its own proxy

                                !!Violates SRP due to multiple persistence and an abstract base class
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
