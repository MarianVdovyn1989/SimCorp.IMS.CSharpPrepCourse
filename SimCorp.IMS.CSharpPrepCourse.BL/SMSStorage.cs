using System;
using System.Collections.Generic;
using System.Linq;

namespace SimCorp.IMS.CSharpPrepCourse.BL
{
    public partial class SMSStorage
    {
        #region Event/Delegates
        public delegate void SMSStorageDelegateAdd(SMS message);
        public event SMSStorageDelegateAdd SMSSaved;
        public delegate void SMSStorageDelegateRemove();
        public event SMSStorageDelegateRemove SMSRemoved;
        public delegate void SMSStorageDelegateQueue();
        public event SMSStorageDelegateQueue SMSQueued;
        public void OnSMSSaved(SMS message)
        {
            SMSStorageDelegateAdd del = SMSSaved;
            del?.Invoke(message);
        }
        public void OnSMSRemoved()
        {
            SMSStorageDelegateRemove del = SMSRemoved;
            del?.Invoke();
        }
        public void OnSMSQueued()
        {
            SMSStorageDelegateQueue del = SMSQueued;
            del?.Invoke();
        }
        #endregion
        private List<SMS> messages = new List<SMS>();
        public List<SMS> Messages
        {
            get
            {
                return messages;
            }
        }
        private SMSFilterState FilterState;
        public List<SMS> FilteredMessages;
        public SMSStorage(SMSFilterState filterState, List<SMS> filteredMessages)
        {
            FilteredMessages = filteredMessages;
            FilterState = filterState;
            SMSProvider.SMSReceived += AddToStorage;
            FilterState.StateUpdated += QueueMessages;
        }
        public void AddToStorage(SMS message)
        {
            messages.Add(message);
            OnSMSSaved(message);
        }
        public void RemoveFromStorage(List<SMS> selectedMessages)
        {
            messages.RemoveAll(storageMessage => selectedMessages.Any(selected => storageMessage.TimeReceived.Trim(TimeSpan.TicksPerSecond) == selected.TimeReceived.Trim(TimeSpan.TicksPerSecond) && storageMessage.Sender==selected.Sender));
            OnSMSRemoved();
        }
        private void QueueMessages(object sender, EventArgs e)
        {
            FilteredMessages = Messages.FilterBySender(m => m.Sender == FilterState.Sender, FilterState.Sender).Where(m => m.TimeReceived >= FilterState.FromDateTime && m.TimeReceived < FilterState.ToDateTime && m.Text.ToUpper().Contains(FilterState.TextToSearch.ToUpper())).OrderBy(m => m.TimeReceived).ToList();
            OnSMSQueued();
        }

    }
}
