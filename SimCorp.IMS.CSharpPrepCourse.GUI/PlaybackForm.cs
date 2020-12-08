using SimCorp.IMS.CSharpPrepCourse.BL;
using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using SimCorp.IMS.CSharpPrepCourse.BL.MobileComponentFactory;
using SimCorp.IMS.CSharpPrepCourse.BL.Playback;
using System;
using System.Windows.Forms;

namespace SimCorp.IMS.CSharpPrepCourse.GUI
{
    public partial class PlaybackForm : Form, IOutput
    {
        IOutput WinForm;
        public PlaybackForm()
        {
            InitializeComponent();
            WinForm = new TextBox(tbOutput);
        }

        public void WriteLine(string text)
        {
            WinForm.WriteLine(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //=======================================================================================
            //Clear textBox
            tbOutput.Clear();
            //return Selected radiobutton index
            int rbIndex = CheckSelectedRadioButton(WinForm);
            if (rbIndex!=0)
            {
                MobilePhone simCorpMobile = SimCorpMobile.Instance;
                //create class with DI
                PlaybackFactory playbackFactory = new PlaybackFactory(WinForm);
                //create component class
                simCorpMobile.Playback = playbackFactory.Create(rbIndex).MobileComponent as IPlayback;
                //show playing device in textbox
                simCorpMobile.Play();
            }
            //=======================================================================================
        }

        private int CheckSelectedRadioButton(IOutput Output)
        {
            int Index = 0;
            Exception Ex = null;
            try
            {
                Index = int.Parse(ReturnRadioButtonIndex(Output));
                return Index;
            }
            catch (Exception ex)
            {
                Ex = ex;
                //Return default value 0
                return Index;
            }
        }

        private string ReturnRadioButtonIndex(IOutput Output)
        {
            if (rbAirPods.Checked)
            {
                Output.WriteLine($"{nameof(AirPods)} was selected.\r\nSet PlayBack to {nameof(MobilePhone)}");
                return "1";
            }
            else if (rbAirPodsPro.Checked)
            {
                Output.WriteLine($"{nameof(AirPodsPro)} was selected\r\nSet Playback to {nameof(MobilePhone)}");
                return "2";
            }
            else if (rbGalaxyBuds.Checked)
            {
                Output.WriteLine($"{nameof(GalaxyBuds)} was selected\r\nSet Playback to {nameof(MobilePhone)}");
                return "3";
            }
            else if (rbGalaxyBudsLive.Checked)
            {
                Output.WriteLine($"{nameof(GalaxyBudsLive)} was selected\r\nSet Playback to {nameof(MobilePhone)}");
                return "4";
            }
            else if (rbHomePod.Checked)
            {
                Output.WriteLine($"{nameof(HomePod)} was selected\r\nSet Playback to {nameof(MobilePhone)}");
                return "5";
            }
            else if (rbNoNameHeadSet.Checked)
            {
                Output.WriteLine($"{nameof(NoNameHeadSet)} was selected\r\nSet Playback to {nameof(MobilePhone)}");
                return "6";
            }
            else if (rbPhoneSpeaker.Checked)
            {
                Output.WriteLine($"{nameof(PhoneSpeaker)} was selected\r\nSet Playback to {nameof(MobilePhone)}");
                return "7";
            }
            return "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbAirPods_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbGalaxyBuds_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAirPodsPro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbHomePod_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbGalaxyBudsLive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNoNameHeadSet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPhoneSpeaker_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
