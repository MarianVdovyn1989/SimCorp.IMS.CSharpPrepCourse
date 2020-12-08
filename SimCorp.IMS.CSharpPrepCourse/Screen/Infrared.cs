using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class Infrared : ScreenMultipleTouchBase
    {
        #region Ctor
        public Infrared(int pixelHeight, int pixelWidth, double diagonalInInches, int numberOfMultipleTouches) : base(pixelHeight, pixelWidth, diagonalInInches, numberOfMultipleTouches)
        {

        }
        #endregion
        public override string ToString()
        {
            return nameof(Infrared);
        }

        public override void Touch(IScreenTouch touchScreen)
        {
            Console.WriteLine($"This touch was made on {nameof(Infrared)} screen");
            Console.WriteLine("Isn't it fantastic?");
        }
    }
}
