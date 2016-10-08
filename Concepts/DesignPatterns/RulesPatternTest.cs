using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class RulesPatternTest
    {
        /*
            Rules Pattern
            definition :    
            solves :        growing complexity
                            duplicate conditions
            intent :        separate individual rules from rules processing logic
                            allow new rules to be added without the need for changes in the rest of the system
            real world :    business rules engines
            ex :            System.Workflow
            related :       
            category :      
            hint :          rules engine
            use when :      a system is suffering from conditional complexity, and additional changes of the same nature are anticipated
                            a system has comingled the concerns of choosing which actions are applicable, and executing these actions
                            a system needs to support user-created logic for determining when and how to apply actions
            other :         rule considerations : 
                                read only?
                                dependencies
                                explicit order
                                priority
                                halt
                                ersistence / user interface to edit
            practice :      The greed game kata
            summary :       separate the logic of each individual rule and its effects into its own class
                            separate the selection and processing of rules into a separate Evaluator class
                            use Business Rules Engine application or component if your application's requirements warrant it
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
