using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor.Core;

namespace text_editor
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Main mainForm = new Main();
            MessageService msgService = new MessageService();
            FileManager fManager = new FileManager();

            MainPresentor mPresentor = new MainPresentor(mainForm, fManager, msgService);

            Application.Run(mainForm);
        }
    }
}
