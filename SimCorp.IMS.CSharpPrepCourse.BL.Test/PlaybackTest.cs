using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using SimCorp.IMS.CSharpPrepCourse.BL.Playback;
using System;
using System.Collections.Generic;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Test
{
    [TestClass]
    public class PlaybackTest
    {
        private class FakeOutput : IOutput
        {
            private string Text;
            public void WriteLine(string text)
            {
                Text=text;
            }
            public string GetOutputAsText()
            {
                return Text;
            }

        }
        private class FakeExceptions : ArgumentOutOfRangeException
        {
            
        }
        [TestMethod]
        public void Play_AirPods()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = "Do you hear this test sound? Me too\n";
            //Act
            AirPods airPods = new AirPods(volume:75, fakeOutput);
            airPods.Play("Do you hear this test sound? Me too\n");
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Play_AirPodsPro()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = "Do you hear this test sound? Me too\n";
            //Act
            var airPodsPro = new AirPodsPro(volume: 75, fakeOutput);
            airPodsPro.Play("Do you hear this test sound? Me too");
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Play_GalaxyBuds()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = "Do you hear this test sound? Me too\n";
            //Act
            var galaxyBuds = new GalaxyBuds(volume: 75, fakeOutput);
            galaxyBuds.Play("Do you hear this test sound? Me too");
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Play_GalaxyBudsLive()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = "Do you hear this test sound? Me too\n";
            //Act
            var galaxyBudsLive = new GalaxyBudsLive(volume: 75, fakeOutput);
            galaxyBudsLive.Play("Do you hear this test sound? Me too");
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Play_HomePod()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = "Do you hear this test sound? Me too\n";
            //Act
            var homePod = new HomePod(volume: 75, fakeOutput);
            homePod.Play("Do you hear this test sound? Me too");
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Play_NoNameHeadSet()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = "Do you hear this test sound? Me too\n";
            //Act
            var noNameHeadSet = new NoNameHeadSet(volume: 75, fakeOutput);
            noNameHeadSet.Play("Do you hear this test sound? Me too");
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Play_PhoneSpeaker()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = "Do you hear this test sound? Me too\n";
            //Act
            var phoneSpeaker = new PhoneSpeaker(volume: 75, fakeOutput);
            phoneSpeaker.Play("Do you hear this test sound? Me too");
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void PlaybackBase_Volume_MoreThan100ErrorMessage()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            //Act
            var actual = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new AirPods(volume: 101, fakeOutput));
            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new AirPods(volume: 101, fakeOutput));
            Assert.AreEqual("Value should be from 0 to 100\r\nParameter name: 0", actual.Message);
        }
        [TestMethod]
        public void PlaybackBase_Volume_LessThan0ErrorMessage()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            //Act
            var actual = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new AirPods(volume: -1, fakeOutput));
            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> new AirPods(volume: -1, fakeOutput));
            Assert.AreEqual("Value should be from 0 to 100\r\nParameter name: 0", actual.Message);
        }
    }
}
