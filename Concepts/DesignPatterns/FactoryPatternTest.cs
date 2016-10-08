using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPattern.Test
{
    [TestClass]
    public class UnitTest2
    {
        /*
            Factory Pattern
                Simple factory
                Factory method
                Abstract factory
            definition :    a factory is an object for creating other objects – formally a factory is simply an object that returns an object from some method call, 
                            which is assumed to be "new". More broadly, a subroutine that returns a "new" object may be referred to as a "factory", 
                            as in factory method or factory function.
            solves :        separate object creation from the decision of which object to create
                            add new classes and functionality without breaking OCP
            real world :    
            ex :            
            related :       singleton, builder, object pool, prototype
            category :      
            hint :          
            other :         use when :
                                unsure which concrete implementation of an interface to return
                                creation of an object 
                                lots of if/else/switch when deciding which concrete class to create

            Simple Factory
                            Encapsulate object creation
            required :      caller class knows what concrete factory it needs
            to solve OCP :  load from database of different types
                            use reflection to query current/other executing assemblies for a given type
            hint :          main -> factory -> getObject


            Factory Method
                            Define an interface for creating an object, but let the subclsses decide which class to instantiate. 
                            Factory method lets a class defer instantiation to subclasses.
            characteristics :   adds an interface to the factory itself from Simple Factory
                                Defers object creation to multiple factories that share an interface
                                Derived classes implement or override the factory method of the base
            pro :   eliminate references to concrete classes
                    factories can be inherited to provide even more specialized object creation
                    rules for object initialization is centralized
            con :   may need to create a factory just to get a concrete class derived
                    the inheritance hierarchy gets deeper with coupling between concrete factories and created classes
            hint :          main -> IFactory instance -> IObject factory -> specific object by config/etc

            Abstract Factory
                            provide an interface for creating families of related or dependent objects without specifying their concrete classes
            characteristics :   factories create different types of concrete objects
                                a factory now represents a "family" of objects that it can create
                                factories may have more than one factory method
            consequences :      add new factories and classes without breaking OCP
                                defer choosing classes to classes that specialize in making that decision
                                using private or internal constructors hides direct construction with the new keyword
            hint :          main -> IFactory instance -> specific Ifactory instance by config/etc -> specific object
        */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
