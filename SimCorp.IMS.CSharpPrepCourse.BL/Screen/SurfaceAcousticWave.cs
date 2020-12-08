using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Screen
{
    public class SurfaceAcousticWave : ScreenMultipleTouchBase
    {
        IOutput Output;
        #region Ctor
        public SurfaceAcousticWave(int pixelHeight, int pixelWidth, double diagonalInInches, int numberOfMultipleTouches, IOutput output) : base(pixelHeight, pixelWidth, diagonalInInches, numberOfMultipleTouches)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(SurfaceAcousticWave)} screen to Mobile Phone");
        }

        public override void Show()
        {
            Output.WriteLine($"If you read this text then Show method of {nameof(IScreen)} interface works for {nameof(SurfaceAcousticWave)} Screen\n");
        }
        #endregion

        public override string ToString()
        {
            return nameof(SurfaceAcousticWave);
        }

        public override void Touch()
        {
            Output.WriteLine($"This touch was made on {nameof(SurfaceAcousticWave)} screen");
            Output.WriteLine("Isn't it fantastic?\n");
        }
    }
}
