using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AHK_Visual_2._0
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            MainForm.settingsOpen = true;
            updateSettings();
        }

        private void ButtonForSave_Click(object sender, EventArgs e)
        {
            Settings MainSettings = new Settings();
            MainSettings.defaultFileName = TextBoxForFileName.Text;
            MainSettings.defaultModKey = TextBoxForModKey.Text;
            MainSettings.quickVar = TextBoxForQuickVar.Text;
            MainSettings.useNewLine = CheckForUseNewLine.Checked;
            MainSettings.insertAtCursor = CheckForInsertAtCursor.Checked;
            MainSettings.useSend = CheckForUseSend.Checked;
            MainSettings.moveInsertionPoint = CheckForMoveInsertion.Checked;

            String settingsFile = JsonConvert.SerializeObject(MainSettings);
            CreateFile(Environment.CurrentDirectory + "\\" + "settings.json", settingsFile);
            MainForm.settingsOpen = false;
            ActiveForm.Close();
        }

        private void CreateFile(string path, string dataToWrite)
        {
            try
            {
                using (System.IO.FileStream fs = File.Create(path))
                {
                    byte[] dataToWriteArr = new UTF8Encoding(true).GetBytes(dataToWrite);
                    fs.Write(dataToWriteArr, 0, dataToWrite.Length);
                }

                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ButtonForCancel_Click(object sender, EventArgs e)
        {
            MainForm.settingsOpen = false;
            ActiveForm.Close();
        }

        private void updateSettings()
        {
            string settings = File.ReadAllText(Environment.CurrentDirectory + "\\" + "settings.json");
            Settings settingsConfig = JsonConvert.DeserializeObject<Settings>(settings);
            CheckForInsertAtCursor.Checked = settingsConfig.insertAtCursor;
            CheckForUseNewLine.Checked = settingsConfig.useNewLine;
            CheckForUseSend.Checked = settingsConfig.useSend;
            CheckForMoveInsertion.Checked = settingsConfig.moveInsertionPoint;

            TextBoxForModKey.Text = settingsConfig.defaultModKey;
            TextBoxForQuickVar.Text = settingsConfig.quickVar;
            TextBoxForFileName.Text = settingsConfig.defaultFileName;
        }
    }
}
