using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJobC_Sharp
{
    internal class Square : BasicGeometricShape
    {
        public Square(Dictionary<int, int> dMyparams) : base(dMyparams)
        {
        }
        public override double CalculatingAreaAf_A_Figure()
        {            
            if (checkingDataDictionaryParams())
            {
                dArea = dMyParams[1] * dMyParams[2];
            }
            else
            {
                throw new NotImplementedException();
            }
            return dArea;            
        }
        public override string ToString()
        {         
            return "квадрат";           
        }
    }
}
