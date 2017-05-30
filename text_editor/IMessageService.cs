namespace text_editor
{
    interface IMessageService
    {
        void ShowInformation(string message);
        void ShowExclamation(string message);
        void ShowError(string message);        
    }
}
