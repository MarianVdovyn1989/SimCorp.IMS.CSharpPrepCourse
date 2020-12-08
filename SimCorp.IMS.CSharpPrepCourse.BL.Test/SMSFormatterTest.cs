using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Test
{
    [TestClass]
    public class SMSFormatterTest
    {
        DateTime FakeDateTime;
        [TestInitialize]
        public void TestClass()
        {
            FakeDateTime = new DateTime(2020, 12, 2, 18, 36, 00);
        }

        [TestMethod]
        public void FormatEndWithDateTime()
        {
            //Arrenge
            string expected = $"Test message received {FakeDateTime}";
            //Act
            var actual = SMSFormatHandler.FormatEndWithDateTime(new List<SMS> { new SMS { Text = "Test message received",TimeReceived=FakeDateTime } });
            //Assert
            Assert.AreEqual(expected, actual[0].Text);

        }
        [TestMethod]
        public void FormatStartWithDateTime()
        {
            //Arrenge
            string expected = $"{FakeDateTime}: Test message received";
            //Act
            var actual = SMSFormatHandler.FormatStartWithDateTime(new List<SMS> { new SMS { Text = "Test message received",TimeReceived= FakeDateTime } });
            //Assert
            Assert.AreEqual(expected, actual[0].Text);

        }
        [TestMethod]
        public void FormatNone()
        {
            //Arrenge
            string expected = $"Test message received";
            //Act
            var actual = SMSFormatHandler.FormatNone(new List<SMS> { new SMS { Text = "Test message received" } });
            //Assert
            Assert.AreEqual(expected, actual[0].Text);

        }
        [TestMethod]
        public void FormatToLowerCase()
        {
            //Arrenge
            string expected = $"test message received";
            //Act
            var actual = SMSFormatHandler.FormatToLowerCase(new List<SMS> { new SMS { Text = "Test message received" } });
            //Assert
            Assert.AreEqual(expected, actual[0].Text);

        }
        [TestMethod]
        public void FormatToUpperCase()
        {
            //Arrenge
            string expected = $"TEST MESSAGE RECEIVED";
            //Act
            var actual = SMSFormatHandler.FormatToUpperCase(new List<SMS> { new SMS { Text = "Test message received" } });
            //Assert
            Assert.AreEqual(expected, actual[0].Text);

        }
        [TestMethod]
        public void FormatToCustom()
        {
            //Arrenge
            string expected = $"TEst mEssagE rEcEivEd";
            //Act
            var actual = SMSFormatHandler.FormatToCustom(new List<SMS> { new SMS { Text = "Test message received" } });
            //Assert
            Assert.AreEqual(expected, actual[0].Text);

        }
    }
}
