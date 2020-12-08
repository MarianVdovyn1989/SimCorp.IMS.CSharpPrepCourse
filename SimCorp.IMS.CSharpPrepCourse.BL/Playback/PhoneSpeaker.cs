using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Playback
{
    public class PhoneSpeaker : PlaybackBase
    {
        private IOutput Output;
        public PhoneSpeaker(int volume,IOutput output) : base(volume)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(PhoneSpeaker)} to Mobile Phone");
        }

        public override void Play(string text)
        {
            Output.WriteLine(text + "\n");
        }
        public override string ToString()
        {
            return nameof(PhoneSpeaker);
        }
    }
}
