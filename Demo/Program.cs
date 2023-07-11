namespace DEMO
{
     internal class Program
    {
         public static void AdditionOfTwoNUmbers()
        {
            Console.WriteLine("PLease Enter the first number");
            int firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int secondNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sum:"+(firstNumb + secondNumber));
        }
        
    }
}