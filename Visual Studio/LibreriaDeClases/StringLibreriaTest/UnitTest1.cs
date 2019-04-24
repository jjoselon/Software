using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringLibreria;

namespace StringLibreriaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IniciaEnMayuscula()
        {

            string[] Words = {"ABC", "Jose", "Zebra"};
            foreach (var word in Words)
            {
                bool result = word.IniciaConMayuscula();
                Assert.IsTrue(result, $"Expected for {word} : true; Actual {result}");
            }
        
        }
    }
}
