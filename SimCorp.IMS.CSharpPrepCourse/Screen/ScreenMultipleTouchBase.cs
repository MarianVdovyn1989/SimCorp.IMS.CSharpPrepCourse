using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public abstract class ScreenMultipleTouchBase:ScreenTouchBase
    {
        #region Ctor
        public ScreenMultipleTouchBase(int pixelHeight, int pixelWidth, double diagonalInInches, int numberOfMultipleTouches) : base(pixelHeight, pixelWidth, diagonalInInches)
        {
            NumberOfMultipleTouches = numberOfMultipleTouches;
        }
        #endregion
        public int NumberOfMultipleTouches { get; set; }
    }
}
