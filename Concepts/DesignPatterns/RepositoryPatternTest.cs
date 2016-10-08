using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class RepositoryPatternTest
    {
        /*
            Repository Pattern
            definition :    The Repository pattern adds a separation layer between the data and domain layers of an application. 
                            It also makes the data access parts of an application better testable. 
            solves :        separate business code from data access
                            separation of concerns
                            testability
            real world :    
            ex :            
            related :       unit of work
                            specification
                            identity map
                            decorator
            category :      
            hint :          entityFramework, nhibernate
            other :         business logic -> repository1, repository2, repository3 -> datasource
                            use when : database, web service, file system
            implementation : IRepository<T>
                                void Add(T newEntity)
                                void Remove(T entity)
                                IQueryable<T> Find(Expression<Func<T, bool>> predicate)
            consequences :  increased level of abstraction
                                more classes, less duplicated code
                                maintainability, flexibility, testability
                            further away from data
                                shielded from infrastructure
                                harder to optimize
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
