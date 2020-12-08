using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Playback
{
    public class NoNameHeadSet : PlaybackBase
    {
        private IOutput Output;
        public NoNameHeadSet(int volume, IOutput output ) : base(volume)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(NoNameHeadSet)} to Mobile Phone");
        }
        public override void Play(string text)
        {
            Output.WriteLine(text + "\n");
        }
        public override string ToString()
        {
            return nameof(NoNameHeadSet);
        }
    }
}
