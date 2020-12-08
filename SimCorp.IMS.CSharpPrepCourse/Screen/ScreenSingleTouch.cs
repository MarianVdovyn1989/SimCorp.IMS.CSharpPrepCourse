using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public abstract class ScreenSingleTouch:ScreenTouchBase
    {
        #region Ctor
        public ScreenSingleTouch() : base()
        {

        }
        public ScreenSingleTouch(int pixelHeight, int pixelWidth) : base(pixelHeight, pixelWidth)
        {

        }
        public ScreenSingleTouch(int pixelHeight, int pixelWidth, double diagonalInInches) : base(pixelHeight, pixelWidth, diagonalInInches)
        {

        }
        #endregion
    }
}
