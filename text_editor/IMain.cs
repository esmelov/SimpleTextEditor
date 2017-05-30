using System;

namespace text_editor
{
    interface IMain
    {
        string FilePath { get; }
        string FileData { get; set; }
        void SetCharCount(int CharCount);
        event EventHandler OpenFileEvent;
        event EventHandler SaveFileEvent;
        event EventHandler ChangeContentEvent;
    }
}
