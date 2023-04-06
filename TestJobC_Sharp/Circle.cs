using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJobC_Sharp
{
    public class Circle : BasicGeometricShape
    {

        internal readonly double dPi = 3.14;
        public Circle(Dictionary<int, int> dMyparams) : base(dMyparams)
        {
        }
        public override double CalculatingAreaAf_A_Figure()
        {            
                if (checkingDataDictionaryParams())
                {
                    dArea = dPi * Math.Pow(dMyParams[1], 2);
                }
                else
                {
                    throw new NotImplementedException();
                }
                return dArea;            
        }

        public override string ToString()
        {
            return "круг";          
        }
    }
}
