using SimCorp.IMS.CSharpPrepCourse.BL;
using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static SimCorp.IMS.CSharpPrepCourse.BL.SMSFormatHandler;
using SMS = SimCorp.IMS.CSharpPrepCourse.BL.SMS;

namespace SimCorp.IMS.CSharpPrepCourse.GUI
{
    public partial class SMSForm : Form
    {
        DateTime AppStartTime = DateTime.Now;
        private ISMSListOutput Output;
        private SMSFilterState Filter;
        private SMSStorage Storage;
        private List<SMS> FilteredMessages = new List<SMS>();
        private SMSFormatDelegate SMSFormatDelegate = new SMSFormatDelegate(FormatNone);//default value
        public SMSForm()
        {
            InitializeComponent();
            Output = new ListView(lvSMS);
            Filter = new SMSFilterState(FilteredMessages);
            Storage = new SMSStorage(Filter, FilteredMessages);
            #region Background thread
            this.Shown += BackgroundWorkerSendSMS;
            Storage.SMSSaved += UpdateGUISenders;
            Storage.SMSRemoved += UpdateGUIListView;
            Storage.SMSQueued += UpdateGUIListView;
            Filter.StateUpdated += UpdateGUIListView;
            #endregion
            #region GUI thread
            cboSMSSenderSelector.SelectedIndexChanged += new EventHandler(UpdateGUIFiltersBySender);//Sender
            dtFilterFromTime.ValueChanged += new EventHandler(UpdateGUIFiltersByTime);//FromDate          
            dtFilterToTime.ValueChanged += new EventHandler(UpdateGUIFiltersByTime);//ToDate           
            tbSearchTextInMessages.TextChanged += new EventHandler(UpdateGUIFiltersByText);//SearchText
            cboSMSFormatSelector.SelectionChangeCommitted += new EventHandler(UpdateFormatTextHandler);//Assign Delegate Handler
            cboSMSFormatSelector.SelectionChangeCommitted += new EventHandler(UpdateGUIListView);//Format
            #endregion
        }
        private void UpdateGUIFiltersByText(object sender, EventArgs e)
        {
            if (!cbMultipleFilters.Checked)
            {
                //unsubscribe from Events to update GUI programmatically without firing event 
                cboSMSSenderSelector.SelectedIndexChanged -= new EventHandler(UpdateGUIFiltersBySender);
                dtFilterFromTime.ValueChanged -= new EventHandler(UpdateGUIFiltersByTime);
                dtFilterToTime.ValueChanged -= new EventHandler(UpdateGUIFiltersByTime);

                cboSMSSenderSelector.SelectedIndex = 1;
                DateTimePickerClearDefaultDateTime();
                //subscribe on Events back
                cboSMSSenderSelector.SelectedIndexChanged += new EventHandler(UpdateGUIFiltersBySender);
                dtFilterFromTime.ValueChanged += new EventHandler(UpdateGUIFiltersByTime);
                dtFilterToTime.ValueChanged += new EventHandler(UpdateGUIFiltersByTime);
            }
            UpdateFiltersStates(sender, e);
        }
        private void UpdateGUIFiltersByTime(object sender, EventArgs e)
        {
            if (!cbMultipleFilters.Checked)
            {
                //unsubscribe from Events to update GUI programmatically without firing event 
                cboSMSSenderSelector.SelectedIndexChanged -= new EventHandler(UpdateGUIFiltersBySender);
                tbSearchTextInMessages.TextChanged -= new EventHandler(UpdateGUIFiltersByText);

                cboSMSSenderSelector.SelectedIndex = 1;//Sender
                tbSearchTextInMessages.Clear();//SearchText
                //subscribe on Events back
                cboSMSSenderSelector.SelectedIndexChanged += new EventHandler(UpdateGUIFiltersBySender);
                tbSearchTextInMessages.TextChanged += new EventHandler(UpdateGUIFiltersByText);
            }
            UpdateFiltersStates(sender, e);
        }
        private void UpdateGUIFiltersBySender(object sender, EventArgs e)
        {
            if (!cbMultipleFilters.Checked)
            {
                //unsubscribe from Events to update GUI programmatically without firing event
                dtFilterFromTime.ValueChanged -= new EventHandler(UpdateGUIFiltersByTime);
                dtFilterToTime.ValueChanged -= new EventHandler(UpdateGUIFiltersByTime);
                tbSearchTextInMessages.TextChanged -= new EventHandler(UpdateGUIFiltersByText);

                DateTimePickerClearDefaultDateTime();
                tbSearchTextInMessages.Clear();
                //subscribe on Events back
                dtFilterFromTime.ValueChanged += new EventHandler(UpdateGUIFiltersByTime);
                dtFilterToTime.ValueChanged += new EventHandler(UpdateGUIFiltersByTime);
                tbSearchTextInMessages.TextChanged += new EventHandler(UpdateGUIFiltersByText);
            }
            UpdateFiltersStates(sender, e);
        }
        private void UpdateGUIListView()
        {
            var formattedMessages = FormatMessageText(Storage.Messages);
            Output.WriteLine(formattedMessages);
        }
        private void UpdateGUIListView(object sender, EventArgs e)
        {
            var formattedMessages = FormatMessageText(Storage.FilteredMessages);
            Output.WriteLine(formattedMessages);
        }       
        private void dtFilterFromTime_DropDown(object sender, EventArgs e)
        {
            if (dtFilterFromTime.Value == DateTimePicker.MinimumDateTime)
            {
                DataTimePickerSetDefaultDateTime(AppStartTime, 10);
                UpdateFiltersStates(sender, e);
            }
        }
        private void dtFilterToTime_DropDown(object sender, EventArgs e)
        {
            if (dtFilterToTime.Value == DateTimePicker.MaximumDateTime)
            {
                DataTimePickerSetDefaultDateTime(AppStartTime, 10);
                UpdateFiltersStates(sender, e);
            }
        }
        private void DataTimePickerSetDefaultDateTime(DateTime appStartTime, int minMaxTimeInterval)
        {
            dtFilterFromTime.Value = appStartTime;
            dtFilterFromTime.Format = DateTimePickerFormat.Time;
            dtFilterToTime.Value = appStartTime.AddMinutes(minMaxTimeInterval);
            dtFilterToTime.Format = DateTimePickerFormat.Time;
        }
        private void DateTimePickerClearDefaultDateTime()
        {
            dtFilterFromTime.Value = DateTimePicker.MinimumDateTime;
            dtFilterFromTime.Format = DateTimePickerFormat.Custom;
            dtFilterFromTime.CustomFormat = " ";
            dtFilterToTime.Value = DateTimePicker.MaximumDateTime;
            dtFilterToTime.Format = DateTimePickerFormat.Custom;
            dtFilterToTime.CustomFormat = " ";
        }
        #region SwitchThreadMethods
        private void UpdateFiltersStates(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                //recursive call to switch threads if InvokeRequired
                Invoke(new EventHandler(cbMultipleFilters_Changed));
                return;
            }
            else
            {
                Filter.Update(sender, new SMSFormEventArgs(cboSMSSenderSelector, dtFilterFromTime, dtFilterToTime, tbSearchTextInMessages));
            }
        }
        private void UpdateGUISenders(SMS message)
        {
            if (InvokeRequired)
            {
                //recursive call to switch threads if InvokeRequired
                Invoke(new SMSProvider.SMSReceivedDelegate(UpdateGUISenders), message);
                return;
            }
            else
            {
                if (!cboSMSSenderSelector.Items.Contains(message.Sender))
                    cboSMSSenderSelector.Items.Add(message.Sender);
            }
        }
        private List<SMS> FormatMessageText(List<SMS> messages)
        {
            List<SMS> formattedMessages = new List<SMS>();
            if (InvokeRequired)
            {
                //recursive call to switch threads if InvokeRequired
                Invoke(new SMSFormatDelegate(FormatMessageText), messages);
                return formattedMessages;
            }
            else
            {
                formattedMessages = SMSFormatDelegate(messages);
                return formattedMessages;
            }
        }
        #endregion
        #region AutogeneratedEventHandlers
        private void SMSForm_Load(object sender, EventArgs e)
        {
            DataTimePickerSetDefaultDateTime(AppStartTime, 10);
            cboSMSFormatSelector.SelectedIndex = 0;
            cboSMSSenderSelector.SelectedIndex = 0;
        }
        private void BackgroundWorkerSendSMS(object sender, EventArgs e)=> SMSBackgroundWorker.RunWorkerAsync();
        private void SMSBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SMSProvider.SendSMS(sender as BackgroundWorker, smsInterval: 1500);
        }
        private void UpdateFormatTextHandler(object sender, EventArgs e)
        {
            int selectedIndex = cboSMSFormatSelector.SelectedIndex;
            switch (selectedIndex)
            {
                case 1://LowerCase
                    SMSFormatDelegate = new SMSFormatDelegate(FormatToLowerCase);
                    break;
                case 2://UpperCase
                    SMSFormatDelegate = new SMSFormatDelegate(FormatToUpperCase);
                    break;
                case 3://EndWithDateTime
                    SMSFormatDelegate = new SMSFormatDelegate(FormatEndWithDateTime);
                    break;
                case 4://StartWithDateTime
                    SMSFormatDelegate = new SMSFormatDelegate(FormatStartWithDateTime);
                    break;
                case 5://Custom
                    SMSFormatDelegate = new SMSFormatDelegate(FormatToCustom);
                    break;
                default://None
                    SMSFormatDelegate = new SMSFormatDelegate(FormatNone);
                    break;
            }
        }
        private void cbMultipleFilters_Changed(object sender, EventArgs e)
        {
            if (cbMultipleFilters.Checked)
            {
                cboSMSSenderSelector.SelectedIndex = 1;
                DataTimePickerSetDefaultDateTime(AppStartTime, 10);
                tbSearchTextInMessages.Clear();
            }
            else
            {
                DateTimePickerClearDefaultDateTime();
                tbSearchTextInMessages.Clear();
            }
        }
        private void bDelete_Click(object sender, EventArgs e)
        {
            List<SMS> selectedSMS = new List<SMS>();
            foreach (ListViewItem item in lvSMS.SelectedItems)
            {
                string from = item.SubItems[0].Text;
                string text = item.SubItems[1].Text;
                DateTime receivedDateTime = DateTime.Parse(item.SubItems[2].Text);
                selectedSMS.Add(new SMS() { Sender = from, Text = text, TimeReceived = receivedDateTime });
            }
            Storage.RemoveFromStorage(selectedSMS);
        }
        #endregion
    }
}
