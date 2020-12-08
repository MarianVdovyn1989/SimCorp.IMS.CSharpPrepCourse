using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using SimCorp.IMS.CSharpPrepCourse.BL.Playback;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.BL.MobileComponentFactory
{
    public class PlaybackFactory : FactoryBase
    {
        IOutput Output;
        public PlaybackFactory(IOutput output) : base(output)
        {
            Output = output;
        }
        public override StringBuilder BuildComponentsSelector()
        {
            var OptionBuilder = new StringBuilder();
            OptionBuilder.AppendLine($"===========================================================");
            OptionBuilder.AppendLine($"1 - AirPods");
            OptionBuilder.AppendLine($"2 - AirPods Pro");
            OptionBuilder.AppendLine($"3 - Galaxy Buds");
            OptionBuilder.AppendLine($"4 - Galaxy Buds Live");
            OptionBuilder.AppendLine($"5 - HomePod");
            OptionBuilder.AppendLine($"6 - NoNameHeadSet");
            OptionBuilder.AppendLine($"7 - PhoneSpeaker");
            OptionBuilder.AppendLine($"===========================================================");
            return OptionBuilder;
        }
        public override StringBuilder BuildHeaderSelector()
        {
            var HeaderBuilder = new StringBuilder();
            HeaderBuilder.AppendLine($"=============================================================");
            HeaderBuilder.AppendLine($"Select Playback Component from the list below (specify index)");
            HeaderBuilder.AppendLine($"=============================================================");
            return HeaderBuilder;
        }

        public override FactoryOutput Create(int userInput)
        {
            FactoryOutput factoryComponent = null;
            switch (userInput)
            {
                case 1:
                    factoryComponent = new FactoryOutput(new AirPods(volume: 75, Output));
                    break;
                case 2:
                    factoryComponent = new FactoryOutput(new AirPodsPro(volume: 80, Output));
                    break;
                case 3:
                    factoryComponent = new FactoryOutput(new GalaxyBuds(volume: 99, Output));
                    break;
                case 4:
                    factoryComponent = new FactoryOutput(new GalaxyBudsLive(volume: 100, Output));
                    break;
                case 5:
                    factoryComponent = new FactoryOutput(new HomePod(volume: 32, Output));
                    break;
                case 6:
                    factoryComponent = new FactoryOutput(new NoNameHeadSet(volume: 45, Output));
                    break;
                case 7:
                    factoryComponent = new FactoryOutput(new PhoneSpeaker(volume: 85, Output));
                    break;
            }
            return factoryComponent;
        }
    }
}
