using System;
using System.Windows.Forms;

namespace text_editor
{
    public partial class Main : Form, IMain
    {
        public Main()
        {
            InitializeComponent();
            OpenFileToolStripMenuItem.Click += OpenFileToolStripMenuItem_Click;
            SaveFileToolStripMenuItem.Click += SaveFileToolStripMenuItem_Click;
            newToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            FileDataTextBox.TextChanged += FileDataTextBox_TextChanged;
            FontLargeToolStripMenuItem.Click += FontLargeToolStripMenuItem_Click;
            FontSmallerToolStripMenuItem.Click += FontSmallerToolStripMenuItem_Click;

            FontChange(_defaultFontSize);
            toolStripFontSizeLabel2.Text = _defaultFontSize.ToString();
            toolStripClockLabel2.Text = DateTime.Now.ToString();
            Timer clockTimer = new Timer()
            {
                Interval = 1000
            };
            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();
        }

        #region FormManage
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_FormClosing(this, null);
            FilePath = "";
            FileDataTextBox.Text = "";
            FontChange(_defaultFontSize);
            Text = "Simple Text Editor [New]";
            SaveFileToolStripMenuItem.Enabled = false;
        }
        private void FontSmallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(toolStripFontSizeLabel2.Text, out int fontSize))
            {
                fontSize--;
                FontChange(fontSize);
            }
        }
        private void FontLargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(toolStripFontSizeLabel2.Text, out int fontSize))
            {
                fontSize++;
                FontChange(fontSize);
            }
        }
        private void FontChange(int fontSize)
        {
            if (fontSize >= _minFontSize && fontSize <= _maxFontSize)
            {
                FileDataTextBox.Font = new System.Drawing.Font("Calibri", fontSize);
                toolStripFontSizeLabel2.Text = fontSize.ToString();
            }
        }
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            toolStripClockLabel2.Text = DateTime.Now.ToString();
        }
        #endregion

        #region PresentorManage
        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                SaveFileDialog SetFile = new SaveFileDialog()
                {
                    Filter = "Text Files|*.txt|All Files|*.*"
                };
                if (SetFile.ShowDialog() == DialogResult.OK)
                {
                    FilePath = SetFile.FileName;
                    Text = "Simple Text Editor [" + FilePath + "]";
                }
                else return;
            }
            SaveFileToolStripMenuItem.Enabled = false;
            SaveFileEvent?.Invoke(this, EventArgs.Empty);
        }
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)    // выбираем файл
        {
            OpenFileDialog SelectFile = new OpenFileDialog()
            {
                Filter = "Text Files|*.txt|All Files|*.*"
            };
            if (SelectFile.ShowDialog() == DialogResult.OK) // если пользователь выбирает файл, то вызываем событие на открытие файла
            {
                FilePath = SelectFile.FileName;
                Text = "Simple Text Editor [" + FilePath + "]";
                FontChange(_defaultFontSize);
                OpenFileEvent?.Invoke(this, EventArgs.Empty);
            }
        }
        private void FileDataTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveFileToolStripMenuItem.Enabled = true;
            if (FileDataTextBox.Text.Length > 0)
            {
                FontLargeToolStripMenuItem.Enabled = true;
                FontSmallerToolStripMenuItem.Enabled = true;
            }
            else
            {
                FontLargeToolStripMenuItem.Enabled = false;
                FontSmallerToolStripMenuItem.Enabled = false;
            }
            ChangeContentEvent?.Invoke(this, EventArgs.Empty);
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveFileToolStripMenuItem.Enabled)
            {
                DialogResult messageResult = MessageBox.Show("File not save! Save?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (messageResult == DialogResult.OK)
                {
                    SaveFileEvent?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        #endregion

        #region Private Variables
        private string _filePath;
        private const int _minFontSize = 6;
        private const int _maxFontSize = 72;
        private int _defaultFontSize = 11;
        #endregion

        #region IMain Realisation
        public string FilePath
        {
            get
            {
                return _filePath;
            }
            private set
            {
                _filePath = value;
            }
        }
        public string FileData
        {
            get
            {
                return FileDataTextBox.Text;
            }
            set
            {
                FileDataTextBox.Text = value;
            }
        }

        public event EventHandler OpenFileEvent;    // событие на открытие файла
        public event EventHandler SaveFileEvent;    // событие на сохранение фала
        public event EventHandler ChangeContentEvent;   // событие на изменение текста

        public void SetCharCount(int CharCount) // метод подсчета символов
        {
            toolStripCharCountLabel2.Text = CharCount.ToString();
        }
        #endregion
    }
}
