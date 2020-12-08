using System;
using System.Windows.Forms;

namespace SimCorp.IMS.CSharpPrepCourse.BL
{
    public class SMSFormEventArgs : EventArgs
    {
        public SMSFormEventArgs(ComboBox sender, DateTimePicker from, DateTimePicker to, TextBox text)
        {
            Sender = sender;
            From = from;
            To = to;
            Text = text;
        }
        public ComboBox Sender;
        public DateTimePicker From;
        public DateTimePicker To;
        public TextBox Text;
    }
}