



using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
//string name = "";
//try
//{
//    Console.Write("What is your name: ");
//    name = Console.ReadLine();
//    ComplexMethod(name);
//    DifferentMethod();
//    SimpleMethod();
//}
//catch (InvalidOperationException ex)
//{
//    Console.WriteLine("You should not be calling these methods.");
//    Console.WriteLine(ex.Message);
//}
//catch (NotImplementedException)
//{
//    Console.WriteLine("You forgot to finish your code!!!");
//}
//catch (Exception) when (name.ToLower() == "justin")
//{
//    Console.WriteLine("You used Justin's name, didn't you?");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex);
//}
//finally
//{
//    Console.WriteLine("I always run.");
//}
//static void ComplexMethod(string name)
//{
//    if (name.ToLower() == "justin")
//    {
//        throw new InsufficientMemoryException("Justin is too tall for this method.");
//    }
//    else
//    {
//        throw new ArgumentException("This person isn't Justin.");
//    }
//}

//Console.ReadLine();

//static void SimpleMethod()
//{
//    throw new InvalidOperationException("You should not be calling the SimpleMethod");
//}

//static void DifferentMethod()
//{
//    throw new NotImplementedException();
//}

MainMethod();
static void MainMethod()
{
    try
    {
        SimpleMethod();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void SimpleMethod()
{
    throw new NotImplementedException("You forgot to enter your code!!!");
}


Console.ReadLine();