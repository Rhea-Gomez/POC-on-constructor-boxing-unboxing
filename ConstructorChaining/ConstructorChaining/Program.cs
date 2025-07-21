namespace ConstructorChaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- Chaining with Single Class --------");
            SingleClass singleClass = new SingleClass();
            SingleClass singleClass1 = new SingleClass(100);
        }
    }

    public class SingleClass
    {
        //Default Constructor
        //this is used for Constructor Chaining
        //Constructor 1
        public SingleClass(int num) : this("s")
        {
            Console.WriteLine("In Constructor1");
        }

        public SingleClass() : this(10)
        {
            Console.WriteLine("In Default Constructor");
        }

        //Constructor 2
        public SingleClass(string str)
        {
            Console.WriteLine("In Constructor 2");
        }
    }
}
