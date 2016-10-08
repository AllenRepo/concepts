using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPattern.Test
{
    [TestClass]
    public class EventAggregatorPatternTest
    {
        /*
            Event aggregator pattern aka Message Bus Pattern
            definition :    By introducing an event aggregator in between the publishers and subscribers, you can remove this tight coupling. 
                            The subscriber observes the event aggregator instead of the publisher and the publisher knows only about the event aggregator and not about the subscribers.
            solves :        reduce coupling between publishers and subscribers
                            simplifying event registeration by providing a single centralized store
                            reduce friction for introducing new events
                            reduce memory management issues related to eventing
            real world :    
            ex :            
            related :       pubish/subscribe, observer
            category :      
            hint :          publisher -> aggregator, subscriber observes aggregator
            other :          use when : COMPLEX eventing
                                building composite application
                                have complex screens
                                have many publishers and subscribers
                                have many events
                                new events are added frequently
                                static events!
            how :           publishers and subscribers each hold a reference to the aggregator
                            publishers call publication methods to notify subscribers
                            subscribers call subscription methods to receive notifications
            pro :           publishers and subscribers are completely decoupled
                            new events can more easily be introduced in the system (open/closed principle)
                            memory leaks due to eventing are reduced
            samples :       StoryTeller - http://storyteller.tigris.org
                            MVVM Ligh - http://mvvmlight.codeplex.com
                            Prism - http://microsoft.com/prism
        */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
