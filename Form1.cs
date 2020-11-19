using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AHKMaker
{
    public partial class Form1 : Form
    {
        bool clickOpen = false;
        bool typeOpen = false;
        bool popupOpen = false;
        bool addWait = false;
        bool loopOpen = false;
        bool indent = false;

        private void IsIndented()
        {
            if (indent)
            {
                MainCode.AppendText("   ");
            }
        }

        private bool Visibility(Control[] CurrentControl, bool visibility)
        {
            foreach (Control control in CurrentControl)
            {
                control.Visible = visibility;
            }

            return visibility;
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
            Control[] activeControls = { XYCheckBox, MouseButtonLabel, MouseCombo, NumClickLabel, NumClickInput, ClickSend };

            if (clickOpen)
            {
                clickOpen = Visibility(activeControls, false);
                return;
            }
            
            clickOpen = Visibility(activeControls, true);

        }

        private void ClickSend_Click(object sender, EventArgs e)
        {
            Control[] activeControls = { XYCheckBox, MouseButtonLabel, MouseCombo, NumClickLabel, NumClickInput, ClickSend };
            String XLocation = "";
            String YLocation = "";
            String MouseButton = MouseCombo.Text;
            int numOfClicks = Convert.ToInt32(NumClickInput.Value);
            bool click = false;



            if (XYCheckBox.Checked)
            {
                XLocation = MousePosXTextBox.Text;
                YLocation = MousePosYTextBox.Text;
            }

            if (ClickOption.Checked)
            {
                click = true;
            }

            if (click)
            {
                MainCode.AppendText(String.Format("MouseClick, {0}, {1}, {2}, {3} \r\n", MouseButton, XLocation, YLocation, numOfClicks));
            }
            else
            {
                MainCode.AppendText(String.Format("MouseMove, {0}, {1} \r\n", XLocation, YLocation));
            }

            clickOpen = Visibility(activeControls, false);
            IsIndented();
        }

        private void AddType_Click(object sender, EventArgs e)
        {
            Control[] activeControls = { TypeTextLabel, TypeTextInput, TypeTextConfirm, InsertModKey, InsertModKeyLabel };

            if (typeOpen)
            {
                typeOpen = false;
                Visibility(activeControls, false);
                return;
            }

            typeOpen = Visibility(activeControls, true);
            

            activeControls[1].Focus();

        }


        private void TypeTextConfirm_Click(object sender, EventArgs e)
        {
            Control[] activeControls = { TypeTextLabel, TypeTextInput, TypeTextConfirm, InsertModKey, InsertModKeyLabel };

            MainCode.AppendText(String.Format("Send, {0}\r\n", TypeTextInput.Text));

            typeOpen = Visibility(activeControls, false);
            IsIndented();
        }

        private void AddPopup_Click(object sender, EventArgs e)
        {
            Control[] activeControls = { PopupTextLabel, PopupTextInput, PopupTitleInput, PopupTitleLabel, PopupConfirm };

            if (popupOpen)
            {
                
                popupOpen = Visibility(activeControls, false);
                return;
            }

            popupOpen = Visibility(activeControls, true);


            activeControls[1].Focus();
        }

        private void PopupConfirm_Click(object sender, EventArgs e)
        {
            Control[] activeControls = { PopupTextLabel, PopupTextInput, PopupTitleInput, PopupTitleLabel, PopupConfirm };

            MainCode.AppendText(String.Format("MsgBox, ,{0}, {1}\r\n", PopupTitleInput.Text, PopupTextInput.Text));

            popupOpen = Visibility(activeControls, false);
            IsIndented();
        }

        private void AddWait_Click(object sender, EventArgs e)
        {
            Control[] activeControls = { WaitLabel, WaitInput, WaitConfirm };

            if (addWait)
            {
                addWait = Visibility(activeControls, false);
                return;
            }

            addWait = Visibility(activeControls, true);
        }

        private void WaitConfirm_Click(object sender, EventArgs e)
        {
            Control[] activeControls = { WaitLabel, WaitInput, WaitConfirm };

            addWait = Visibility(activeControls, false);

            MainCode.AppendText(String.Format("Sleep, {0}\r\n", WaitInput.Text));

            IsIndented();
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
            IsIndented();
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

        private void AddLoop_Click(object sender, EventArgs e)
        {
            Control[] activeControls = { LoopAmountLabel, NumOfLoops, LoopAdd };

            if (loopOpen)
            {
                loopOpen = Visibility(activeControls, false);
                return;
            }

            loopOpen = Visibility(activeControls, true);

        }

        private void LoopAdd_Click(object sender, EventArgs e)
        {
            int numOfLoops = Convert.ToInt32(NumOfLoops.Value);

            EndLoop.Visible = true;
            indent = true;

            MainCode.AppendText("Loop, " + numOfLoops + " { \r\n    ");
        }

        private void EndLoop_Click(object sender, EventArgs e)
        {
            EndLoop.Visible = false;
            indent = false;

            MainCode.AppendText("}\r\n");
        }
    }
}
