using SimCorp.IMS.CSharpPrepCourse.BL;
using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Collections.Generic;

namespace SimCorp.IMS.CSharpPrepCourse.GUI
{
    public class RichTextBox : IOutput
    {
        private System.Windows.Forms.RichTextBox rtbOutput;

        public RichTextBox(System.Windows.Forms.RichTextBox tb)
        {
            rtbOutput = tb;
        }
        public void WriteLine(string text)
        {
            rtbOutput.AppendText(text);
            rtbOutput.AppendText(Environment.NewLine);
        }
        public void WriteLine(SMS message)
        {
            rtbOutput.AppendText($"From: {message.Sender}");
            rtbOutput.AppendText(Environment.NewLine);
            rtbOutput.AppendText($"Date/Time: {message.TimeReceived}");
            rtbOutput.AppendText(Environment.NewLine);
            rtbOutput.AppendText(message.Text);
            rtbOutput.AppendText(Environment.NewLine);
        }
    }
}
