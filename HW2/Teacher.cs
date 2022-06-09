using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class Teacher
    {

        private string Name { get; set; }
        private string Occupation { get; set; }
        private decimal Salary { get; set; }
        private decimal Tax { get; set; }

        public Teacher(string name, string occupation, decimal salary, decimal tax)
        {
            this.Name = name;
            this.Occupation = occupation;
            this.Salary = salary;
            this.Tax = tax;
        }
        public string WhoIAM()
        {

            var response = Name + " is a " + Occupation;
            return response;


        }
        public decimal GetTax()
        {
            return ((Salary * Tax) / 100);


        }
    }
}
