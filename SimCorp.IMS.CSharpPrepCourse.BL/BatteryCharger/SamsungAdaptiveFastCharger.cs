using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.BatteryCharger
{
    public class SamsungAdaptiveFastCharger : BatteryChargerBase
    {
        IOutput Output;
        public SamsungAdaptiveFastCharger(bool inductiveCharge, _ChargingTechnology chargingTechnology, IOutput output) : base(inductiveCharge, chargingTechnology)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(SamsungAdaptiveFastCharger)} to Mobile Phone");
        }

        public override void Charge()
        {
            Output.WriteLine($"Battery now is charging using {nameof(SamsungAdaptiveFastCharger)}");
            Output.WriteLine("Wow, this charging speed must be illegal, right?\n");
        }
        public override string ToString()
        {
            return nameof(SamsungAdaptiveFastCharger);
        }
    }
}
