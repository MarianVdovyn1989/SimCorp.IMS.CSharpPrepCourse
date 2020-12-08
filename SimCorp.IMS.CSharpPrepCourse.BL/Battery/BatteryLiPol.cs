using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Battery
{
    public class BatteryLiPol : BatteryBase
    {
        private IOutput Output;
        public BatteryLiPol(int? capacity, string manufacturer, IOutput output) : base(capacity, manufacturer)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(BatteryLiPol)} to Mobile Phone");
        }

        public override void InstallBattery()
        {
            Output.WriteLine($"{nameof(BatteryLiPol)} now is supply power to Mobile Phone\n");
        }

        public override string ToString()
        {
            return nameof(BatteryLiPol);
        }
    }
}
