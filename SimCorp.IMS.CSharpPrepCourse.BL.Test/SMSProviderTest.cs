using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Test
{
	[TestClass]
    public class SMSProviderTest
    {
        public class FakeSMSProvider : SMSProvider
        {
            private string _myProperty;

            public string MyProperty
            {
                set
                {
                    if (_myProperty != value)
                    {
                        _myProperty = value;
                        OnSMSReceived(new SMS { Text="message: SMS event is raised" });
                    }
                }
            }
        }

        [TestMethod]
        public void TestThatEventIsRaised()
        {
            //Arrenge
            List<SMS> actualEvents = new List<SMS>();
            FakeSMSProvider smsProvider = new FakeSMSProvider();
            //Assign Anonymous Event Handler
            SMSProvider.SMSReceived += (SMS message) =>
                actualEvents.Add(message);
            //Act
            smsProvider.MyProperty = "SMS Event Invoked";
            //Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsNotNull(actualEvents[0].ToString());
            Assert.AreEqual("message: SMS event is raised", actualEvents[0].Text);
        }
    }
}
