using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    public enum Designations { STAFF, MANAGER, VICEPRESIDENT}
    internal class Employee
    {
        //private attributes
        private int empId;
        private string empName;
        public static double empSalary = 30000;
        private Designations designation;

        //public properties/getters & setters
        public int EmpId {  get { return empId; } set { empId = value; } }

        public string EmpName { get { return empName; } set { empName = value; } }

        //defaut constructor
        public Employee()
        {

        }

        //parameterized constructor
        public Employee(int id, string name, Designations designation)
        {
            EmpId = id;
            EmpName = name;
            this.designation = designation;
        }

        //copy constructor
        public Employee(Employee obj)
        {
            this.empId = obj.EmpId;
            this.empName = obj.EmpName;
            this.designation = obj.designation;
        }

        //constructor overloading
        public Employee(int id, string name)
        {
            EmpId = id;
            EmpName = name;
        }

        public override string ToString()
        {
            string value = $"Id: {empId}, Name: {empName}, Salary: {empSalary}, Designation: {designation}";
            return value;
        }

        //Instance method to display the Salary Distribution
        public void SalaryDistribution()
        {
            double HRA = empSalary * 0.1;
            double allowance = 10000;
            double basicSalary = empSalary - HRA - allowance;
            Console.WriteLine($"Basic Salary: {basicSalary, 20:F3}, HRA: {HRA, 20:F2}, Allowance: {allowance, 20}");            //string formatters
            Console.WriteLine("Basic Salary: {0, -20}, HRA: {1, -20}, Allowance: {2, -20}", basicSalary, HRA, allowance);
        }

        public void SalaryDistribution(Designations designation)
        {
            double hra=0.0, allowance = 0, basicSalary;
            if(designation == Designations.MANAGER)
            {
                hra = empSalary * 0.15;
                allowance = 15000;
            }
            else if(designation == Designations.VICEPRESIDENT)
            {
               hra = empSalary * 0.2;
                allowance = 20000;
            } else
            {
                hra = empSalary * 0.1;
                allowance = 10000;
            }
            basicSalary = empSalary - hra - allowance;
            Console.WriteLine($"Basic Salary: {basicSalary}, HRA: {hra}, Allowance: {allowance}");
        }

        public static void CheckBonus(Employee obj)
        {
            //If the Designation is Designations.MANAGER, Bonus becomes 10000, else if STAFF 5000, if VICEPRESIDENT 15000
            if(obj.designation == Designations.STAFF)
            {
                Console.WriteLine($"Bonus is 5000");
            }
            else if(obj.designation == Designations.MANAGER)
            {
                Console.WriteLine($"Bonus is 10000");
            } else if(obj.designation == Designations.VICEPRESIDENT)
            {
                Console.WriteLine($"Bonus is 15000");
            }
        }



        

    }
}
