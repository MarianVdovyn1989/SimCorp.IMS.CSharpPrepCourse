using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.BatteryCharger
{
    public class USB3_0 : BatteryChargerBase
    {
        IOutput Output;
        public USB3_0(bool inductiveCharge, _ChargingTechnology chargingTechnology, IOutput output) : base(inductiveCharge, chargingTechnology)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(USB3_0)} to Mobile Phone");
        }

        public override void Charge()
        {
            Output.WriteLine($"Battery now is charging using {nameof(USB3_0)}");
            Output.WriteLine("Wow, this charging speed must be illegal, right?\n");
        }
        public override string ToString()
        {
            return nameof(USB3_0);
        }
    }
}
