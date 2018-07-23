using System;
using System.Threading.Tasks;

namespace async_await_tasks_execution.console
{
    class Program
    {
        static void Main(string[] args)
        {
            //new task().test();
            //new taskwait().test();
            new asyncsemiawait().test();
            //new nestedtask().test();
            //new nestedasyncsemiawait().test();

            Console.ReadLine();
        }

    }
}
