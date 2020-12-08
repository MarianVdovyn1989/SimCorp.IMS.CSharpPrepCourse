using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Battery
{
    public class BatteryNiMH : BatteryBase
    {
        IOutput Output;
        public BatteryNiMH(int? capacity, string manufacturer, IOutput output) : base(capacity, manufacturer)
        {
            Output=output;
            Output.WriteLine($"Setting {nameof(BatteryNiMH)} to Mobile Phone");
        }

        public override void InstallBattery()
        {
            Output.WriteLine($"{nameof(BatteryNiMH)} now is supply power to Mobile Phone\n");
        }

        public override string ToString()
        {
            return nameof(BatteryNiMH);
        }
    }
}
