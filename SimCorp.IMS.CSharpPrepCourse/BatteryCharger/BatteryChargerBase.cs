using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public abstract class BatteryChargerBase
    {
        #region Constructors
        public BatteryChargerBase(bool inductiveCharge, _ChargingTechnology chargingTechnology)
        {
            InductiveCharge = inductiveCharge;
            ChargingTechnology = chargingTechnology;
        }
        #endregion

        #region Properties
        //public bool _SupportInductiveCharge ;
        public bool InductiveCharge;

        public enum _ChargingTechnology
        {
            USB2_0,
            USB3_0,
            Apple_FastCharge,
            Samsung_AdaptiveFastCharger,
            Oppo_SuperVOOC,
            OnePlus_WarpCharge30,
            Huawei_SuperCharge2_0,
            MediaTek_PumpExpress4_0,
            Motorola_TurboPower30
        };
        public _ChargingTechnology ChargingTechnology;


        public double MaxPower
        {
            get { return AssignMaxPower(ChargingTechnology); }
        }
        #endregion
        #region Methods

        private double AssignMaxPower(_ChargingTechnology ChargingTechnology)
        {
            switch (ChargingTechnology)
            {
                case _ChargingTechnology.USB2_0:
                    return 2.5;
                case _ChargingTechnology.USB3_0:
                    return 7.5;
                case _ChargingTechnology.Apple_FastCharge:
                    return 18;
                case _ChargingTechnology.Samsung_AdaptiveFastCharger:
                    return 15;
                case _ChargingTechnology.Oppo_SuperVOOC:
                    return 50;
                case _ChargingTechnology.OnePlus_WarpCharge30:
                    return 30;
                case _ChargingTechnology.Huawei_SuperCharge2_0:
                    return 40;
                case _ChargingTechnology.MediaTek_PumpExpress4_0:
                    return 25;
                case _ChargingTechnology.Motorola_TurboPower30:
                    return 28.5;
                default:
                    return 1;
            }
        }
        public override abstract string ToString();
        #endregion





    }
}
