using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class employee
    {

        private int Id { get; set; }
        private string Name { get; set; }
        private double Salary { get; set; }
        public employee(int ID, string NAME, double SALARY)
        {
        this.Id=ID;
        this.Name=NAME;
        this.Salary=SALARY;
        }
        public void Display()
        {
            Console.WriteLine("employee Id is = " + Id);
            Console.WriteLine("employee Name is = " + Name);
            Console.WriteLine("employee Salary is = " + Salary);
        }


    }
}
