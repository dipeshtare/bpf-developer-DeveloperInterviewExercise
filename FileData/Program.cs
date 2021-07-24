using FileData.Constants;
using System;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ConsoleArguments(args);
        }

        private static void ConsoleArguments(string[] args)
        {
            FileDetails fileDetails = new FileDetails();
            try
            {
                if (ArgumentConstants.VersionStrings.Contains(args[0]))
                    DisplayMessage(fileDetails.Version(args[1]));
                else if (ArgumentConstants.SizeStrings.Contains(args[0]))
                    DisplayMessage(fileDetails.Size(args[1]));
                else
                    DisplayMessage("Invalid arguments passed!");
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

        private static void DisplayMessage<T>(T message)
        {
            Console.WriteLine(message);
        }
    }
}