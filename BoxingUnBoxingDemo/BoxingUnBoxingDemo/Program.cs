namespace BoxingUnBoxingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boxing
            int num = 42;
            object boxedNum = num;

            //un-boxing
            int unboxedNum = (int)boxedNum;

            Console.WriteLine("Boxed Integer: " + boxedNum);
            Console.WriteLine("Unboxed Integer: " + unboxedNum);
        }
    }
}
