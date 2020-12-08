using SimCorp.IMS.CSharpPrepCourse.BL.BatteryCharger;
using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.BL.MobileComponentFactory
{
    public class ChargerFactory : FactoryBase
    {
        IOutput Output;
        public ChargerFactory(IOutput output) : base(output)
        {
            Output = output;
        }
        public override StringBuilder BuildComponentsSelector()
        {
            var OptionBuilder = new StringBuilder();
            OptionBuilder.AppendLine($"===========================================================");
            OptionBuilder.AppendLine($"1 - AppleFastCharge");
            OptionBuilder.AppendLine($"2 - HuaweiSuperCharge2_0");
            OptionBuilder.AppendLine($"3 - MediaTekPumpExpress4_0");
            OptionBuilder.AppendLine($"4 - MotorolaTurboPower30");
            OptionBuilder.AppendLine($"5 - OnePlusWarpCharge30");
            OptionBuilder.AppendLine($"6 - OppoSuperVOOC");
            OptionBuilder.AppendLine($"7 - SamsungAdaptiveFastCharger");
            OptionBuilder.AppendLine($"8 - USB2_0");
            OptionBuilder.AppendLine($"9 - USB2_0");
            OptionBuilder.AppendLine($"===========================================================");
            return OptionBuilder;
        }
        public override StringBuilder BuildHeaderSelector()
        {
            var HeaderBuilder = new StringBuilder();
            HeaderBuilder.AppendLine($"====================================================================");
            HeaderBuilder.AppendLine($"Select Battery Charger Component from the list below (specify index)");
            HeaderBuilder.AppendLine($"====================================================================");
            return HeaderBuilder;
        }

        public override FactoryOutput Create(int userInput)
        {
            FactoryOutput factoryComponent = null;
            switch (userInput)
            {
                case 1:
                    factoryComponent = new FactoryOutput(new AppleFastCharge(inductiveCharge: false, chargingTechnology: BatteryChargerBase._ChargingTechnology.Apple_FastCharge, Output));
                    break;
                case 2:
                    factoryComponent = new FactoryOutput(new HuaweiSuperCharge2_0(inductiveCharge: true, chargingTechnology: BatteryChargerBase._ChargingTechnology.Huawei_SuperCharge2_0, Output));
                    break;
                case 3:
                    factoryComponent = new FactoryOutput(new MediaTekPumpExpress4_0(inductiveCharge: false, chargingTechnology: BatteryChargerBase._ChargingTechnology.MediaTek_PumpExpress4_0, Output));
                    break;
                case 4:
                    factoryComponent = new FactoryOutput(new MotorolaTurboPower30(inductiveCharge: true, chargingTechnology: BatteryChargerBase._ChargingTechnology.Motorola_TurboPower30, Output));
                    break;
                case 5:
                    factoryComponent = new FactoryOutput(new OnePlusWarpCharge30(inductiveCharge: false, chargingTechnology: BatteryChargerBase._ChargingTechnology.OnePlus_WarpCharge30, Output));
                    break;
                case 6:
                    factoryComponent = new FactoryOutput(new OppoSuperVOOC(inductiveCharge: false, chargingTechnology: BatteryChargerBase._ChargingTechnology.Oppo_SuperVOOC, Output));
                    break;
                case 7:
                    factoryComponent = new FactoryOutput(new SamsungAdaptiveFastCharger(inductiveCharge: false, chargingTechnology: BatteryChargerBase._ChargingTechnology.Samsung_AdaptiveFastCharger, Output));
                    break;
                case 8:
                    factoryComponent = new FactoryOutput(new USB2_0(inductiveCharge: false, chargingTechnology: BatteryChargerBase._ChargingTechnology.USB2_0, Output));
                    break;
                case 9:
                    factoryComponent = new FactoryOutput(new USB3_0(inductiveCharge: false, chargingTechnology: BatteryChargerBase._ChargingTechnology.USB3_0, Output));
                    break;
            }
            return factoryComponent;
        }
    }
}
