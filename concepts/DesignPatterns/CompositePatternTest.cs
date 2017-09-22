using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DesignPattern.Test
{
    [TestClass]
    public class CompositePatternTest
    {
        /*
            Composite Pattern
            definition :    is a partitioning design pattern. The composite pattern describes that a group of objects is to be treated in the same way as a single instance of an object. 
                            The intent of a composite is to "compose" objects into tree structures to represent part-whole hierarchies. 
                            Implementing the composite pattern lets clients treat individual objects and compositions uniformly
            solves :        complex tree problems where logic is applied differently for node vs leaf
            real world :    
            ex :            
            related :       
            category :      
            hint :          compose objects into tree structure to represent part-whole hierarchies
                            
                            send email without groups (w/o composite pattern)

                            splitting gold among groups and individuals
                                distribution among complex tree
            other :          
        */
        private Group _guild;
        [TestInitialize]
        public void Init()
        {
            _guild = new Group
            {
                Members = new List<ICanShareGold> { 
                    new Group { Members = new List<ICanShareGold> {
                        new Person { Name="Allen"},
                        new Person { Name = "Romina" } }
                    },
                    new Person() {Name="Solo Mid" },
                    new Group { Members = new List<ICanShareGold> {
                        new Person { Name="Top"},
                        new Person { Name="Bottom"},
                        new Group { Members = new List<ICanShareGold> {
                            new Person { Name="AFK"},
                            new Person { Name="AFK" } }
                        } }
                    }
                }
            };
        }

        [TestMethod]
        public void TestMethod1()
        {
            _guild.Gold = 100;
            _guild.Stats();
        }

        public interface ICanShareGold
        {
            int Gold { get; set; }
            void Stats();
        }
        public class Group : ICanShareGold
        {
            public List<ICanShareGold> Members { get; set; }
            public int Gold
            {
                get
                {
                    int totalGold = 0;
                    foreach (var member in Members)
                    {
                        totalGold += member.Gold;
                    }
                    return totalGold;
                }
                set
                {
                    int goldToSPlit = value / Members.Count;
                    int remainingGold = value % Members.Count;
                    foreach(var member in Members)
                    {
                        member.Gold += goldToSPlit + remainingGold;
                        remainingGold = 0;
                    }
                }
            }
            public void Stats()
            {
                foreach(var member in Members)
                {
                    member.Stats();
                }
            }
        }

        public class Person : ICanShareGold
        {
            public string Name { get; set; }
            public int Gold { get; set; }
            public void Stats()
            {
                System.Diagnostics.Trace.WriteLine(string.Format("{0} has {1} gold.", Name, Gold));
            }
        }
    }
}
