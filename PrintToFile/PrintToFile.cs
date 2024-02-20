using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.IO;

namespace PrintToFile
{
    public class PrintToFile : IPluginWithScheduler
    {
        IScheduler _scheduler;

        public PrintToFile(IScheduler scheduler) => _scheduler = scheduler;

        public static string _Id = "PrintToFile";
        public string Id => _Id;

        public PluginOutput Execute(PluginInput input)
        {
            Console.WriteLine("Enter text to write to the file:");
            string textInput = Console.ReadLine();

            // Specify the file path
            string filePath = @"input.txt";

            // Write user input to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(textInput);
            }

            return new PluginOutput("User input written to file.");
        }

        public void OnScheduler(string data)
        {
            Console.WriteLine("Fired.");
        }
    }
}
