using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.Collections.Generic;

namespace CountDown
{
    public class BMIPlugin : IPluginWithScheduler
    {
        IScheduler _scheduler;

        public BMIPlugin(IScheduler scheduler) => _scheduler = scheduler;

        public static string _Id = "BMI";
        public string Id => _Id;

        public PluginOutput Execute(PluginInput height PluginInput Weight)
        {
           BMI = Weight-2*height
                
            return new PluginOutput("BMI started.");
        }

        public void OnScheduler(string data)
        {
            Console.WriteLine("BMI");
        }
    }
}
