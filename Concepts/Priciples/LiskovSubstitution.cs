using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.Priciples
{
    [TestClass]
    public class LiskovSubstitution
    {
        /*
            Definition : 
            Substitutability is a principle in object-oriented programming. It states that, in a computer program, 
            if S is a subtype of T, then objects of type T may be replaced with objects of type S (i.e., 
            objects of type S may substitute objects of type T) without altering any of the desirable properties of that program (correctness, task performed, etc.). 
            More formally, the Liskov substitution principle (LSP) is a particular definition of a subtyping relation, called (strong) behavioral subtyping,
            
            Let Φ(x) be a property provable about objects x of type T. Then Φ(y) should be true for objects y of type S where S is a subtype of T.

            Typical Violation : 
            A typical example that violates LSP is a Square class that derives from a Rectangle class, assuming getter and setter methods exist for both width and height. 
            The Square class always assumes that the width is equal with the height. If a Square object is used in a context where a Rectangle is expected, 
            unexpected behavior may occur because the dimensions of a Square cannot (or rather should not) be modified independently. 
            This problem cannot be easily fixed: if we can modify the setter methods in the Square class so that they preserve the Square invariant (i.e., keep the dimensions equal), 
            then these methods will weaken (violate) the postconditions for the Rectangle setters, which state that dimensions can be modified independently. 
            Violations of LSP, like this one, may or may not be a problem in practice, depending on the postconditions or 
            invariants that are actually expected by the code that uses classes violating LSP. Mutability is a key issue here. 
            If Square and Rectangle had only getter methods (i.e., they were immutable objects), then no violation of LSP could occur.  

            -----------------------------------------------------------------------------------------------------

            liskov - polymorphism
                named after Barbara Liskov

            definition :    subtypes must be substitutable for their base types
                            consume any implementation without changing the correctness of the system
            violation :     1. when code throws NotSupportedException
                                ie. IReadOnlyCollection<T> -> ICollection<T>
                                IReadOnlyCollection<T>'s Add(), Clear(), Remove() throws NotSupportedException()
                            2. downcasts
                            3. extracted interfaces

            Liskov is often violated by attemps to remove features
            Reused abstractions principle compliance indicates Liskov subsititution pricicple compliance
        */
        [TestMethod]
        public void TestMethod1()
        {
            var temp = 2;
            temp += 3;
        }
    }
}
