
using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.Collections.Generic;

namespace BMI
{
    public class bmi : IPlugin
    {
        public static string _Id => "BMI";
        public string Id => _Id;
        

        /*public HexadecimalPlugin(IScheduler scheduler) => _scheduler = scheduler;
        public static string _Id = "count-down";
        public string Id => _Id;*/

        public static PluginOutput Execute(PluginInput input)
        {         
            Console.WriteLine("enter height and Weight");
            var h = Console.ReadLine();
            var w = Console.ReadLine();
            return w / (2 * h);
            
        }

    }
}


