using System.Collections.Generic;

namespace SimCorp.IMS.CSharpPrepCourse.BL
{
    public class SMSFormatHandler
    {
        public delegate List<SMS> SMSFormatDelegate(List<SMS> messages);
        public static List<SMS> FormatStartWithDateTime(List<SMS> messages)
        {
            List<SMS> result = new List<SMS>();
            foreach (var message in messages)
            {
                result.Add(new SMS { Text = $"{message.TimeReceived}: {message.Text}", Sender = message.Sender, TimeReceived = message.TimeReceived });
            }
            return result;
        }
        public static List<SMS> FormatNone(List<SMS> message)
        {
            return message;
        }
        public static List<SMS> FormatToLowerCase(List<SMS> messages)
        {
            List<SMS> result = new List<SMS>();
            foreach (var message in messages)
            {
                result.Add(new SMS { Text = $"{message.Text.ToLower()}", Sender = message.Sender, TimeReceived = message.TimeReceived });
            }
            return result;
        }
        public static List<SMS> FormatToUpperCase(List<SMS> messages)
        {
            List<SMS> result = new List<SMS>();
            foreach (var message in messages)
            {
                result.Add(new SMS { Text = $"{message.Text.ToUpper()}", Sender = message.Sender, TimeReceived = message.TimeReceived });
            }
            return result;
        }
        public static List<SMS> FormatToCustom(List<SMS> messages)
        {
            List<SMS> result = new List<SMS>();
            foreach (var message in messages)
            {
                result.Add(new SMS { Text = $"{message.Text.Replace('e', 'E')}", Sender = message.Sender, TimeReceived = message.TimeReceived });

            }
            return result;
        }
        public static List<SMS> FormatEndWithDateTime(List<SMS> messages)
        {
            List<SMS> result = new List<SMS>();
            foreach (var message in messages)
            {
                result.Add(new SMS { Text = $"{message.Text} {message.TimeReceived}", Sender = message.Sender, TimeReceived = message.TimeReceived });
            }
            return result;
        }
    }
}
