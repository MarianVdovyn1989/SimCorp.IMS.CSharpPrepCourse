using System;

namespace SimCorp.IMS.CSharpPrepCourse.BL
{
    public static class SMSDateTimeTrimmer
    {
        public static DateTime Trim(this DateTime date, long ticks)
        {
            return new DateTime(date.Ticks - (date.Ticks % ticks), date.Kind);
        }
    }
}
