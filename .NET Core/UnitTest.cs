// Cree siempre inicialmente una prueba que resulte fallida para comprobar la lógica de la prueba. 
// Después de confirmar que la prueba falla, ajuste la aserción para permitir que se supere la prueba.

using Microsoft.VisualStudio.TestTools.UnitTesting; // Namespace para pruebas unitarias

namespace StringLibreriaTest
{
    /*
    Cada Método dentro de la clase marcado con al atributo [TestMethod] se ejecuta automaticamente cuando se ejecute la prueba unitaria
    si la clase tiene el atributo [TestClass]
    */
    [TestClass]
    public class UnitTest1
    {
        /*
        Se define como un método de prueba cuando tiene el atributo [TestMethod]
        */
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}

/*

`Microsoft.VisualStudio.TestTools.UnitTesting`
Métodos de la clase `Assert`
1. `AreEqual`
2. `AreSame`
3. `IsFalse`
4. `IsNotNull`
*/
