using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class SurfaceAcousticWave: ScreenMultipleTouchBase
    {
        #region Ctor
        public SurfaceAcousticWave(int pixelHeight, int pixelWidth, double diagonalInInches, int numberOfMultipleTouches) : base(pixelHeight, pixelWidth, diagonalInInches, numberOfMultipleTouches)
        {

        }
        #endregion

        public override string ToString()
        {
            return nameof(SurfaceAcousticWave);
        }

        public override void Touch(IScreenTouch touchScreen)
        {
            Console.WriteLine($"This touch was made on {nameof(SurfaceAcousticWave)} screen");
            Console.WriteLine("Isn't it fantastic?");
        }
    }
}
