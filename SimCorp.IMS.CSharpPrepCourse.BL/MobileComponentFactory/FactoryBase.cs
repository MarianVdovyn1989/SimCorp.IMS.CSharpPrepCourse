using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.BL.MobileComponentFactory
{
    public abstract class FactoryBase : IFactory
    {
        IOutput Output;
        public FactoryBase(IOutput output)
        {
            Output = output;
        }

        private int GetComponentIndex()
        {
            while (true)
            {
                Console.WriteLine(BuildHeaderSelector());

                var OptionBuilder = BuildComponentsSelector();
                //IOutput
                Console.Write(OptionBuilder);

                var line = Console.ReadLine();
                try
                {
                    //convert to integer
                    var index = int.Parse(line);
                    //check that int value is within the specified range of current method
                    //method inherited from abstract class - not unique
                    int Index = ValidateUserInputIndex(index, OptionBuilder);
                    Output.WriteLine(ConsoleOutput.ReturnSelectedOption(OptionBuilder, Index) + "\n");
                    return Index;
                }
                catch (Exception ex)
                {
                    Output.WriteLine(ex.Message);
                }
            }
        }

        public int SelectComponentIndex()
        {
            while (true)
            {
                int index = GetComponentIndex();
                if (index == ErrorCode)
                {
                    continue;
                }
                return index;
            }
        }
        private int ErrorCode = -1;

        private int ValidateUserInputIndex(int index, StringBuilder OptionBuilder)
        {
            int LastOption = OptionBuilder.ToString().Split('\n').Length - 2;

            if (index > 0 && index < LastOption)
                return index;
            else
                throw new ArgumentException($"Invalid {nameof(index)}");
        }
        public abstract FactoryOutput Create(int userInput);
        public abstract StringBuilder BuildComponentsSelector();
        public abstract StringBuilder BuildHeaderSelector();
    }
}
