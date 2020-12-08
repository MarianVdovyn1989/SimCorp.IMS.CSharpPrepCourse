using SimCorp.IMS.CSharpPrepCourse.BL.Battery;
using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.BL.MobileComponentFactory
{
    public class BatteryFactory : FactoryBase
    {
        public IOutput Output;
        public BatteryFactory(IOutput output) : base(output)
        {
            Output = output;
        }

        public override StringBuilder BuildComponentsSelector()
        {
            var OptionBuilder = new StringBuilder();
            OptionBuilder.AppendLine($"===========================================================");
            OptionBuilder.AppendLine($"1 - Lithium-Ion");
            OptionBuilder.AppendLine($"2 - Lithium-Polymer");
            OptionBuilder.AppendLine($"3 - Nickel–Cadmium");
            OptionBuilder.AppendLine($"4 - Nickel–Metal Hydride");
            OptionBuilder.AppendLine($"===========================================================");
            return OptionBuilder;
        }
        public override StringBuilder BuildHeaderSelector()
        {
            var HeaderBuilder = new StringBuilder();
            HeaderBuilder.AppendLine($"============================================================");
            HeaderBuilder.AppendLine($"Select Battery Component from the list below (specify index)");
            HeaderBuilder.AppendLine($"============================================================");
            return HeaderBuilder;
        }

        public override FactoryOutput Create(int userInput)
        {
            FactoryOutput factoryComponent = null;
            switch (userInput)
            {
                case 1:
                    factoryComponent = new FactoryOutput(new BatteryLiIon(4100, "AESC", Output));
                    break;
                case 2:
                    factoryComponent = new FactoryOutput(new BatteryLiPol(3750, "BYD", Output));
                    break;
                case 3:
                    factoryComponent = new FactoryOutput(new BatteryNiCd(4500, "LG", Output));
                    break;
                case 4:
                    factoryComponent = new FactoryOutput(new BatteryNiMH(3600, "Panasonic", Output));
                    break;
            }
            return factoryComponent;
        }
    }
}
