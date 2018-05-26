using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class TestEjemplo
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1;
            int y = 1;

            ClassLibrary1.Ejemplo aux = new ClassLibrary1.Ejemplo(x, y);
            bool comprobar = aux.metodo(x, y);
            Assert.IsTrue(comprobar);

        }
        [TestMethod]
        public void TestMethod2()
        {
            int x = 1;
            int y = 2;

            ClassLibrary1.Ejemplo aux = new ClassLibrary1.Ejemplo(x, y);
            bool comprobar = aux.metodo(x, y);
            Assert.IsFalse(comprobar);

        }
    }
}
