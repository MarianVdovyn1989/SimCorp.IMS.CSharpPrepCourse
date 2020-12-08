using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Screen
{
    public class Resistive : ScreenSingleTouch
    {
        IOutput Output;
        #region Ctor
        public Resistive(int pixelHeight, int pixelWidth, double diagonalInInches, IOutput output) : base(pixelHeight, pixelWidth, diagonalInInches)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(Resistive)} screen to Mobile Phone");
        }

        public override void Show()
        {
            Output.WriteLine($"If you read this text then Show method of {nameof(IScreen)} interface works for {nameof(Resistive)} Screen\n");
        }
        #endregion
        public override string ToString()
        {
            return nameof(Resistive);
        }

        public override void Touch()
        {
            Output.WriteLine($"This touch was made on {nameof(Resistive)} screen");
            Output.WriteLine("Isn't it fantastic?\n");
        }
    }
}
