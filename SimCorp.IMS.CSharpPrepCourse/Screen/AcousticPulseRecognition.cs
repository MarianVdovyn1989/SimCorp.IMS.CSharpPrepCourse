using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class AcousticPulseRecognition : ScreenMultipleTouchBase
    {
        #region Ctor
        public AcousticPulseRecognition(int pixelHeight, int pixelWidth, double diagonalInInches, int numberOfMultipleTouches) : base(pixelHeight, pixelWidth, diagonalInInches, numberOfMultipleTouches)
        {

        }

        public override string ToString()
        {
            return nameof(AcousticPulseRecognition);
        }
        #endregion
        public override void Touch(IScreenTouch touchScreen)
        {
            Console.WriteLine($"This touch was made on {nameof(AcousticPulseRecognition)} screen");
            Console.WriteLine("Isn't it fantastic?");
        }
    }
}
