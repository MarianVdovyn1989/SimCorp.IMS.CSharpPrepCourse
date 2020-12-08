using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class BatteryLiPol : BatteryBase
    {
        public BatteryLiPol(int? capacity, string manufacturer) : base(capacity, manufacturer)
        {

        }

        public override string ToString()
        {
            return nameof(BatteryLiPol).ToString();
        }
    }
}
