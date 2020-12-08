using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Screen
{
    public class AcousticPulseRecognition : ScreenMultipleTouchBase
    {
        IOutput Output;
        #region Ctor
        public AcousticPulseRecognition(int pixelHeight, int pixelWidth, double diagonalInInches, int numberOfMultipleTouches, IOutput output) : base(pixelHeight, pixelWidth, diagonalInInches, numberOfMultipleTouches)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(AcousticPulseRecognition)} screen to Mobile Phone");
        }

        public override void Show()
        {
            Output.WriteLine($"If you read this text then Show method of {nameof(IScreen)} interface works for {nameof(AcousticPulseRecognition)} Screen\n");
        }

        public override string ToString()
        {
            return nameof(AcousticPulseRecognition);
        }
        #endregion
        public override void Touch()
        {
            Output.WriteLine($"This touch was made on {nameof(AcousticPulseRecognition)} screen");
            Output.WriteLine("Isn't it fantastic?\n");
        }
    }
}
