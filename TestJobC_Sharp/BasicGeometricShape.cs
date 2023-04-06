using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJobC_Sharp
{
    public abstract class BasicGeometricShape
    {
        /// <summary>
        /// Параметры фигуры
        /// </summary>
        public Dictionary<int, int> dMyParams { get; set; }
        /// <summary>
        /// Площадь геометрической фигуры
        /// </summary>
        public double dArea = 0;
        public BasicGeometricShape(Dictionary<int, int> dMyparams)
        {
            if (checkingDataDictionary(dMyparams))
            {
                dMyParams = dMyparams;
            }
            else
            {
                new InvalidParametersException("Парамеры фигуры не могут быть меньше 1");
            }
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="dMyParams">Dictionary c  параметрами фигуры</param>
        /// <returns></returns>
        public virtual double CalculatingAreaAf_A_Figure()
        {
            return dArea;
        }
        public virtual double CalculatingAreaAf_A_Figure(out string sShapeType)
        {
            sShapeType = string.Empty;
            return dArea;
        }
            
        /// <summary>
        /// Метод проверяющий наличие ланных в Dictionary <int, decimal> dMyParams
        /// </summary>
        /// <param name="dMyParams">Dictionary c  параметрами фигуры</param>
        /// <returns></returns>
        private bool checkingDataDictionary(Dictionary<int, int> dMyParams) => (dMyParams != null || dMyParams.Count > 0);
        /// <summary>
        /// Метод проверяющий корректность заполнения параметров в Dictionary <int, decimal> dMyParams
        /// </summary>
        /// <param name="dMyParams">Dictionary c  параметрами фигуры</param>
        /// <returns></returns>
        public bool checkingDataDictionaryParams()
        {
            bool bCheckingDataDictionaryParams = true;
            for (int i = 0; i < dMyParams.Count; i++)
            {
                if (dMyParams[i + 1] < 1)
                {
                    bCheckingDataDictionaryParams = false;                  
                }            
            }
            return bCheckingDataDictionaryParams;
        }
    }
}
