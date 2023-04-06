using TestJobC_Sharp;

namespace UnitTest_TestJobC_Sharp
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// ��������� ���������� ������� ������������
        /// ��������� �����������
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CalculationOfTheAreaOfGeometricShapes calculationOfTheAreaOfGeometricShapes = new CalculationOfTheAreaOfGeometricShapes(new Dictionary<int, int>(){ [1] = 4, [2] = 5, [3] = 6 });
            string sShapeType = string.Empty;
            double dArea = 6.48074069840786;
            //Act
            double dAreaTriangle = calculationOfTheAreaOfGeometricShapes.CalculatingAreaAf_A_Figure(out sShapeType);            
            //Assert
            Assert.AreEqual(dArea, dAreaTriangle);
            Assert.AreEqual("�����������",sShapeType);
        }

        ///// <summary>
        ///// ��������� ���������� ������� ������������
        ///// ��������� ������������� �����������
        ///// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            CalculationOfTheAreaOfGeometricShapes calculationOfTheAreaOfGeometricShapes = new CalculationOfTheAreaOfGeometricShapes(new Dictionary<int, int>() { [1] = 3, [2] = 4, [3] = 5 });
            string sShapeType = string.Empty;
            double dArea = 6;
            //Act
            double dAreaTriangle = calculationOfTheAreaOfGeometricShapes.CalculatingAreaAf_A_Figure(out sShapeType);
            //Assert
            Assert.AreEqual(dArea, dAreaTriangle);
            Assert.AreEqual("������������� �����������", sShapeType);
        }

        ///// <summary>
        ///// ��������� ������������ �������� ������
        ///// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            CalculationOfTheAreaOfGeometricShapes calculationOfTheAreaOfGeometricShapes = new CalculationOfTheAreaOfGeometricShapes(new Dictionary<int, int>() { [1] = -3, [2] = 4, [3] = 5 });
            //Act
            bool b= calculationOfTheAreaOfGeometricShapes.checkingDataDictionaryParams();
            //Assert
            Assert.AreEqual(false, b);            
        }

        /// <summary>
        /// ��������� ���������� ������� ��������       
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            CalculationOfTheAreaOfGeometricShapes calculationOfTheAreaOfGeometricShapes = new CalculationOfTheAreaOfGeometricShapes(new Dictionary<int, int>() {[1] = 5, [2] = 6 });
            string sShapeType = string.Empty;
            double dArea = 30;
            //Act
            double dAreaTriangle = calculationOfTheAreaOfGeometricShapes.CalculatingAreaAf_A_Figure(out sShapeType);
            //Assert
            Assert.AreEqual(dArea, dAreaTriangle);
            Assert.AreEqual("�������", sShapeType);
        }
        
        /// <summary>
        /// ��������� ���������� ������� �����       
        /// </summary>
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            CalculationOfTheAreaOfGeometricShapes calculationOfTheAreaOfGeometricShapes = new CalculationOfTheAreaOfGeometricShapes(new Dictionary<int, int>() { [1] = 5,});
            string sShapeType = string.Empty;
            double dArea = 78.5;
            //Act
            double dAreaTriangle = calculationOfTheAreaOfGeometricShapes.CalculatingAreaAf_A_Figure(out sShapeType);
            //Assert
            Assert.AreEqual(dArea, dAreaTriangle);
            Assert.AreEqual("����", sShapeType);
        }
    }
}