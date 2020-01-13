using System;
using System.IO;
using BFCore.Config;

namespace BFWpf.Models.Config
{
    public class ConfigFactory
    {
        public BFCommandConfig Create()
        {
            var file = new FileInfo(Path.Combine(Environment.CurrentDirectory, $"{nameof(BFCommandConfig)}.json"));

            if (file.Exists)
            {
                return ConfigManager.Import<BFCommandConfig>(file);
            }
            else
            {
                return new BFCommandConfig();
            }
        }
    }
}
