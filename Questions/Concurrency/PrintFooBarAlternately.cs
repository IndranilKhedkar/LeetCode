using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/print-in-order/
    /// Suppose you are given the following code:
    /// class FooBar
    /// {
    ///     public void foo()
    ///     {
    ///         for (int i = 0; i < n; i++)
    ///         {
    ///             print("foo");
    ///         }
    ///     }
    /// 
    ///     public void bar()
    ///     {
    ///         for (int i = 0; i < n; i++)
    ///         {
    ///             print("bar");
    ///         }
    ///     }
    /// }
    /// The same instance of FooBar will be passed to two different threads.Thread A will call foo() while thread B will call bar(). Modify the given program to output "foobar" n times.
    /// Example 1:
    ///     Input: n = 1
    ///     Output: "foobar"
    ///     Explanation: There are two threads being fired asynchronously.One of them calls foo(), while the other calls bar(). "foobar" is being output 1 time.
    /// 
    /// Example 2:
    ///     Input: n = 2
    ///     Output: "foobarfoobar"
    ///     Explanation: "foobar" is being output 2 times.
    /// </summary>
    [RelatedTopic(Topic.Concurrency)]
    public class PrintFooBarAlternately : Question
    {
        public class FooBar
        {

            private readonly int n;
            private bool fooBarDisplaySwitch = true;
            private bool fooDisplayFlag = true;

            public FooBar(int n)
            {
                this.n = n;
            }

            public void Foo(Action printFoo)
            {
                if (fooDisplayFlag)
                {
                    fooDisplayFlag = false;
                    for (int i = 0; i < n; i++)
                    {
                        while (!fooBarDisplaySwitch)
                        {
                            Thread.Sleep(1);
                        }
                        // printFoo() outputs "foo". Do not change or remove this line.
                        printFoo();
                        fooBarDisplaySwitch = !fooBarDisplaySwitch;
                    }
                }
            }

            public void Bar(Action printBar)
            {
                while (fooDisplayFlag)
                    Thread.Sleep(1);

                for (int i = 0; i < n; i++)
                {
                    while (fooBarDisplaySwitch)
                    {
                        Thread.Sleep(1);
                    }
                    // printBar() outputs "bar". Do not change or remove this line.
                    printBar();
                    fooBarDisplaySwitch = !fooBarDisplaySwitch;
                }
            }
        }

        public override void Run()
        {
            var fooBar = new FooBar(5);
            Task.Run(() => fooBar.Bar(() => Console.Write("Bar")));
            Task.Run(() => fooBar.Foo(() => Console.Write("Foo")));
        }
    }
}
