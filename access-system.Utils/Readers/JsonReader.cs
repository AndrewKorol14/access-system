using Newtonsoft.Json;
using System.IO;

namespace access_system.Utils.Readers
{
    /// <summary>
    /// Provides methods for working with Json files
    /// </summary>
    class JsonReader : IReader
    {
        private static object lockObject = new object();

        /// <summary>
        /// Reads information from the specified file, converting it to the specified type
        /// </summary>
        /// <param name="wayToFile">path to file with information</param>
        public T ReadFile<T>(string wayToFile)
        {
            lock (lockObject)
            {
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(wayToFile));
            }
        }

        /// <summary>
        /// Serialize object to JSON file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="directoryForSave"></param>
        /// <param name="objectToWriteToFile"></param>
        public void WriteToFile<T>(string directoryForSave, T objectToWriteToFile)
        {
            lock (lockObject)
            {
                using (StreamWriter file = File.CreateText(directoryForSave))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, objectToWriteToFile);
                }
            }
        }
    }
}
