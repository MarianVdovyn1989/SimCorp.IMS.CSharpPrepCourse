using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.BatteryCharger
{
    public class HuaweiSuperCharge2_0 : BatteryChargerBase
    {
        public HuaweiSuperCharge2_0(bool inductiveCharge, _ChargingTechnology chargingTechnology) : base(inductiveCharge, chargingTechnology)
        {

        }
        public override string ToString()
        {
            return nameof(HuaweiSuperCharge2_0);
        }
    }
}
