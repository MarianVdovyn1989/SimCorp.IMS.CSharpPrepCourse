using SimCorp.IMS.CSharpPrepCourse.BL;
using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SMS = SimCorp.IMS.CSharpPrepCourse.BL.SMS;

namespace SimCorp.IMS.CSharpPrepCourse.GUI
{
    public class ListView : ISMSListOutput
    {
        private System.Windows.Forms.ListView lvOutput;
        public ListView(System.Windows.Forms.ListView listView)
        {
            lvOutput = listView;
        }
        public void WriteLine(List<SMS> messages)
        {
            lvOutput.Items.Clear();
            foreach (var message in messages)
            {
                lvOutput.Items.Add(new ListViewItem(new[] { message.Sender, message.Text, message.TimeReceived.ToString() }));
            }
        }
    }
}
