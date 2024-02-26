using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.Collections.Generic;

namespace CircleScope
{
        public class CircleHekefPlugin : IPlugin
        {
            public static string _Id = "CircleHekef";
            public string Id => _Id;


            public PluginOutput Execute(PluginInput input)
            {
                if (input.Message == "")
            {
                input.Callbacks.StartSession();
            return new PluginOutput("Enter radius");

            }
            else if (input.Message.ToLower() == "exit")
            {
                input.Callbacks.EndSession();
                return new PluginOutput("bye!!!");
            }
                else

            {
                    var radius = double.Parse(input.Message);


                    double p = 3.14 + 2 * radius;
                    return new PluginOutput($"{p}");
                }
            }
        }
    }
