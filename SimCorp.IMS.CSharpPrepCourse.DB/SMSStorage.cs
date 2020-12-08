using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCorp.IMS.CSharpPrepCourse.BL;

namespace SimCorp.IMS.CSharpPrepCourse.DB
{
    public class SMSStorage
    {
        public SMSStorage()
        {

        }
        //.SMSRecived+=Add();
        public void Add(SMS message)
        {
            string directoryPath = System.IO.Directory.GetCurrentDirectory();
            string path = directoryPath + "SMSStorage.txt";
            using (FileStream fs = File.Create(path))
            {
                foreach (var item in message)
                {
                    System.IO.File.WriteAllText(path, item);
                } 
            }
        }
        public void Remove() 
        { }
    }
}
