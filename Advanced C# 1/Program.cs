using System.Diagnostics.Metrics;
using Advanced_C__1.generic_class;
namespace Advanced_C__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?

            //generic class : A generic class allows you to write classes with type parameters where the actual type is specified when the code is used rather than when it is written.

            //Why use generics -->
            //type Safety: Catches type mismatches at compile time instead of runtime
            //Reusability: One implementation works for many different types
            //Better Performance: Avoids boxing and unboxing overhead for value types
            //Cleaner Code: Reduces code duplication and eliminates the need for separate classes
            #endregion

            #region Q2: Write a generic class Container<T> with Add and Get methods.
            Container<int> container = new Container<int>();
            container.Add(10);
            container.Add(20);
            Console.WriteLine(container.Get(0));
            #endregion
        }
    }
}
