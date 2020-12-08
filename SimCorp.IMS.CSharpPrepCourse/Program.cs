using System;

namespace SimCorp.IMS.CSharpPrepCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone simCorpMobile = SimCorpMobile.Instance;
            Console.WriteLine(simCorpMobile.GetMobileComponentsDescription());
            simCorpMobile.ScreenTouch.Touch(simCorpMobile.ScreenTouch);
            Console.ReadLine(); 
        }
    }
}
