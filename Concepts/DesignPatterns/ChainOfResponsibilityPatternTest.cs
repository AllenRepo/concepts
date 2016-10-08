using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPattern.Test
{
    [TestClass]
    public class ChainOfResponsibilityPatternTest
    {
        /*
            Chain of Responsibility Pattern
            definition :    is a design pattern consisting of a source of command objects and a series of processing objects.
                            Each processing object contains logic that defines the types of command objects that it can handle; 
                            the rest are passed to the next processing object in the chain. 
                            A mechanism also exists for adding new processing objects to the end of this chain.
            solves :        redeuced coupling
            real world :    
            ex :            president
                            vp1 -> manager1 manager2
                            vp2 -> manager3 manager4
                            employee
                            -------------------------
                            employee requests large raise -> manager 4 -> vp2 -> president
            related :       composite pattern, tre of responsibility
            category :      
            hint :          sender -> receiver1 -> receiver2 -> receiver3
                            sender sends messge to receiver1
                            receiver1 cannot process message and sends to receiver2
                            receiver2 processes the message and respond to receiver1
                            receiver1 recieves response and sends back to sender

                            poker ranking instead of convoluted ifs
        */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
