using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Screen
{
    public class ScreenNoTouch : ScreenBase
    {
        IOutput Output;
        #region Ctor
        public ScreenNoTouch(int pixelHeight, int pixelWidth, double diagonalInInches, IOutput output) : base(pixelHeight, pixelWidth, diagonalInInches)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(ScreenNoTouch)} screen to Mobile Phone");
        }

        public override void Show()
        {
            Output.WriteLine($"If you read this text then Show method of {nameof(IScreen)} interface works for {nameof(ScreenNoTouch)} Screen\n");
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
