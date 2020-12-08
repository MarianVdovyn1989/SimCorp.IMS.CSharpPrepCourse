using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public abstract class MobilePhone
    {
        #region Properties
        public abstract ScreenTouchBase ScreenTouch { get;}
        public abstract BatteryChargerBase BatteryCharge { get; }
        public abstract BatteryBase BatteryBase { get; }

        #endregion

        #region Methods
        public string GetMobileComponentsDescription()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine(GetScreenDescription());
            descriptionBuilder.AppendLine(GetBatteryChargerDescription());
            descriptionBuilder.AppendLine(GetBatteryDescription());
            return descriptionBuilder.ToString();
        }

        private string GetBatteryDescription()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine("========================================");
            descriptionBuilder.AppendLine("Component: Battery");
            descriptionBuilder.AppendLine();
            descriptionBuilder.AppendLine($"Battery Type: {BatteryBase.ToString()}");
            descriptionBuilder.AppendLine($"Battery Capacity: {BatteryBase.Capacity}");
            descriptionBuilder.AppendLine($"Battery Manufacturer: {BatteryBase.Manufacturer}");
            descriptionBuilder.AppendLine("========================================");
            return descriptionBuilder.ToString();
        }

        private string GetBatteryChargerDescription()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine("========================================");
            descriptionBuilder.AppendLine("Component: Battery Charger");
            descriptionBuilder.AppendLine();
            descriptionBuilder.AppendLine($"Battery Charger Type: {BatteryCharge.ToString()}");
            descriptionBuilder.AppendLine($"Battery Charger Technology: {BatteryCharge.ChargingTechnology}");
            descriptionBuilder.AppendLine($"Battery Charger MaxPower: {BatteryCharge.MaxPower}");
            descriptionBuilder.AppendLine($"Battery Charger Inductive Charge: {BatteryCharge.InductiveCharge}");
            descriptionBuilder.AppendLine("========================================");
            return descriptionBuilder.ToString();
        }

        private string GetScreenDescription()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine("========================================");
            descriptionBuilder.AppendLine("Component: Screen");
            descriptionBuilder.AppendLine();
            descriptionBuilder.AppendLine($"Touch Screen Type: {ScreenTouch.ToString()}");
            descriptionBuilder.AppendLine($"Screen Aspect Ratio: {ScreenTouch.AspectRatio}");
            descriptionBuilder.AppendLine($"Screen Diagonal In Inches: {ScreenTouch.DiagonalInInches}");
            descriptionBuilder.AppendLine("========================================");
            return descriptionBuilder.ToString();
        }
        #endregion

    }
}
