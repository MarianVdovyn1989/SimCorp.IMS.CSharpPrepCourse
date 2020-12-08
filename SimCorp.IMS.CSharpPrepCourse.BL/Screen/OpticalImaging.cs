using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Screen
{
    public class OpticalImaging : ScreenMultipleTouchBase
    {
        IOutput Output;
        #region Ctor

        public OpticalImaging(int pixelHeight, int pixelWidth, double diagonalInInches, int numberOfMultipleTouches, IOutput output) : base(pixelHeight, pixelWidth, diagonalInInches, numberOfMultipleTouches)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(OpticalImaging)} screen to Mobile Phone");
        }

        public override void Show()
        {
            Output.WriteLine($"If you read this text then Show method of {nameof(IScreen)} interface works for {nameof(OpticalImaging)} Screen\n");
        }
        #endregion

        public override string ToString()
        {
            return nameof(OpticalImaging);
        }

        public override void Touch()
        {
            Output.WriteLine($"This touch was made on {nameof(OpticalImaging)} screen");
            Output.WriteLine("Isn't it fantastic?\n");
        }
    }
}
