using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class ScreenNoTouch:ScreenBase
    {
        #region Ctor
        public ScreenNoTouch(int pixelHeight, int pixelWidth, double diagonalInInches) : base(pixelHeight, pixelWidth, diagonalInInches)
        {

        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return nameof(ScreenNoTouch);
        }
        #endregion
    }
}
