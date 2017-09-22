using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class MVPPatternTest
    {
        /*
            Model View Presenter
            definition :    The model is an interface defining the data to be displayed or otherwise acted upon in the user interface.
                            The view is a passive interface that displays data (the model) and routes user commands (events) to the presenter to act upon that data.
                            The presenter acts upon the model and the view. It retrieves data from repositories (the model), and formats it for display in the view.
            solves :        
            real world :    
            ex :            
            related :       MVC, MVVM, Supervising Controller (MVP variation), Passive View (MVP variation)
            category :      
            hint :          Classic web forms and win forms can utilize MVP
            other :         View and Model know nothing of each other!
                            Presenter coordinates requests and events between the Model and the View
            collaboration : Model
                                holds data destined to be surfaced by the view
                            View
                                instantiates the Presenter
                                requests that the Presenter do work
                                May have a reference to the model or may rely on the Presenter to set data on the View using the Model
                            Presenter
                                responds to View requests
                                may knows when data is updated
                                updates the View with data form the Model
            consequences :  each class is testable in isolation of the others
                            clear separation of concerns
                            each collaborator has a single responsibility
                            more readable and maintainable
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
