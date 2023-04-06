

using System;

namespace TestJobC_Sharp
{
    public class Triangle : BasicGeometricShape
    {
        public Triangle(Dictionary<int, int> dMyparam) : base(dMyparam)
        {           
        }
        public override double CalculatingAreaAf_A_Figure()
        {                     
            if (checkingDataDictionaryParams())
            {
                double dP = (base.dMyParams[1] + base.dMyParams[2] + base.dMyParams[3]) / 2;
                dArea = Math.Sqrt(dP * (dP - dMyParams[1]) * (dP - base.dMyParams[2]) * (dP - dMyParams[3]));
            }
            return dArea;           
        }

        /// <summary>
        /// Метод проверяет является ли треугольник прямоугольным 
        /// В любом прямоугольном треугольнике сумма квадратов длин двух катетов равна квадрату длины гипотенузы
        /// </summary>
        public bool IsTheTriangleRightAngled() => (
            Math.Pow(base.dMyParams[1], 2) == Math.Pow(base.dMyParams[2], 2) + Math.Pow(base.dMyParams[3], 2) ||
            Math.Pow(base.dMyParams[2], 2) == Math.Pow(base.dMyParams[1], 2) + Math.Pow(base.dMyParams[3], 2) ||
            Math.Pow(base.dMyParams[3], 2) == Math.Pow(base.dMyParams[2], 2) + Math.Pow(base.dMyParams[1], 2)
            );

        public override string ToString()
        {
            if (IsTheTriangleRightAngled())
            {
                return "прямоугольный треугольник";
            }
            else
            {
                return "треугольник";
            }
        }
    }
}