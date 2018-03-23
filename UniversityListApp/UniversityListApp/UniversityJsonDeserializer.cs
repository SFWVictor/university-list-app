namespace UniversityListApp
{
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using Newtonsoft.Json;

    public static class UniversityJsonDeserializer
    {
        private const string jsonFileName = "universities.json";

        public static List<T> DeserializeObjects<T>(StreamReader reader)
            where T : class
        {
            var json = reader.ReadToEnd();
            var objects = JsonConvert.DeserializeObject<List<T>>(json);
            return objects;
        }

        public static List<T> LoadFromJson<T>()
            where T : class
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(UniversityJsonDeserializer)).Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{nameof(UniversityListApp)}.{jsonFileName}");
            List<T> objects = new List<T>();

            using (var reader = new StreamReader(stream))
            {
                objects = DeserializeObjects<T>(reader);
            }

            return objects;
        }
    }
}
