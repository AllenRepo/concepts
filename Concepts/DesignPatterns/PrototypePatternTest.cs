using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class PrototypePatternTest
    {
        /*
            Prototype Pattern
            definition :    a creational design pattern in software development. It is used when the type of objects to create is determined by a prototypical instance, 
                            which is cloned to produce new objects. This pattern is used to:

                            avoid subclasses of an object creator in the client application, like the abstract factory pattern does.
                            avoid the inherent cost of creating a new object in the standard way (e.g., using the 'new' keyword) 
                            when it is prohibitively expensive for a given application.
            solves :        
            real world :    getting a water bill from utility services vs simply cloning existing copy
            ex :            
            related :       
            category :      
            hint :          javascript language is built on the prototype pattern
            
                            C# IClonable -> return MemberWiseClone()
                            Java Clonable -> clone()
            other :         client -> prototype <- concrete prototype
            roles :         Prototype
                                interface or abstract class
                                defines a method to clone an object
                            Concrete Prototype
                                an class implementing the prototype
                                basically has a way to copy itself
                                deep or shallow copy
       */
        [TestMethod]
        public void TestMethod1()
        {
            
        }
    }
}
