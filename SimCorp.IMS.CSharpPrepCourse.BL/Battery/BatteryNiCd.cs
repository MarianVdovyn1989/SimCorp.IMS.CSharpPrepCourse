using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Battery
{
    public class BatteryNiCd : BatteryBase
    {
        IOutput Output;
        public BatteryNiCd(int? capacity, string manufacturer, IOutput output) : base(capacity, manufacturer)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(BatteryNiCd)} to Mobile Phone");
        }

        public override void InstallBattery()
        {
            Output.WriteLine($"{nameof(BatteryNiCd)} now is supply power to Mobile Phone\n");
        }

        public override string ToString()
        {
            return nameof(BatteryNiCd);
        }
    }
}
