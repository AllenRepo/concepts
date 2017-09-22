using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPattern.Test
{
    [TestClass]
    public class CommandPatternTest
    {
        /*
            The Command Pattern aka Action, Transaction
            definition :    In object-oriented programming, the command pattern is a behavioral design pattern in which an object is used to encapsulate 
                            all information needed to perform an action or trigger an event at a later time.
            solves :        decouples clients that execute the command from the details and dependencies of the command logic
                            enables delayed execution
            real world :    
            ex :            main() {                                                //client
                                ISwitchable lamp = new Light()
                                ICommand close = new CloseSwitchCommand(lamp)
                                ICommand open = new OpenSwitchCOmmand(lamp)
                                Switch switch = new Switch(close, open)
                                switch.open() / switch.close()
                            }
                            interface ICommand {execute();}
                            class OpenSwitchCommand : ICommand                      //concrete command
                            class CloseSwitchCommand : ICommand                     //concrete command
                            interface ISwitchable {PowerOn();PowerOff();}

                            class Light : ISwitchable                               //receiver
                            class Switch {                                          //invoker
                                ctor Switch(ICommand close, ICommand open)                        
                                close(){close.execute()}
                                open(){open.execute}
                            }      

            related :       factory, null object, composite
            category :      
            hint :          logging, validation, undo
                            *four terms always associated with command pattern are : command, receiver, invoker, and client
                            client -> command:validat(), execute(), undo() ->>> depdencies
            other :         commands must be completely self contained
                                client doesn't pass any arguments
                            easy to add new commands
                                by adding new class (open/closed principal)

        */
        [TestMethod]
        public void TestMethod1()
        {
            
        }
    }
}
