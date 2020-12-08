using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Screen
{
    public class Infrared : ScreenMultipleTouchBase
    {
        IOutput Output;
        #region Ctor
        public Infrared(int pixelHeight, int pixelWidth, double diagonalInInches, int numberOfMultipleTouches, IOutput  output) : base(pixelHeight, pixelWidth, diagonalInInches, numberOfMultipleTouches)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(Infrared)} screen to Mobile Phone");
        }

        public override void Show()
        {
            Output.WriteLine($"If you read this text then Show method of {nameof(IScreen)} interface works for {nameof(Infrared)} Screen\n");
        }
        #endregion
        public override string ToString()
        {
            return nameof(Infrared);
        }

        public override void Touch()
        {
            Output.WriteLine($"This touch was made on {nameof(Infrared)} screen");
            Output.WriteLine("Isn't it fantastic?\n");
        }
    }
}
