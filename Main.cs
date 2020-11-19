using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHK_Visual_2._0
{
    public partial class Main : Form
    {
        String lastModKey;
        bool indent = false;

        public Main()
        {
            InitializeComponent();
        }

        private void CreateFile(string path, string dataToWrite)
        {
            try
            {
                using (FileStream fs = File.Create(path))
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

        private void ctrlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Helper.CheckBoxChecker(ctrlCheckBox, savedModifierInput, '^');
            modifierKeyInput.Focus();
        }

        private void altCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Helper.CheckBoxChecker(altCheckBox, savedModifierInput, '!');
            modifierKeyInput.Focus();
        }

        private void shiftCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Helper.CheckBoxChecker(shiftCheckBox, savedModifierInput, '+');
            modifierKeyInput.Focus();
        }

        private void winCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Helper.CheckBoxChecker(winCheckBox, savedModifierInput, '#');
            modifierKeyInput.Focus();
        }

        private void modifierKeyInput_TextChanged(object sender, EventArgs e)
        {
            savedModifierInput.AppendText(modifierKeyInput.Text);
            lastModKey = modifierKeyInput.Text;
        }

        private void modifierKeyInput_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (!String.IsNullOrEmpty(modifierKeyInput.Text))
                {
                    int pos = savedModifierInput.Text.IndexOf(lastModKey);
                    savedModifierInput.Text = savedModifierInput.Text.Remove(pos, 1);
                }
            }
        }

        private void hotKeyAssignButton_Click(object sender, EventArgs e)
        {
            MainCode.AppendText(savedModifierInput.Text + "::\r\n");
        }

        private void FileNameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ExportButton.Enabled = true;
                FileNameInput.Enabled = false;
                ChangeNameButton.Enabled = true;
            }
        }

        private void ChangeNameButton_Click(object sender, EventArgs e)
        {
            ExportButton.Enabled = false;
            FileNameInput.Enabled = true;
            ChangeNameButton.Enabled = false;
        }

        private void CreateLoopButton_Click(object sender, EventArgs e)
        {
            EndLoopButtonGlobal.Visible = true;
            EndLoopButton.Visible = true;
            MainCode.AppendText("Loop, " + LoopAmountBox.Value.ToString() + " {\r\n    ");
            indent = true;
        }

        private void EndLoopButton_Click(object sender, EventArgs e)
        {      
            EndLoopButtonGlobal.Visible = false;
            EndLoopButton.Visible = false;
            MainCode.AppendText("}\r\n");
            indent = false;
        }

        private void EndLoopButtonGlobal_Click(object sender, EventArgs e)
        {
            EndLoopButtonGlobal.Visible = false;
            EndLoopButton.Visible = false;
            MainCode.AppendText("}\r\n");
            indent = false;
        }

        private void ModkeyButton_Click(object sender, EventArgs e)
        {
            TextInput.AppendText(savedModifierInput.Text);
        }

        private void SpecialKeyInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextInput.AppendText(SpecialKeyInput.Text);
        }

        private void AddToMainCode_Click(object sender, EventArgs e)
        {
            MainCode.AppendText("Send, " + TextInput.Text + " \r\n");
            Helper.Indent(MainCode, indent);
        }

        private void SendMsgBoxButton_Click(object sender, EventArgs e)
        {
            MainCode.AppendText("MsgBox, " + MsgBoxTitle.Text + ", " + MsgBoxTextInput.Text + "\r\n");
            Helper.Indent(MainCode, indent);
        }

        private void MilisecondsCheck_CheckedChanged(object sender, EventArgs e)
        {
            WaitTimeInput.Maximum = 10000;
            WaitTimeInput.Minimum = 500;
            WaitTimeInput.Increment = 500;
        }

        private void SecondsCheck_CheckedChanged(object sender, EventArgs e)
        {
            WaitTimeInput.Maximum = 10;
            WaitTimeInput.Minimum = 1;
            WaitTimeInput.Increment = 1;
        }

        private void MousePositionButton_Click(object sender, EventArgs e)
        {
            int sleepTime;

            if (SecondsCheck.Checked)
            {
                sleepTime = Convert.ToInt32(WaitTimeInput.Value) * 1000;
            }
            else
            {
                sleepTime = Convert.ToInt32(WaitTimeInput.Value);
            }

            Thread.Sleep(sleepTime);

            Point p = Control.MousePosition;

            MousePosXTextBox.Text = p.X.ToString();
            MousePosYTextBox.Text = p.Y.ToString();
        }

        private void CreateClickButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool click = ClickCheck.Checked;
            bool xy = XYCheck.Checked;
            string x = "";
            string y = "";
            string controlUsed = "MouseMove, ";
            string toClick = "";

            if (xy)
            {
                x = MousePosXTextBox.Text;
                y = MousePosYTextBox.Text;
            }

            if (click)
            {
                toClick = "Click";
            }

            if (NumOfClickInput.Value == 1)
            {
                MainCode.AppendText(controlUsed + " " + x + ", " + y + "\r\n" + toClick + "\r\n");
            }
            else
            {
                sb.Append("Loop, ");
                sb.Append(NumOfClickInput.Value + " {\r\n");
                sb.Append(controlUsed + " " + x + ", " + y + "\r\n" + toClick + "\r\n");
                sb.Append("}\r\n");

                MainCode.AppendText(sb.ToString());
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            CreateFile(Environment.CurrentDirectory + "\\" + FileNameInput.Text + ".ahk", MainCode.Text);
        }
    }
}
