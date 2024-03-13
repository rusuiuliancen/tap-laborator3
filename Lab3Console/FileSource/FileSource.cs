using Lab3Console.FileSource;

namespace Lab3Console.FileSource
{
    public class FileSource : IFileSource
    {
        public string GetPolicySource()
        {
            return File.ReadAllText("policy.json");
        }
    }
}
