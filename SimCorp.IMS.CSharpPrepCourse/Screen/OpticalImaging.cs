using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class OpticalImaging : ScreenMultipleTouchBase
    {
        #region Ctor

        public OpticalImaging(int pixelHeight, int pixelWidth, double diagonalInInches, int numberOfMultipleTouches) : base(pixelHeight, pixelWidth, diagonalInInches, numberOfMultipleTouches)
        {

        }
        #endregion

        public override string ToString()
        {
            return nameof(OpticalImaging);
        }

        public override void Touch(IScreenTouch touchScreen)
        {
            Console.WriteLine($"This touch was made on {nameof(OpticalImaging)} screen");
            Console.WriteLine("Isn't it fantastic?");
        }
    }
}
