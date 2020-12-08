using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.BatteryCharger
{
    public class OnePlusWarpCharge30 : BatteryChargerBase
    {
        public OnePlusWarpCharge30(bool inductiveCharge, _ChargingTechnology chargingTechnology) : base(inductiveCharge, chargingTechnology)
        {

        }
        public override string ToString()
        {
            return nameof(OnePlusWarpCharge30);
        }
    }
}
