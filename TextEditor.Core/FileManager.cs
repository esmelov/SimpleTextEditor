using System.IO;
using System.Text;

namespace TextEditor.Core
{
    public class FileManager: IFileManager
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);//Encoding.UTF8;

        public bool IsExist(string filePath)   // проверка на существование файла
        {
            return File.Exists(filePath);
        }

        public string GetData(string filePath)  // получаем содержимое файла
        {
            return GetData(filePath, _defaultEncoding);
        }

        public string GetData(string filePath, Encoding fileEncoding)   // получаем содержимое файла с использованием кодировки
        {
            string data = File.ReadAllText(filePath, fileEncoding);
            return data;
        }

        public void SaveData (string data, string filePath) //сохраняем данные в файл
        {
            SaveData(data, filePath, _defaultEncoding);
        }

        public void SaveData (string data, string filePath, Encoding fileEncoding)  //сохраняем данные в файл с использованием кодировки
        {
            File.WriteAllText(filePath, data, fileEncoding);
        }

        public int GetCharCount(string data)    // подсчет символов в данных файла
        {
            return data.Length;
        }
    }
}
