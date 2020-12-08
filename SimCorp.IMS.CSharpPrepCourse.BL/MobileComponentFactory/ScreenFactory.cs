using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using SimCorp.IMS.CSharpPrepCourse.BL.Screen;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.BL.MobileComponentFactory
{
    public class ScreenFactory : FactoryBase
    {
        IOutput Output;
        public ScreenFactory(IOutput output) : base(output)
        {
            Output = output;
        }

        public override StringBuilder BuildComponentsSelector()
        {
            var OptionBuilder = new StringBuilder();
            OptionBuilder.AppendLine($"===========================================================");
            OptionBuilder.AppendLine($"1 - Acoustic Pulse Recognition");
            OptionBuilder.AppendLine($"2 - Capacitive");
            OptionBuilder.AppendLine($"3 - Infrared");
            OptionBuilder.AppendLine($"4 - OpticalImaging");
            OptionBuilder.AppendLine($"5 - Resistive");
            OptionBuilder.AppendLine($"6 - ScreenNoTouch");
            OptionBuilder.AppendLine($"7 - SurfaceAcousticWave");
            OptionBuilder.AppendLine($"===========================================================");
            return OptionBuilder;
        }
        public override StringBuilder BuildHeaderSelector()
        {
            var HeaderBuilder = new StringBuilder();
            HeaderBuilder.AppendLine($"=============================================================");
            HeaderBuilder.AppendLine($"Select Screen Component from the list below (specify index)");
            HeaderBuilder.AppendLine($"=============================================================");
            return HeaderBuilder;
        }

        public override FactoryOutput Create(int userInput)
        {
            FactoryOutput factoryComponent = null;
            switch (userInput)
            {
                case 1:
                    factoryComponent = new FactoryOutput(new AcousticPulseRecognition(pixelHeight: 1080, pixelWidth: 1920, diagonalInInches: 6.3, numberOfMultipleTouches: 8, Output));
                    break;
                case 2:
                    factoryComponent = new FactoryOutput(new Capacitive(pixelHeight: 1080, pixelWidth: 1920, diagonalInInches: 5.9, numberOfMultipleTouches: 8, Output));
                    break;
                case 3:
                    factoryComponent = new FactoryOutput(new Infrared(pixelHeight: 1080, pixelWidth: 1920, diagonalInInches: 4.7, numberOfMultipleTouches: 8, Output));
                    break;
                case 4:
                    factoryComponent = new FactoryOutput(new OpticalImaging(pixelHeight: 1080, pixelWidth: 1920, diagonalInInches: 6.5, numberOfMultipleTouches: 8, Output));
                    break;
                case 5:
                    factoryComponent = new FactoryOutput(new Resistive(pixelHeight: 1080, pixelWidth: 1920, diagonalInInches: 5.3, Output));
                    break;
                case 6:
                    factoryComponent = new FactoryOutput(new ScreenNoTouch(pixelHeight: 1080, pixelWidth: 1920, diagonalInInches: 6.9, Output));
                    break;
                case 7:
                    factoryComponent = new FactoryOutput(new SurfaceAcousticWave(pixelHeight: 1080, pixelWidth: 1920, diagonalInInches: 6.1, numberOfMultipleTouches: 8, Output));
                    break;
            }
            return factoryComponent;
        }
    }
}
