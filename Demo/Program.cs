namespace DEMO
{
      public class Addition
    {
        static void Main(string[] args)
        {
            int Value1, Value2;
            Console.WriteLine("please enter the Value1");
            Value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the Value2");
            Value2 = Convert.ToInt32(Console.ReadLine());
            int Result;
            Result = Value1 + Value2;
            Console.WriteLine("Sum of two Values:" + Result.ToString());
            Console.ReadLine();
        }

    }
}