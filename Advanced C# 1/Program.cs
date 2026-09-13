using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
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

            #region Q3:What are multiple type parameters? Write Pair<TKey,TValue >.
            // multiple type parameters : Multiple type parameters allow a generic class or structure to accept more than one type parameter to manage key-value relationships or mappings
            //Pair<string, int> pair = new Pair<string, int>("Age", 25);
            //Console.WriteLine(pair.ToString());

            #endregion

            #region Q4: What is a generic method? Write Swap<T> method.
            //generic method -> A generic method is a method that is defined with type parameters, allowing it to operate
            //on different data types while maintaining type safety. The actual type is specified when
            //the method is called, rather than when it is defined.

            //Public static void Swap<T>(ref T a, ref T b)
            //{
            //    T temp = a;
            //    a = b;
            //    b = temp;
            //}

            #endregion

            #region Q5: Write a generic method FindMax<T> that finds maximum value
            //public static T FindMax<T>(T[] array) where T :IComparable<T>
            // {
            //    if (array == null || array.Length == 0)
            //        throw new ArgumentException("Array cannot be null or empty");

            //    T max = array[0];
            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        if (array[i].CompareTo(max) > 0) //يعني التاني اكبر
            //            max = array[i];
            //    }
            //    return max;
            //}
            #endregion

            #region Q6: What is a generic interface? Write IRepository<T>
            //generic interface:A generic interface is an interface defined with type parameters. Any class implementing it must specify the concrete type arguments
            //    Public interface IRepository<T>
            //{
            //    void Add(T item);
            //    T Get(int index);
            //    List<T> GetAll();
            //    T Remove(int index);
            //}

            #endregion


            #region Q7: What is the 'struct' constraint? Write an example.

            //The struct constraint -> (`where T : struct`) restricts type arguments to value types only (int,double,decimal,datetime,structs,bool,Nullable)
            //excluding reference types,( strings, class types arrays interfaces,delegate).

            //public class MaxValue<T> where T : struct
            //{
            //    public T Value { get; set; }
            //}
            #endregion

            #region Q8: What is the 'class' constraint? Write an example.

            //The class constraint -> (`where T : class`) restricts type arguments to reference types only (strings, class types, arrays, interfaces, delegate).
            //It ensures that the type parameter is a reference type.

            //class Test<T> where T : class
            //{
            //    public T Data;
            //}

            //Test<string> x = new Test<string>(); // Valid
            //Test<int> x = new Test<int>(); // Error
            #endregion

            #region Q9: What is the 'new()' constraint? Write an example.

            //The new() constraint -> (The `new()` constraint (`where T : new()`) requires that the type argument has a public parameterless constructor, which allows new instances of `T` to be instantiated inside the generic type using `new T()`

            //  public class Factory<T> where T : new()
            //{
            //    public T Create()
            //    {
            //        return new T();
            //    }
            //}

            #endregion
    }

    }
}
