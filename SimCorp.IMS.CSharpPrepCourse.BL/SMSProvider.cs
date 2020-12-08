using System;
using System.ComponentModel;

namespace SimCorp.IMS.CSharpPrepCourse.BL
{
    public class SMSProvider
    {
        public delegate void SMSReceivedDelegate(SMS message);
        public static event SMSReceivedDelegate SMSReceived;

        public static void OnSMSReceived(SMS message)
        {
            SMSReceivedDelegate smsDelegate = SMSReceived;
            smsDelegate?.Invoke(message);
        }
        public static void SendSMS(BackgroundWorker sender, int smsInterval)
        {
            int counter = 0;
            while (true)
            {
                counter++;
                System.Threading.Thread.Sleep(smsInterval);
                SMS message = new SMS() { Sender = SMSSender.SelectRandonSender(), Text = $"Meaningfull sms # {counter} received", TimeReceived = DateTime.Now };
                OnSMSReceived(message);
            }
        }
    }
}
