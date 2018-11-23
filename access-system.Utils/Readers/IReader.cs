namespace access_system.Utils.Readers
{
    interface IReader
    {
        void WriteToFile<T>(string directoryForSave, T objectToWriteToFile);

        T ReadFile<T>(string wayToFile);
    }
}
