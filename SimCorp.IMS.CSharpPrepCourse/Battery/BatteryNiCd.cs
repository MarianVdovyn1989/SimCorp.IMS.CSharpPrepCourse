using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class BatteryNiCd:BatteryBase
    {
        public BatteryNiCd(int? capacity, string manufacturer) : base(capacity, manufacturer)
        {

        }

        public override string ToString()
        {
            return nameof(BatteryNiCd).ToString();
        }
    }
}
