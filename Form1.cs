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

namespace AHKMaker
{
    public partial class Form1 : Form
    {
        bool typeOpen = false;
        bool popupOpen = false;
        bool addWait = false;

        private void Visibility(Control[] CurrentControl, bool visibility)
        {
            foreach (Control control in CurrentControl)
            {
                control.Visible = visibility;
            }
        }

        private bool IsBlank(TextBox CurrentTextBox)
        {
            if (CurrentTextBox.Text == "")
            {
                return true;
            }
            else if (CurrentTextBox.Text.Trim() == "")
            {
                return true;
            }
            else
            {
                return false;
            }
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

        public Form1()
        {
            InitializeComponent();
        }

        private void MousePositionButton_Click(object sender, EventArgs e)
        {

            Thread.Sleep((Convert.ToInt32(SleepTimeUpDown.Value) * 1000));

            Point p = Control.MousePosition;

            MousePosXTextBox.Text = p.X.ToString();
            MousePosYTextBox.Text = p.Y.ToString();
        }

        private void ClickAction_Click(object sender, EventArgs e)
        {
            String XLocation = "X";
            String YLocation = "Y";

            if (XYCheckBox.Checked)
            {
                XLocation = MousePosXTextBox.Text;
                YLocation = MousePosYTextBox.Text;
            }

            MainCode.AppendText(String.Format("MouseMove, {0}, {1}\r\nClick\r\n", XLocation, YLocation));
        }

        private void AddType_Click(object sender, EventArgs e)
        {
            Control[] activeControls = { TypeTextLabel, TypeTextInput, TypeTextConfirm, InsertModKey, InsertModKeyLabel };

            if (typeOpen == true)
            {
                typeOpen = false;
                Visibility(activeControls, false);
                return;
            }

            Visibility(activeControls, true);
            typeOpen = true;

            activeControls[1].Focus();

        }

        private void TypeTextConfirm_Click(object sender, EventArgs e)
        {
            Control[] activeControls = { TypeTextLabel, TypeTextInput, TypeTextConfirm, InsertModKey, InsertModKeyLabel };

            MainCode.AppendText(String.Format("Send, {0}\r\n", TypeTextInput.Text));

            Visibility(activeControls, false);
            typeOpen = false;
        }

        private void AddPopup_Click(object sender, EventArgs e)
        {
            Control[] activeControls = { PopupTextLabel, PopupTextInput, PopupTitleInput, PopupTitleLabel, PopupConfirm };

            if (popupOpen == true)
            {
                popupOpen = false;
                Visibility(activeControls, false);
                return;
            }

            Visibility(activeControls, true);
            popupOpen = true;

            activeControls[1].Focus();
        }

        private void PopupConfirm_Click(object sender, EventArgs e)
        {
            Control[] activeControls = { PopupTextLabel, PopupTextInput, PopupTitleInput, PopupTitleLabel, PopupConfirm };

            MainCode.AppendText(String.Format("MsgBox, ,{0}, {1}\r\n", PopupTitleInput.Text, PopupTextInput.Text));

            Visibility(activeControls, false);
            popupOpen = false;
        }

        private void AddWait_Click(object sender, EventArgs e)
        {
            Control[] activeControls = { WaitLabel, WaitInput, WaitConfirm };

            if (addWait == true)
            {
                addWait = false;
                Visibility(activeControls, false);
                return;
            }

            Visibility(activeControls, true);
            addWait = true;
        }

        private void WaitConfirm_Click(object sender, EventArgs e)
        {
            Control[] activeControls = { WaitLabel, WaitInput, WaitConfirm };

            Visibility(activeControls, false);
            addWait = false;

            MainCode.AppendText(String.Format("Sleep, {0}\r\n", WaitInput.Text));
        }

        private void AddCustomMod_Click(object sender, EventArgs e)
        {
            RadioButton[] radios = { ControlMod, AltMod, ShiftMod };
            string modifier = "Error";

            for (int i = 0; i < radios.Length; i++)
            {
                if (radios[i].Checked)
                {
                    switch (i)
                    {
                        case 0: 
                            modifier = "^";
                            break;
                        case 1:
                            modifier = "!";
                            break;
                        case 2:
                            modifier = "+";
                            break;
                        default:
                            modifier = "";
                            break;
                    }
                }
            }

            StoredMod.Text = String.Format("{0}{1}", modifier, ModKeyInput.Text);
        }

        private void HotKey_Click(object sender, EventArgs e)
        {
            MainCode.AppendText(StoredMod.Text + "::\r\n");
        }

        private void InsertModKey_Click(object sender, EventArgs e)
        {
            TypeTextInput.AppendText(StoredMod.Text);
            TypeTextInput.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateFile(Environment.CurrentDirectory + "\\" + FileNameInput.Text + ".ahk", MainCode.Text);
        }
    }
}
