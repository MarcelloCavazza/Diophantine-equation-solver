using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diophantine_equation_solver
{
    internal interface IMDCREsults
    {
        public int R { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int Q { get; set; }
    }
}
