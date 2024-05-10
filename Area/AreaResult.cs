using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    public class AreaResult
    {
        public bool Success { get; set; }
        public double AreaValue {get; set; }
        public string Error {  get; set; }=string.Empty;
    }
}
