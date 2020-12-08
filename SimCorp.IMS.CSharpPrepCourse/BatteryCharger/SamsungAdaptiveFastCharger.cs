using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.BatteryCharger
{
    public class SamsungAdaptiveFastCharger : BatteryChargerBase
    {
        public SamsungAdaptiveFastCharger(bool inductiveCharge, _ChargingTechnology chargingTechnology) : base(inductiveCharge, chargingTechnology)
        {

        }
        public override string ToString()
        {
            return nameof(SamsungAdaptiveFastCharger);
        }
    }
}
