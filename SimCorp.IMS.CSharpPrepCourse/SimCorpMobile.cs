using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class SimCorpMobile : MobilePhone
    {
        #region SingletonConstructor
        private SimCorpMobile()
        {
            vAPR = new AcousticPulseRecognition(pixelHeight: 1000, pixelWidth: 1500, diagonalInInches: 3.1, numberOfMultipleTouches: 8);
            vAFC = new AppleFastCharge(inductiveCharge: true, BatteryChargerBase._ChargingTechnology.Apple_FastCharge);
            vLiPol = new BatteryLiPol(capacity: 4000, manufacturer: "Toshiba");
        }
        #endregion

        #region SingletonProperties
        //Simple not thread safe Singleton
        //private static  MobilePhone instance;
        //public static MobilePhone Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new SimCorpMobile();
        //        }
        //        return instance;
        //    }
        //}

        //Thread safe Singleton that we use in SimCorp
        //more here https://csharpindepth.com/articles/singleton
        private static readonly Lazy<MobilePhone>
            lazy =
            new Lazy<MobilePhone>
            (() => new SimCorpMobile());
        public static MobilePhone Instance { get { return lazy.Value; } }
        #endregion

        #region Properties
        private readonly AcousticPulseRecognition vAPR;
        public override ScreenTouchBase ScreenTouch { get { return vAPR; } }

        private readonly AppleFastCharge vAFC;
        public override BatteryChargerBase BatteryCharge { get { return vAFC; } }

        private readonly BatteryBase vLiPol;
        public override BatteryBase BatteryBase { get { return vLiPol; } }
        #endregion





    }
}
