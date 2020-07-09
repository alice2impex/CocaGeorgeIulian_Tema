using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1.Tests
{
    [TestFixture]
    public class GreetingTests
    {
        Greeting greeting = new Greeting();

        public void ExecuteTest(string name, string expected)
        {
            //Arrange

            //Act
            string result = greeting.Greet(name);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldGreetBob()
        {
            ExecuteTest("Bob", "Hello, Bob.");
        }


        [Test]
        public void ShouldGreetGigi()
        {
            ExecuteTest("Gigi", "Hello, Gigi.");
        }

        [Test]
        public void ShouldHandleNull()
        {
            ExecuteTest(null, "Hello, my friend.");
        }

        [Test]
        public void ShouldHandleShooting()
        {
            ExecuteTest("JERRY", "HELLO JERRY!");
        }

        [Test]
        public void ShouldHandleTwoNames()
        {
            ExecuteTest("Jill, Jane", "Hello, Jill and Jane.");
        }

        [Test]
        public void ShouldHandleThreeNames()
        {
            ExecuteTest("Amy,Brian,Charlotte", "Hello, Amy, Brian, and Charlotte.");
        }

        [Test]
        public void ShouldHandleFourNames()
        {
            ExecuteTest("Amy,Brian,Charlotte,Ronaldo", "Hello, Amy, Brian, Charlotte, and Ronaldo.");
        }

        [Test]
        public void ShouldHandleMixingNames()
        {
            ExecuteTest("Amy,BRIAN,Charlotte", "Hello, Amy and Charlotte. AND HELLO BRIAN!");
        }

        [Test]
        public void ShouldHandleMixingNames2()
        {
            ExecuteTest("AMY,Brian,Charlotte", "Hello, Brian and Charlotte. AND HELLO AMY!");
        }



    }
}
