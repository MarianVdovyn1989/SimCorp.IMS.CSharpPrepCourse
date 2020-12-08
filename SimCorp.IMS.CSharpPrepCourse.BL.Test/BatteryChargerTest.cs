using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.CSharpPrepCourse.BL.BatteryCharger;
using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System.Collections.Generic;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Test
{
    [TestClass]
    public class BatteryChargerTest
    {
        private class FakeOutput : IOutput
        {
            private string Text;
            private int Counter=0;//default
            public void WriteLine(string text)
            {
                Counter++;
                if (Counter>1)
                {
                    Text += text;
                    Text += "\n";
                }
            }
            public string GetOutputAsText()
            {
                return Text;
            }
        }
        [TestMethod]
        public void Charge_AppleFastCharge()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Battery now is charging using AppleFastCharge\nWow, this charging speed must be illegal, right?\n\n";
            //Act
            var appleFastCharge = new AppleFastCharge(inductiveCharge:true,BatteryChargerBase._ChargingTechnology.Apple_FastCharge, fakeOutput);
            appleFastCharge.Charge();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Charge_HuaweiSuperCharge2_0()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Battery now is charging using HuaweiSuperCharge2_0\nWow, this charging speed must be illegal, right?\n\n";
            //Act
            var charger = new HuaweiSuperCharge2_0(inductiveCharge: true, BatteryChargerBase._ChargingTechnology.Huawei_SuperCharge2_0, fakeOutput);
            charger.Charge();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Charge_MediaTekPumpExpress4_0()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Battery now is charging using MediaTekPumpExpress4_0\nWow, this charging speed must be illegal, right?\n\n";
            //Act
            var charger = new MediaTekPumpExpress4_0(inductiveCharge: true, BatteryChargerBase._ChargingTechnology.MediaTek_PumpExpress4_0, fakeOutput);
            charger.Charge();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Charge_MotorolaTurboPower30()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Battery now is charging using MotorolaTurboPower30\nWow, this charging speed must be illegal, right?\n\n";
            //Act
            var charger = new MotorolaTurboPower30(inductiveCharge: true, BatteryChargerBase._ChargingTechnology.Motorola_TurboPower30, fakeOutput);
            charger.Charge();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Charge_OnePlusWarpCharge30()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Battery now is charging using OnePlusWarpCharge30\nWow, this charging speed must be illegal, right?\n\n";
            //Act
            var charger = new OnePlusWarpCharge30(inductiveCharge: true, BatteryChargerBase._ChargingTechnology.OnePlus_WarpCharge30, fakeOutput);
            charger.Charge();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Charge_OppoSuperVOOC()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Battery now is charging using OppoSuperVOOC\nWow, this charging speed must be illegal, right?\n\n";
            //Act
            var charger = new OppoSuperVOOC(inductiveCharge: true, BatteryChargerBase._ChargingTechnology.Oppo_SuperVOOC, fakeOutput);
            charger.Charge();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Charge_SamsungAdaptiveFastCharger()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Battery now is charging using SamsungAdaptiveFastCharger\nWow, this charging speed must be illegal, right?\n\n";
            //Act
            var charger = new SamsungAdaptiveFastCharger(inductiveCharge: true, BatteryChargerBase._ChargingTechnology.Samsung_AdaptiveFastCharger, fakeOutput);
            charger.Charge();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Charge_USB2_0()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Battery now is charging using USB2_0\nWow, this charging speed must be illegal, right?\n\n";
            //Act
            var charger = new USB2_0(inductiveCharge: true, BatteryChargerBase._ChargingTechnology.USB2_0, fakeOutput);
            charger.Charge();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Charge_USB3_0()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Battery now is charging using USB3_0\nWow, this charging speed must be illegal, right?\n\n";
            //Act
            var charger = new USB3_0(inductiveCharge: true, BatteryChargerBase._ChargingTechnology.USB3_0, fakeOutput);
            charger.Charge();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
    }
}
