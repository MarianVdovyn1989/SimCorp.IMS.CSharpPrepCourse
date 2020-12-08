using System;
using System.Collections.Generic;

namespace SimCorp.IMS.CSharpPrepCourse.BL
{
    public static class SMSSender
    {
        public static string SelectRandonSender()
        {
            Random random = new Random();
            int rInt = random.Next(0, 3);
            string sender = null;
            switch (rInt)
            {
                case 0:
                    sender = "Mom";
                    break;
                case 1:
                    sender = "Bank";
                    break;
                case 2:
                    sender = "YourBro";
                    break;
            }
            return sender;
        }
        public static IEnumerable<T> FilterBySender<T>(this IEnumerable<T> messages,
                                                     Func<T, bool> predicate, string selectedItem)
        {
            var result = new List<T>();
            foreach (var item in messages)
            {
                if (predicate(item) || selectedItem == "All")
                    result.Add(item);
            }
            return result;
        }
    }
}
