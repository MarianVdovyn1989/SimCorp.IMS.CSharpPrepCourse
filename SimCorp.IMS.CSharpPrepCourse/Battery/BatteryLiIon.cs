using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class BatteryLiIon : BatteryBase
    {
        public BatteryLiIon(int? capacity, string manufacturer):base(capacity, manufacturer)
        {

        }

        public override string ToString()
        {
            return nameof(BatteryLiIon).ToString();
        }
    }
}
