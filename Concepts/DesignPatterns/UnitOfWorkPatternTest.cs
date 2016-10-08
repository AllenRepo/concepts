using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concepts.DesignPatterns
{
    [TestClass]
    public class UnitOfWorkPatternTest
    {
        /*
            Unit of Work Pattern
            definition :    
            solves :        efficient data access, manage concurrency problems, manage transactions
            real world :    
            ex :            ado.net - SqlDataAdapter + DataTable
                            entityframework
                            linq to sql
            related :       repository, identity map
            category :      
            hint :          
            other :         
            consequences :  beware of lifetime issues
                                **singletons are deadly
            summary :       keep business logic free of data access code
                            keep business logic free from tracking changes
                            allow business logic to work with logical transactions
       */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
