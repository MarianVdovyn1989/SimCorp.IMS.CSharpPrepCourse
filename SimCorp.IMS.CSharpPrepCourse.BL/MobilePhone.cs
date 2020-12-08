using SimCorp.IMS.CSharpPrepCourse.BL.Battery;
using SimCorp.IMS.CSharpPrepCourse.BL.BatteryCharger;
using SimCorp.IMS.CSharpPrepCourse.BL.Playback;
using SimCorp.IMS.CSharpPrepCourse.BL.Screen;

namespace SimCorp.IMS.CSharpPrepCourse.BL
{
    public abstract class MobilePhone
    {
        #region Properties
        public IBattery Battery { get; set; }
        public IPlayback Playback { get; set; }
        public IScreenTouch TouchScreen { get; set; }
        public IScreen DisplayScreen { get; set; }
        public ICharger Charger { get; set; }
        public SMSStorage smsModule { get; set; }
        #endregion

        #region Methods
        public void Touch()
        {
            TouchScreen?.Touch();
        }
        public void Play()
        {
            Playback.Play("Do you hear this sound? Me too");
        }
        public void Charge()
        {
            Charger.Charge();
        }

        public void Install()
        {
            Battery.InstallBattery();
        }

        public void Show()
        {
            DisplayScreen.Show();
        }
        #endregion

    }
}
