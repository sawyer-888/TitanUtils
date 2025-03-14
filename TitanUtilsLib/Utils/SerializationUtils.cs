using Newtonsoft.Json;
using YamlDotNet.Serialization;
using System.IO;

namespace TitanUtilsLib.Utils
{
    public static class SerializationUtils
    {
        public static string ToJson<T>(T obj) => JsonConvert.SerializeObject(obj, Formatting.Indented);

        public static T FromJson<T>(string json) => JsonConvert.DeserializeObject<T>(json);

        public static string ToYaml<T>(T obj)
        {
            var serializer = new SerializerBuilder().Build();
            return serializer.Serialize(obj);
        }

        public static T FromYaml<T>(string yaml)
        {
            var deserializer = new DeserializerBuilder().Build();
            return deserializer.Deserialize<T>(yaml);
        }
    }
}
