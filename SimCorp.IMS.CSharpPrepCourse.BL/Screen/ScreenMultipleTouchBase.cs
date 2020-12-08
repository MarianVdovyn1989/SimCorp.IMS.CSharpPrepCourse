namespace SimCorp.IMS.CSharpPrepCourse.BL.Screen
{
    public abstract class ScreenMultipleTouchBase : ScreenTouchBase
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
