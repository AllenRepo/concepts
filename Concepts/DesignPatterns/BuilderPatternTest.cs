using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPattern.Test
{
    [TestClass]
    public class BuilderPatternTest
    {
        /*
            Builder Pattern 
            definition :    Instead of using numerous constructors, the builder pattern uses another object, 
                            a builder, that receives each initialization parameter step by step and then returns the resulting constructed object at once.
            solves :        too many param, order dependent, different constructions
            real world :    making a sandwich (subway sandwich ordering)
                            vs
                            a named sandwich or a pre-defined ingredients
            ex :            director - builder => concrete builder => data
            related : 
            category :      factory objet creator pattern
            hint :          separate logic from data
                            instead of a long constructor Sandwich(ingredient a, ingredient b, ..) or lots of properties, rely on a builder class to create the object
            summary :       easy to get wrong, more brittle and less testable
                            **object lifetime management is usually better handled by a container with this responsibility
        */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
