using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class InterpreterPatternTest
    {
        /*
            Interpreter Pattern
            definition :    design pattern that specifies how to evaluate sentences in a language. 
                            The basic idea is to have a class for each symbol (terminal or nonterminal) in a specialized computer language. 
                            The syntax tree of a sentence in the language is an instance of the composite pattern and is used to evaluate (interpret) the sentence for a client
            solves :        
            real world :    barcode <=> barcode scanner
            ex :            
            related :       composite
            category :      
            hint :          
            other :          use when : -generally when some rule is defined and an interpreter make sense of it.
                                Specialized database query languages such as SQL.
                                Specialized computer languages which are often used to describe communication protocols.
                                Most general-purpose computer languages actually incorporate several specialized languages.
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
