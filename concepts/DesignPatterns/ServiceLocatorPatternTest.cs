using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class ServiceLocatorPatternTest
    {
        /*
            Service Locator Pattern
            definition :    design pattern used in software development to encapsulate the processes involved in obtaining a service with a strong abstraction layer. 
                            This pattern uses a central registry known as the "service locator", which on request returns the information necessary to perform a certain task
            solves :        
            real world :    411 service, operator
                                call a business to reach a department, operator directs to right department
                            Domain Name Service
            ex :            
            related :       Observer Design Pattern - locate new services when they become available
                            Proxy Design Pattern - match proxies to implementation
                            Adapter Design Pattern - used to adapt services to a common interface
                            Dependency Injection - pass in the services when clients are created
            category :      
            hint :          logging : log4net, nlog, enterprise library
            other :         app -> serviceLocator -> logging
            use when :      abstract the application from the services it uses
                            change the service without recompilation
                            identify the service through configuration
            consequences :  global - any client can access
                            availability - service may not be loaded
                            failure - caller must know how to handle failure
                            lifecycle - does not handle the object lifecycle
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
