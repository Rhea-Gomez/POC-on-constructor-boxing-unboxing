namespace ClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 101;
            string name = "Rhea";
            Designations designation = Designations.STAFF;

            //using default constructor
            Employee employee1 = new Employee();
            employee1.EmpId = id;
            employee1.EmpName = name;

            Console.WriteLine("Employee Details: ");
            Console.WriteLine(employee1.ToString());

            //using parameterized constructor
            Employee employee2 = new Employee(id, name, designation);
            Console.WriteLine("Employee details from Parameterized constructor");
            Console.WriteLine(employee2.ToString());

            //using copy constructor
            Employee employee3 = new Employee(102, "Sanjana", Designations.MANAGER);
            Employee employee4 = new Employee(employee3);
            Console.WriteLine("Employee details from copy constructor");
            Console.WriteLine(employee4.ToString());

            //using constructor overloading
            Employee employee5 = new Employee(104, "Sarah");
            Console.WriteLine("Employee details from constructor overloading");
            Console.WriteLine(employee5.ToString());

            //Salary Distribution
        //    employee4.SalaryDistribution();

        //    //check Bonus
        //    Employee.CheckBonus(employee4);
        //    Employee.CheckBonus(employee2);

        //    //Salary distribution based on designation
        //    employee4.SalaryDistribution(Designations.MANAGER);
        //    employee3.SalaryDistribution(Designations.VICEPRESIDENT);
        }
    }
}
