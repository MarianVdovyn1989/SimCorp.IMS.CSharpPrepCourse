using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.BatteryCharger
{
    public class USB2_0 : BatteryChargerBase
    {
        IOutput Output;
        public USB2_0(bool inductiveCharge, _ChargingTechnology chargingTechnology, IOutput output) : base(inductiveCharge, chargingTechnology)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(USB2_0)} to Mobile Phone");
        }

        public override void Charge()
        {
            Output.WriteLine($"Battery now is charging using {nameof(USB2_0)}");
            Output.WriteLine("Wow, this charging speed must be illegal, right?\n");
        }
        public override string ToString()
        {
            return nameof(USB2_0);
        }
    }
}
