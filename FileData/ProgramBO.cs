using FileData.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public interface IProgramBO
    {
        void CheckConsoleArguments(string[] argument);
        void DisplayMessage<T>(T message);
    }

    public class ProgramBO : IProgramBO
    {
        public void CheckConsoleArguments(string[] argument)
        {
            FileDetails fileDetails = new FileDetails();
            if (ArgumentConstants.VersionStrings.Contains(argument[0]))
                DisplayMessage(fileDetails.Version(argument[1]));
            else if (ArgumentConstants.SizeStrings.Contains(argument[0]))
                DisplayMessage(fileDetails.Size(argument[1]));
            else
                DisplayMessage("Invalid arguments passed!");
        }


        public void DisplayMessage<T>(T message)
        {
            Console.WriteLine(message);
        }
    }
}