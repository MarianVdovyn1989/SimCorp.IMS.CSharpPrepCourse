using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface
{
    public class ConsoleOutput : IOutput
    {
        public  static string ReturnSelectedOption(StringBuilder OptionBuilder, int Index)
        {
            Console.WriteLine("***");
            if (OptionBuilder.Length > 0)
            {
                string[] Options = OptionBuilder.ToString().Replace("\r", "").Split('\n');
                string SelectedLine = Options[Index] + $" option was selected";
                return SelectedLine;
            }
            else
                return "";
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
