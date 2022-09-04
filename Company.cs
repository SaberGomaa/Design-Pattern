using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal abstract class Company
    {
        List<IEmployee> employees;

        public abstract void     CreateEmployee();

        public void CreateSoftware()
        {
            foreach (var employee in employees)
            {
                employee.DoWork();
            }
        }
    }
}
