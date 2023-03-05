using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diophantine_equation_solver
{
    internal class MDCResults : IMDCREsults
    {
        public MDCResults(int rValue, int aValue, int bValue, int qValue) {
            this.A = aValue;
            this.B = bValue;
            this.R = rValue;
            this.Q = qValue;
        } 
        public int R { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int Q { get; set; }
    }
}
