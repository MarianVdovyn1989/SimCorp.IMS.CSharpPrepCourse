using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class BatteryNiMH : BatteryBase
    {
        public BatteryNiMH(int? capacity, string manufacturer) : base(capacity, manufacturer)
        {

        }

        public override string ToString()
        {
            return nameof(BatteryNiMH).ToString();
        }
    }
}
