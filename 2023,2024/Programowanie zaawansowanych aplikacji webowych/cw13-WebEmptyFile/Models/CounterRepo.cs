namespace WebEmptyFile.Models
{
    public class CounterRepo
    {
        public static void SaveToFile(string path = "counter.txt")
        {
            File.WriteAllText(path, Convert.ToString(Convert.ToInt16(File.ReadAllText(path)) + 1));
        }

        public static string ReadFromFile(string path = "counter.txt")
        {
            return File.ReadAllText(path);
        }

        public static void Reset(string path = "counter.txt")
        {
            File.WriteAllText(path, "-1");
        }
    }
}