using System;
using System.IO;
using BFCore.Config;

namespace BFWpf.Models.Config
{
    public class ConfigFactory
    {
        public T Create<T>()
        {
            var name = typeof(T).Name;

            if (!(typeof(T) == typeof(CommonConfig) || typeof(T) == typeof(BFCommandConfig)))
            {
                throw new Exception($"{name} is not approved type.");
            }


            var file = new FileInfo(Path.Combine(Environment.CurrentDirectory, $"{name}.json"));

            if (file.Exists)
            {
                return ConfigManager.Import<T>(file);
            }
            else
            {
                return (T)typeof(T).GetConstructor(Type.EmptyTypes).Invoke(null);
            }
        }
    }
}
