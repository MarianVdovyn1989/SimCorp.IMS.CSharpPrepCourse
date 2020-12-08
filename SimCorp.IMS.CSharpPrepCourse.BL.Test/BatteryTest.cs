using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.CSharpPrepCourse.BL.Battery;
using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System.Collections.Generic;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Test
{
    [TestClass]
    public class BatteryTest
    {
        private class FakeOutput : IOutput
        {
            private string Text;
            public void WriteLine(string text)
            {
                Text = text;
            }
            public string GetOutputAsText()
            {
                return Text;
            }
        }
        [TestMethod]
        public void InstallBattery_BatteryLiIon()
        {

            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"BatteryLiIon now is supply power to Mobile Phone\n";
            //Act
            var batteryLiIon = new BatteryLiIon(capacity: 666, "", fakeOutput);
            batteryLiIon.InstallBattery();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());

        }
        [TestMethod]
        public void InstallBattery_BatteryLiPol()
        {

            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"BatteryLiPol now is supply power to Mobile Phone\n";
            //Act
            var batteryLiPol = new BatteryLiPol(capacity: 666, "", fakeOutput);
            batteryLiPol.InstallBattery();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());

        }
        [TestMethod]
        public void InstallBattery_BatteryNiCd()
        {

            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"BatteryNiCd now is supply power to Mobile Phone\n";
            //Act
            var batteryNiCd = new BatteryNiCd(capacity: 666, "", fakeOutput);
            batteryNiCd.InstallBattery();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());

        }
        [TestMethod]
        public void InstallBattery_BatteryNiMH()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"BatteryNiMH now is supply power to Mobile Phone\n";
            //Act
            var batteryNiMH = new BatteryNiMH(capacity: 666, "", fakeOutput);
            batteryNiMH.InstallBattery();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
    }
}
