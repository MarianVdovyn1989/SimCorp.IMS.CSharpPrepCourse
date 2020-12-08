using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class Capacitive : ScreenMultipleTouchBase
    {
        
        #region Ctor
        public Capacitive(int pixelHeight, int pixelWidth, double diagonalInInches, int numberOfMultipleTouches) : base(pixelHeight, pixelWidth, diagonalInInches, numberOfMultipleTouches)
        {

        }

        public override string ToString()
        {
            return nameof(Capacitive);
        }
        #endregion
        public override void Touch(IScreenTouch touchScreen)
        {
            Console.WriteLine($"This touch was made on {nameof(Capacitive)} screen");
            Console.WriteLine("Isn't it fantastic?");
        }
    }
}
