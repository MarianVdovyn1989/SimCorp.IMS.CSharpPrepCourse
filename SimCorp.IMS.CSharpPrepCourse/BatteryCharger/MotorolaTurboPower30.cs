using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.BatteryCharger
{
    public class MotorolaTurboPower30 : BatteryChargerBase
    {
        public MotorolaTurboPower30(bool inductiveCharge, _ChargingTechnology chargingTechnology) : base(inductiveCharge, chargingTechnology)
        {

        }
        public override string ToString()
        {
            return nameof(MotorolaTurboPower30);
        }
    }
}
