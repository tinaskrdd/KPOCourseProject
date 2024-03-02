using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientCoffeeMachine;

namespace ClientCoffeeMachine.Tests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void TestOrderButton_Click()
        {
            // Arrange
            Form1 form = new Form1();

            // Act
            // Simulate clicking the order button
            form.orderBtn_Click(null, EventArgs.Empty);

            // Assert
            // Add your assertions here to verify the expected behavior
            // For instance, you might check if certain text boxes are updated correctly
            // Or if expected messages are shown

            // Example:
            // Assert.AreEqual(expectedCoffeeValue, int.Parse(form.CoffeeRem.Text));
            // Assert.AreEqual(expectedWaterValue, int.Parse(form.WaterRem.Text));
            // Assert.AreEqual(expectedMilkValue, int.Parse(form.MilkRem.Text));
            // Assert.AreEqual(expectedSugarValue, int.Parse(form.SugarRem.Text));
        }

        [TestMethod]
        public void TestUpdateServer()
        {  
            // Arrange
            Form1 form = new Form1();
            Coffee coffee = new Coffee(); // Create a Coffee object for testing

            // Act
            form.updateServer(coffee);

            // Assert
            // Add assertions to check if the server is updated correctly
            // This might involve checking if certain UDP messages are sent and received as expected
        }

        // Add more test methods for other functionalities as needed...
    }
}
