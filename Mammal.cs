using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    internal class Mammal : Animal
    {
        public override string ToString()
        {
            return base.ToString() + "\nI'm mammal";
        }

    }
}
