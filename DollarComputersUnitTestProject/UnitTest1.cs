using System;
using COMP123_S2019_Assignment5_Tzu_An_Wang.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DollarComputersUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //private object selctForm;

        [TestMethod]
        public void TestThatSelectFormHasLoadDataSource()
        {
            //arrange
            SelectForm selectForm;
            //act
            selectForm = new SelectForm();
            //assert
            Assert.IsTrue(selectForm.HasLoadedDataSource());



        }
    }
}
