using System;
using System.Collections.Generic;

namespace SimCorp.IMS.CSharpPrepCourse.BL
{
    public class SMSFilterState
    {
        #region FilterStateUpdated event/delegate
        public delegate void FilterStateDelegate(object sender, SMSFormEventArgs e);
        public event FilterStateDelegate StateUpdated;
        public void OnFilterStateUpdated(SMSFormEventArgs e)
        {
            FilterStateDelegate filterStateDelegate = StateUpdated;
            filterStateDelegate?.Invoke(this, new SMSFormEventArgs(e.Sender, e.From, e.To, e.Text));
        }
        #endregion
        #region Properties
        List<SMS> FilteredMessages;
        public SMSFilterState(List<SMS> filteredMessages)//SMSForm form)
        {
            FilteredMessages = filteredMessages;
        }
        private string sender;
        public string Sender
        {
            get { return sender; }
        }
        private DateTime fromDateTime;
        public DateTime FromDateTime
        {
            get { return fromDateTime; }
        }
        private DateTime toDateTime;
        public DateTime ToDateTime
        {
            get { return toDateTime; }
        }
        private string textToSearch;
        public string TextToSearch
        {
            get { return textToSearch; }
        }
        #endregion
        #region Methods
        public void Update(object sender, SMSFormEventArgs e)
        {
            UpdateValues(e);
            OnFilterStateUpdated(e);
        }
        private void UpdateValues(SMSFormEventArgs e)
        {
            if (this.sender!=e.Sender.SelectedItem.ToString())
            {
                this.sender = e.Sender.SelectedItem.ToString();
            }
            if (fromDateTime != e.From.Value)
            {
                fromDateTime = e.From.Value;
            }
            if (toDateTime != e.To.Value)
            {
                toDateTime = e.To.Value;
            }
            if (textToSearch != e.Text.Text)
            {
                textToSearch = e.Text.Text;
            }
        }
        #endregion
    }
}
