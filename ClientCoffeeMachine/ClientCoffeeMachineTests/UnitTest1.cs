using System;
using System.Net.Sockets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientCoffeeMachine;// Assuming this is the namespace where Form1 resides

namespace ClientCoffeeMachineTests
{
    [TestClass]
    public class Form1Tests
    {
        private Form1 form;

        [TestInitialize]
        public void Setup()
        {
            form = new Form1();
        }

        [TestMethod]
        public void TestOrderButtonClicked()
        {
            // Simulate clicking order button
           form.orderBtn_Click(null, EventArgs.Empty);
        

            // Add assertions here to verify expected behavior upon order button click
            // For example:
            // Assert.AreEqual(expectedCoffeeCount, int.Parse(form.CoffeeRem.Text));
            // Assert.AreEqual(expectedWaterCount, int.Parse(form.WaterRem.Text));
            // ... etc.
        }
    }
}
