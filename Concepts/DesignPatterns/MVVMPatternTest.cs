using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class MVVMPatternTest
    {
        /*
            Model View ViewModel Pattern
                2004 originally by Martin Fowler - Presentation Model
                2005 John Gossman unveiled the MVVM pattern, variabtion of MVC pattern
                2008 John changes his mind, identical to PM pattern
            definition :    Model
                                Model refers either to a domain model, which represents the real state content (an object-oriented approach), 
                                or to the data access layer that represents that content (a data-centric approach).
                            View
                                As in the MVC and MVP patterns, the view is the user interface (UI).
                            View model
                                The view model is an abstraction of the view that exposes public properties and commands. 
                                Instead of the controller of the MVC pattern, or the presenter of the MVP pattern, MVVM has a binder. 
                                In the view model, this binder mediates communication between the view and the data binder.
                                The view model has been described as a state of the data in the model.
                            Binder
                                Declarative data- and command-binding are implicit in the MVVM pattern. 
                                In the Microsoft solution stack, the binder is a markup language called XAML. 
                                The binder frees the developer from being obliged to write boiler-plate logic to synchronise the view model and view. 
                                When implemented outside of the Microsoft stack the presence of a declarative databinding technology is a key enabler of the pattern.
            solves :        unit testing & ui testing
                            separate concerns - view, view's state and behavior, data
                            maintenance
                            extensibility
                            enables the designer/developer workflow
            real world :    
            ex :            
            related :       mvp, mvc, pm
            category :      
            hint :          knockoutjs, xaml binder
            collaboration : Model : the data
                            View : binding to ViewModel set by the DataContext
                            ViewModel : exposes the model as properties or commands, must implement INotifyPropertyChanged
                                -> must implement INotifyPropertyChanged for data binder on View to update itself
            other :         Pro :
                                reduce code-behind
                                model doesn't need to change to support a view
                                reduces development time where designer and coders work simultanously
                            Con : 
                                create more files
                                simple tasks can be complicated
                                lack of standardization
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
