namespace SimCorp.IMS.CSharpPrepCourse.BL.Screen
{
    public abstract class ScreenTouchBase : ScreenBase, IScreenTouch
    {
        #region Ctor
        public ScreenTouchBase() : base()
        {

        }
        public ScreenTouchBase(int pixelHeight, int pixelWidth) : base(pixelHeight, pixelWidth)
        {

        }
        public ScreenTouchBase(int pixelHeight, int pixelWidth, double diagonalInInches) : base(pixelHeight, pixelWidth, diagonalInInches)
        {

        }
        #endregion

        #region Properties
        public string Sensor { get; set; }
        public string Controller { get; set; }
        public string Driver { get; set; }
        #endregion

        #region Methods
        public abstract void Touch();
        #endregion
    }
}
