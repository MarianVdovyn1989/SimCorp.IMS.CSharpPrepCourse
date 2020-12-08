using System;

namespace SimCorp.IMS.CSharpPrepCourse.BL
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone simCorpMobile = SimCorpMobile.Instance;
            //Console.WriteLine(simCorpMobile.GetMobileComponentsDescription());

            //simCorpMobile.ScreenTouchComp.Touch(simCorpMobile.ScreenTouchComp);
            //simCorpMobile.Play(simCorpMobile.PlaybackComp);
            //simCorpMobile.Charge(simCorpMobile.BatteryChargerComp);

            Console.ReadLine();
        }
    }
}
