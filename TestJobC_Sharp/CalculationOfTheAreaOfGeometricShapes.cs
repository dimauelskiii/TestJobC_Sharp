using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJobC_Sharp
{
    public class CalculationOfTheAreaOfGeometricShapes : BasicGeometricShape
    {       
        double dS = 0;
        public CalculationOfTheAreaOfGeometricShapes(Dictionary<int, int> dMyparams) : base(dMyparams)
        {
        }
        public override double CalculatingAreaAf_A_Figure(out string sShapeType)
        {           
            switch (dMyParams.Count)
            {
                case 1:            
                    Circle circle = new Circle(dMyParams);
                    dS = circle.CalculatingAreaAf_A_Figure();
                    sShapeType = circle.ToString();
                    break;
                case 2:
                    Square square =  new Square(dMyParams);
                    dS = square.CalculatingAreaAf_A_Figure();
                    sShapeType = square.ToString();
                    break;
                case 3:
                    Triangle triangle=new Triangle (dMyParams);
                    dS = triangle.CalculatingAreaAf_A_Figure();
                    sShapeType = triangle.ToString();
                    break;
                default:
                    throw new InvalidParametersException("Неверное количество параметров");
            }
            return dS;
        }
    }
}
