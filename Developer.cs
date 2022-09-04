using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Developer : IEmployee
    {
        public Developer()
        {
            Logger.Log("Developer Created");
        }
        public void DoWork()
        {
            throw new NotImplementedException();
        }
    }
}
