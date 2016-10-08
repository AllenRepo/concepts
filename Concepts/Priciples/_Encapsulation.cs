using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace Concepts.Priciples
{
    [TestClass]
    public class Encapsulation
    {
        /*
            Encapsulation
            Definition :    Information hiding - implementation hiding
                            Protection of invariants - pre/post condition check
                                invalid states are impossible
            Beyond OO :     Command Query Separation, CQS
                                principle states that you can either be command or query but not both.
                            
                            commands have side effects - changing state
                                mutate state
                                    ie. void Save(Order order);
                                    ie. void Send (T message);
                                    ie. void Associate(IFoo foo, Bar bar);
                                all three has void return type meaning they mutate some state

                            queries - return data
                                do not mutate observable state 
                                aka Idempotent - meaning first execution and Nth execution result in same result
                                safe to invoke
                                    ie. Order[] GetOrders(int userId);
                                    ie. IFoo Map(Bar bar);
                                    ie. T Create();
                                all three returns some collection or object 

                            CQS makes it easier to reason about code
            Beyond OO :     Postel's Law aka Robustness principle (originally a principle for designing network protocol)
                                be conservative in what you send
                                be liberal in what you accept
                            Input - add guard clauses to prevent user error
                            Output - prevent null
                                1. Tester/Doer **Not thread safe
                                    test conditions before executing code
                                    or
                                    when an operation can be illegal, such operation should come in pair
                                        ie. File.Read(filePath), filePath should exist in order to read
                                            to prevent returning null, break into File.Exist(filePath) & File.Read(filePath)
                                2. TryParse **can be thread safe, break fluent method chain, not OOP
                                    return if operation valid and also an out parameter with the result
                                3. Maybe **from functional programming, a result collection with 0 or 1 item

            facts :         Value Type - nullable and non-nullable
                            Reference Type - nullable
                            "billion-dollar mistake, I coudn't resist the temptation to put in a null reference simply because it was so easy to implement. 
                            This has led to innumerable errors, vulnerabilities, and system crashes.." -Tony Hoare, creator of c# dot.net

                            We spend more time READING than writing code
                            Make code easier to read!!

                            it's ok to make class public if you protect their invariants

                            Write for stupid/ignorant programmers
                                write code for programmers whom don't know what you knew when you wrote the code
            
            should :        easily understandable
                            make invalid states impossible
                            fail fast (with clear exception messages)
                            never return null
        */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
    public class Maybe<T> : IEnumerable<T>
    {
        private readonly IEnumerable<T> values;
        public Maybe()
        {
            this.values = new T[0];
        }
        public Maybe(T value)
        {
            this.values = new[] { value };
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this.values.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
