using System;
using TextEditor.Core;

namespace text_editor
{
    class MainPresentor
    {
        private readonly IMain _view;
        private readonly IFileManager _manager;
        private readonly IMessageService _messageService;

        public MainPresentor(IMain view, IFileManager manager, IMessageService messageService)
        {
            _view = view;
            _manager = manager;
            _messageService = messageService;

            _view.SetCharCount(0);
            _view.ChangeContentEvent += _view_ChangeContentEvent;
            _view.OpenFileEvent += _view_OpenFileEvent;
            _view.SaveFileEvent += _view_SaveFileEvent;
        }

        private void _view_SaveFileEvent(object sender, EventArgs e)
        {
            try
            {
                string content = _view.FileData;
                string filePath = _view.FilePath;
                _manager.SaveData(content, filePath);
                _messageService.ShowInformation("File Saved!");
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_OpenFileEvent(object sender, EventArgs e)
        {
            try
            {
                string filePath = _view.FilePath;
                bool fileExist = _manager.IsExist(filePath);
                if (!fileExist)
                {
                    _messageService.ShowExclamation("File does not exist!");
                    return;
                }

                string content = _manager.GetData(filePath);
                int charCount = _manager.GetCharCount(content);

                _view.FileData = content;
                _view.SetCharCount(charCount);
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_ChangeContentEvent(object sender, EventArgs e)
        {
            string content = _view.FileData;
            int charCount = _manager.GetCharCount(content);
            _view.SetCharCount(charCount);
        }
    }
}
