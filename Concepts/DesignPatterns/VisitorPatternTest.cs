using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class VisitorPatternTest
    {
        /*
            Visitor Pattern
            definition :    Design pattern is a way of separating an algorithm from an object structure on which it operates. 
                            A practical result of this separation is the ability to add new operations to existing object structures without modifying those structures. 
                            It is one way to follow the open/closed principle.

                            Represent an operation to be performed on elements of an object structure. 
                            Visitor lets you define a new operation without changing the classes of the elements on which it operates. (GOF)
            solves :        
            real world :    traditional sales, trainer trains multiple sales
                            visitor selling (MLM), sell to group of people
            ex :            
            related :       
            category :      
            hint :          taxi dispatcher
                                customer calls taxi company (dispatcher)
                                company (dispatcher) sends a taxi to customer
                                upon entering the taxi, the customer is no longer in control, the taxi (visitor) is
            other :         
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
