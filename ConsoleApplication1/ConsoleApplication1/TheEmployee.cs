using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class TheEmployee
    {
        private int _ID;
        private string _fisrtName;
        private string _lastName;
        private int _salary;

        public TheEmployee(int id, string fisrtName, string lastName, int salary )
        {
            _ID = id;
            _fisrtName = fisrtName;
            _lastName = lastName;
            _salary = salary;
        }
        public int getID()
        {
            return _ID;
        }

        public string getName()
        {
            return _lastName + " " + _fisrtName;
        }

        public int getSalary()
        {
            return _salary;
        }

        public void setSalary(int salary)
        {
            _salary = salary;
        }

        public int getAnnualSalary()
        {
            return _salary * 12;
        }

        public int raiseSalary(int percent)
        {
            return (_salary * percent) / 100;
        }

        public string toString()
        {
            return "Employee[id=" + _ID + ",las]";
        }
    }
}
