using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.Priciples
{
    [TestClass]
    public class SOLID
    {
        /*
            History : 
            mnemonic acronym introduced by Michael Feathers for the "first five principles" named by Robert C. Martin in the early 2000s 
            that stands for five basic principles of object-oriented programming and design.

            Pricinples : 
                Single Responsibility       code should only have one reason for change
                Open / Closed               code should be closed for modification, open for extension
                Linsov Substitution         if S is a subtype of T, then objects of type T may be replaced with objects of type S.
                Interface Segregation       granilar interfaces that describe one functionality
                Dependency Inversion        abstract dependency relying on interfaces to reduce coupling

            Definition : 
            The principles, when applied together, intend to make it more likely that a programmer will create 
            a system that is easy to maintain and extend over time.[3] The principles of SOLID are guidelines that can be 
            applied while working on software to remove code smells by causing the programmer to refactor the software's source code until it is both legible and extensible. 
            It is part of an overall strategy of agile and adaptive programming

            -----------------------------------------------------------------------------------------------------
            SOLID seems like overdesign

            SOLID is not :      framework, library, pattern, goal

            Design Smell :      Rigidity - the design is difficult to change
                                Fragility - the design is easy to break
                                Immobility - the design is difficult to reuse
                                Viscosity - it's difficult to do the right thing
                                Needless complexity - overdesign, "gold plating"
                                    Single responsibility principle may seem like needless complexity
                                    "developers have a tendency to attempt to solve specific problems with general solutions. This leads to coupling and complexity." -Greg Young
                                    "instead of being general, code should be specific." -Greg Young

                                    Following SRP, each concrete class is very specific
            
            *Reused abstractions principle - if abstractions is not reused, then abstraction is poor
            violation :         concrete1 -> interface1
                                concrete2 -> interface2
                                concrete3 -> interface3
                                concrete4 -> interface4
            correct :           concrete1 -> interface1
                                concrete2 -> interface1
                                concrete3 -> interface2
                                concrete4 -> interface2
            
            *Abstraction is the elimination of the irrelevant and the amplification of the essential
            
            Interfaces are not designed, interfaces are discovered
                Start with concrete behavior
                Discover abstractions as commonly emerges

            Rule of three (originally stated in context of refactoring)
                if only two commonality, then it's not clear on whether abstraction is clear

            Strangeler Pattern
            CRUD - Create, Read, Update, Delete
                - apply Create/Read to source code?! ie. GIT
                - use Strangeler pattern!
                    1. add new behavior
                    2. gradually move client to use new system
                example - X509Certificate -> X509Certificate2
                    1. multi clients defend on foo
                    2. create foo2
                    3. make foo obsolete
                    4. gradually migrate multi clients to use foo2
            
            Unit bias! 1 class vs 100 classes, 100 classes is more graniular

            Objects are data with behavior
            Functions are pure behavior
            Closures are behavior with data
            
            Functional !
            
        */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
