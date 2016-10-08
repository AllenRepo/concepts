using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class ProxyPatternTest
    {
        /*
            Proxy Pattern aka Surrogate
            definition :    A proxy, in its most general form, is a class functioning as an interface to something else. 
                            The proxy could interface to anything: a network connection, a large object in memory, 
                            a file, or some other resource that is expensive or impossible to duplicate. 
                            In short, a proxy is a wrapper or agent object that is being called by the client to access the real serving object behind the scenes.
            solves :        
            real world :    
            ex :            
            related :       adapter - the adapter pattern changes n object's interface; the proxy pattern retains the same interface but controls access to the underlying behavior
                            decorator - the decorator has a similar implementation to the proxy, but its intent is different. 
                                A decorator adds responsibility to an object, while the Proxy controls access to an object.
            category :      remote proxy (wcf) - acts as a local representative of a remote object, and abstracts away the details of communicating with the remote object
                            virutal proxy - creates expensive objects on demand, a common example is an Image Proxy that shows a placeholder while the image is being loaded or rendered.
                            protextion proxy - can be used to control access to an object, based on authorization rules
            hint :          control access to an object
                            virtual proxy -> ORM
                            remote proxy -> WCF
            other :         use when :   
                                improve performance and load time of an application
                                simplify interactions with remote objects
                                defer expensive calls until needed - implement lazyloading of object from persistence
                            structure : 
                                subject <- real subject
                                subject <- proxy, real subject <- proxy
                                or
                                real subject <- proxy
            consequences :  client code does not need to be changed to work with a Proxy
                                usually crated by code generation ie. t4
                            proxy may be used to optimize performance in an existing system without touching exiting class behavior
                            client code may take incorrect assumptions about behavior of real object
                                interface may use many small calls rather than few, large calls
                                chatty versus clunky interface
                                client access to lazy-loaded object may result in more database calls than necessary
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
