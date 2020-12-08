using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class AppleFastCharge : BatteryChargerBase
    {
        public AppleFastCharge(bool inductiveCharge, _ChargingTechnology chargingTechnology):base(inductiveCharge, chargingTechnology)
        {

        }
        public override string ToString()
        {
            return nameof(AppleFastCharge);
        }
    }
}
