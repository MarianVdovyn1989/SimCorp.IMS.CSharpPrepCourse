using SimCorp.IMS.CSharpPrepCourse.BL;
using SimCorp.IMS.CSharpPrepCourse.BL.Battery;
using SimCorp.IMS.CSharpPrepCourse.BL.BatteryCharger;
using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using SimCorp.IMS.CSharpPrepCourse.BL.MobileComponentFactory;
using SimCorp.IMS.CSharpPrepCourse.BL.Playback;
using SimCorp.IMS.CSharpPrepCourse.BL.Screen;
using System;
using System.Security.Cryptography.X509Certificates;

namespace SimCorp.IMS.CSharpPrepCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //LAB#2

            //Dependency Injection
            IOutput Output;
            Output = new ConsoleOutput();

            //Instantiate Factories
            var batteryFactory = new BatteryFactory(Output);
            var chargerFactory = new ChargerFactory(Output);
            var screenFactory = new ScreenFactory(Output);
            var playbackFactory = new PlaybackFactory(Output);

            MobilePhone simCorpMobile = SimCorpMobile.Instance;
            int Index;

            #region BatteryComponent
            //Ask User for an index
            Index = batteryFactory.SelectComponentIndex();
            //Create Component Class based on index
            simCorpMobile.Battery = batteryFactory.Create(Index).MobileComponent as IBattery;
            //Do something
            simCorpMobile.Install();
            #endregion

            #region ChargerComponent
            //Ask User for an index
            Index = chargerFactory.SelectComponentIndex();
            //Create Component Class based on index
            simCorpMobile.Charger = chargerFactory.Create(Index).MobileComponent as ICharger;
            //Do something
            simCorpMobile.Charge();
            #endregion

            #region ScreenComponent
            //Ask User for an index
            Index = screenFactory.SelectComponentIndex();
            //Create Component Class based on index
            simCorpMobile.DisplayScreen = screenFactory.Create(Index).MobileComponent as IScreen;
            simCorpMobile.Show();
            simCorpMobile.TouchScreen = simCorpMobile.DisplayScreen as IScreenTouch;
            simCorpMobile.Touch();
            #endregion

            #region PlaybackComponent
            //Ask User for an index
            Index = playbackFactory.SelectComponentIndex();
            //Create Component Class based on index
            simCorpMobile.Playback= playbackFactory.Create(Index).MobileComponent as IPlayback;
            simCorpMobile.Play();
            #endregion

            System.Console.ReadLine();
        }
    }
}
