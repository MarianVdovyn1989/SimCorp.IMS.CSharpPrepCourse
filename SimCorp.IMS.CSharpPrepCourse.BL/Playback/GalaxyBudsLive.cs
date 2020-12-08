using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Playback
{
    public class GalaxyBudsLive : PlaybackBase
    {
        private IOutput Output;
        public GalaxyBudsLive(int volume, IOutput output) : base(volume)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(GalaxyBudsLive)} to Mobile Phone");
        }
        public override void Play(string text)
        {
            Output.WriteLine(text + "\n");
        }
        public override string ToString()
        {
            return nameof(GalaxyBudsLive);
        }
    }
}
