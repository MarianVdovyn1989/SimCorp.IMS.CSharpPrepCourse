using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class Resistive:ScreenSingleTouch
    {
        #region Ctor
        public Resistive(int pixelHeight, int pixelWidth, double diagonalInInches) : base(pixelHeight, pixelWidth, diagonalInInches)
        {

        }
        #endregion
        public override string ToString()
        {
            return nameof(Resistive);
        }
        
        public override void Touch(IScreenTouch touchScreen)
        {
            Console.WriteLine($"This touch was made on {nameof(Resistive)} screen");
            Console.WriteLine("Isn't it fantastic?");
        }
    }
}
