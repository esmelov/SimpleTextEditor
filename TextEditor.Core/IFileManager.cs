using System.Text;

namespace TextEditor.Core
{
    public interface IFileManager
    {
        bool IsExist(string filePath);
        string GetData(string filePath);
        string GetData(string filePath, Encoding fileEncoding);
        void SaveData(string data, string filePath);
        void SaveData(string data, string filePath, Encoding fileEncoding);
        int GetCharCount(string data);
    }
}
