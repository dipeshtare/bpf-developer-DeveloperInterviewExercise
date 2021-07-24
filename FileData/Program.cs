using System;

namespace FileData
{
    public static class Program
    {
        public static readonly ProgramBO programBO = new ProgramBO();
        public static void Main(string[] args)
        {
            try
            {
                programBO.CheckConsoleArguments(args);
            }
            catch (Exception ex)
            {
                programBO.DisplayMessage(ex.Message);
            }
        }
    }
}