using SimCorp.IMS.CSharpPrepCourse.BL;
using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Collections.Generic;

namespace SimCorp.IMS.CSharpPrepCourse.GUI
{
    class TextBox:IOutput
    {
        private System.Windows.Forms.TextBox tbOutput;

        public TextBox(System.Windows.Forms.TextBox tb)
        {
            tbOutput = tb;
        }

        public void WriteLine(string text)
        {
            tbOutput.AppendText(text);
            tbOutput.AppendText(Environment.NewLine);
        }
    }
}
