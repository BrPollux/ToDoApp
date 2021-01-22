using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToDoApp;

namespace Test
{
    [TestClass]
    public class ToDoTest 
    {
        [TestMethod]
        public void Testdeneme()
        {
            Güncelle gnc = new Güncelle();
            int x = 47;
            int result = gnc.Doldur(x);
            Assert.AreEqual(1, result);
           
        }
       
    }
}
