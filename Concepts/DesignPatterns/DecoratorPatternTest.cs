using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPattern.Test
{
    [TestClass]
    public class DecoratorPatternTest
    {
        /*
            Decorator Pattern aka Wrapper
            definition :    is a design pattern that allows behavior to be added to an individual object, either statically or dynamically, 
                            without affecting the behavior of other objects from the same class. 
                            The decorator pattern is often useful for adhering to the Single Responsibility Principle, 
                            as it allows functionality to be divided between classes with unique areas of concern
            solves :        add functionality to existing objects dynamically
                            alternative to sub classing
                            flexible design
                            support open closed principle
            real world :    
            ex :            
            related :       structural pattern, adapter, bridge, composite, facade, flyweight, proxy
            category :      
            hint :          pizza toppings
            other :         used for legacy systems, add functionality to controls, or sealed classes

            con :          can increase complexity of code!
        */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
