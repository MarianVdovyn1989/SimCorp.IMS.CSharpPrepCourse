using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Playback
{
    public class AirPods : PlaybackBase
    {
        private IOutput Output;
        public AirPods(int volume, IOutput output) : base(volume)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(AirPods)} to Mobile Phone");
        }
        public override void Play(string text)
        {
            Output.WriteLine(text);
        }
        public override string ToString()
        {
            return nameof(AirPods);
        }
    }
}
