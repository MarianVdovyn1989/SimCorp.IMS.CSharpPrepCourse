using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.BatteryCharger
{
    public class MediaTekPumpExpress4_0 : BatteryChargerBase
    {
        public MediaTekPumpExpress4_0(bool inductiveCharge, _ChargingTechnology chargingTechnology) : base(inductiveCharge, chargingTechnology)
        {

        }
        public override string ToString()
        {
            return nameof(MediaTekPumpExpress4_0);
        }
    }
}
