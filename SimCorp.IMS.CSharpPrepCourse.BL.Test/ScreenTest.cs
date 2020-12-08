using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using SimCorp.IMS.CSharpPrepCourse.BL.Screen;
using System.Collections.Generic;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Test
{
    [TestClass]
    public class ScreenTest
    {
        private class FakeOutputTouch : IOutput
        {
            private string Text;
            private int Counter = 0;//default
            public void WriteLine(string text)
            {
                Counter++;
                if (Counter > 1)
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
        private class FakeOutputShow : IOutput
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
        public void Show_AcousticPulseRecognition()
        {
            //Arrange
            var fakeOutput = new FakeOutputShow();
            var expected = $"If you read this text then Show method of IScreen interface works for AcousticPulseRecognition Screen\n";
            //Act
            var screen = new AcousticPulseRecognition(pixelHeight: 320,pixelWidth:480,2.3,1, fakeOutput);
            screen.Show();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Show_Capacitive()
        {
            //Arrange
            FakeOutputShow fakeOutput = new FakeOutputShow();
            var expected = $"If you read this text then Show method of IScreen interface works for Capacitive Screen\n";
            //Act
            var screen = new Capacitive(pixelHeight: 320, pixelWidth: 480, 2.3, 1, fakeOutput);
            screen.Show();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Show_Infrared()
        {
            //Arrange
            FakeOutputShow fakeOutput = new FakeOutputShow();
            var expected = $"If you read this text then Show method of IScreen interface works for Infrared Screen\n";
            //Act
            var screen = new Infrared(pixelHeight: 320, pixelWidth: 480, 2.3, 1, fakeOutput);
            screen.Show();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Show_OpticalImaging()
        {
            //Arrange
            FakeOutputShow fakeOutput = new FakeOutputShow();
            var expected = $"If you read this text then Show method of IScreen interface works for OpticalImaging Screen\n";
            //Act
            var screen = new OpticalImaging(pixelHeight: 320, pixelWidth: 480, 2.3, 1, fakeOutput);
            screen.Show();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Show_Resistive()
        {
            //Arrange
            FakeOutputShow fakeOutput = new FakeOutputShow();
            var expected = $"If you read this text then Show method of IScreen interface works for Resistive Screen\n";
            //Act
            var screen = new Resistive(pixelHeight: 320, pixelWidth: 480, 2.3, fakeOutput);
            screen.Show();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Show_ScreenNoTouch()
        {
            //Arrange
            FakeOutputShow fakeOutput = new FakeOutputShow();
            var expected = $"If you read this text then Show method of IScreen interface works for ScreenNoTouch Screen\n";
            //Act
            var screen = new ScreenNoTouch(pixelHeight: 320, pixelWidth: 480, 2.3, fakeOutput);
            screen.Show();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Show_SurfaceAcousticWave()
        {
            //Arrange
            FakeOutputShow fakeOutput = new FakeOutputShow();
            var expected = $"If you read this text then Show method of IScreen interface works for SurfaceAcousticWave Screen\n";
            //Act
            var screen = new SurfaceAcousticWave(pixelHeight: 320, pixelWidth: 480, 2.3,5, fakeOutput);
            screen.Show();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Touch_AcousticPulseRecognition()
        {
            //Arrange
            FakeOutputTouch fakeOutput = new FakeOutputTouch();
            var expected = $"This touch was made on AcousticPulseRecognition screen\nIsn't it fantastic?\n\n";
            //Act
            var screen = new AcousticPulseRecognition(pixelHeight: 320, pixelWidth: 480, 2.3, 1, fakeOutput);
            screen.Touch();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Touch_Capacitive()
        {
            //Arrange
            FakeOutputTouch fakeOutput = new FakeOutputTouch();
            var expected = $"This touch was made on Capacitive screen\nIsn't it fantastic?\n\n";
            //Act
            var screen = new Capacitive(pixelHeight: 320, pixelWidth: 480, 2.3, 1, fakeOutput);
            screen.Touch();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Touch_Infrared()
        {
            //Arrange
            FakeOutputTouch fakeOutput = new FakeOutputTouch();
            var expected = $"This touch was made on Infrared screen\nIsn't it fantastic?\n\n";
            //Act
            var screen = new Infrared(pixelHeight: 320, pixelWidth: 480, 2.3, 1, fakeOutput);
            screen.Touch();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Touch_OpticalImaging()
        {
            //Arrange
            FakeOutputTouch fakeOutput = new FakeOutputTouch();
            var expected = $"This touch was made on OpticalImaging screen\nIsn't it fantastic?\n\n";
            //Act
            var screen = new OpticalImaging(pixelHeight: 320, pixelWidth: 480, 2.3, 1, fakeOutput);
            screen.Touch();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Touch_Resistive()
        {
            //Arrange
            FakeOutputTouch fakeOutput = new FakeOutputTouch();
            var expected = $"This touch was made on Resistive screen\nIsn't it fantastic?\n\n";
            //Act
            var screen = new Resistive(pixelHeight: 320, pixelWidth: 480, 2.3, fakeOutput);
            screen.Touch();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
        [TestMethod]
        public void Touch_SurfaceAcousticWave()
        {
            //Arrange
            FakeOutputTouch fakeOutput = new FakeOutputTouch();
            var expected = $"This touch was made on SurfaceAcousticWave screen\nIsn't it fantastic?\n\n";
            //Act
            var screen = new SurfaceAcousticWave(pixelHeight: 320, pixelWidth: 480, 2.3, 5, fakeOutput);
            screen.Touch();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetOutputAsText());
        }
    }
}
