using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Battery
{
    public class BatteryLiIon : BatteryBase
    {
        private IOutput Output;
        public BatteryLiIon(int? capacity, string manufacturer, IOutput output) : base(capacity, manufacturer)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(BatteryLiIon)} to Mobile Phone");
        }

        public override void InstallBattery()
        {
            Output.WriteLine($"{nameof(BatteryLiIon)} now is supply power to Mobile Phone\n");
        }

        public override string ToString()
        {
            return nameof(BatteryLiIon);
        }
    }
}
