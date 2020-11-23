using System;
using System.Collections.Generic; 
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AHK_Visual_2._0
{
    public partial class MainForm : Form
    {
        String lastModKey;
        String[] currXY = new String[4];
        int topTab = 71;
        int selectedTab = 0;
        int activeLoops = 0;
        bool indent = false;
        bool hotKeySet = false;
        bool mousePosAdded = false;
        bool msgBoxVarAdded = false;
        bool insertAtCursor = false;
        bool newLine = false;
        bool useSend = false;


        public MainForm()
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

        //Special Tab Start

        private void ctrlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Helper.CheckBoxChecker(ctrlCheckBox, CurrModKeyInput, '^');
            Helper.CheckBoxChecker(ctrlCheckBox, savedModifierInput, '^');
            modifierKeyInput.Focus();
        }

        private void altCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Helper.CheckBoxChecker(altCheckBox, CurrModKeyInput, '!');
            Helper.CheckBoxChecker(altCheckBox, savedModifierInput, '!');
            modifierKeyInput.Focus();
        }

        private void shiftCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Helper.CheckBoxChecker(shiftCheckBox, CurrModKeyInput, '+');
            Helper.CheckBoxChecker(shiftCheckBox, savedModifierInput, '+');
            modifierKeyInput.Focus();
        }

        private void winCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Helper.CheckBoxChecker(winCheckBox, CurrModKeyInput, '#');
            Helper.CheckBoxChecker(winCheckBox, savedModifierInput, '#');
            modifierKeyInput.Focus();
        }

        private void modifierKeyInput_TextChanged(object sender, EventArgs e)
        {
            CurrModKeyInput.AppendText(modifierKeyInput.Text);
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
                    CurrModKeyInput.Text = CurrModKeyInput.Text.Remove(pos, 1);
                }
            }
        }

        private void CreateLoopButton_Click(object sender, EventArgs e)
        {
            activeLoops++;

            EndLoopButtonGlobal.Enabled = true;
            EndLoopButton.Enabled = true;

            CheckForSend.Enabled = false;
            indent = true;

            MainCode.AppendText("Loop, " + LoopAmountBox.Value.ToString() + " {\r\n");

            Helper.Indent(MainCode, activeLoops, indent);

            CheckForSend.Enabled = true;
        }

        private void EndLoopButton_Click(object sender, EventArgs e)
        {
            activeLoops--;

            if (activeLoops == 0)
            {
                EndLoopButtonGlobal.Enabled = false;
                EndLoopButton.Enabled = false;
                indent = false;
            }

            MainCode.AppendText("}\r\n");
            Helper.Indent(MainCode, activeLoops, indent);

        }

        private void EndLoopButtonGlobal_Click(object sender, EventArgs e)
        {
            activeLoops--;


            if (activeLoops == 0)
            {
                EndLoopButtonGlobal.Enabled = false;
                EndLoopButton.Enabled = false;
                indent = false;
            }
            
            MainCode.AppendText("}\r\n");
            Helper.Indent(MainCode, activeLoops, indent);
        }

        private void SleepInsertButton_Click(object sender, EventArgs e)
        {
            CheckForSend.Enabled = false;
            String text = "Sleep, " + SleepInput.Value;

            Helper.WriteToBox(CheckToInsertAtCursor, CheckForNewLine, CheckForSend, text, MainCode, selectedTab);
            Helper.Indent(MainCode, activeLoops, indent);

            if (CheckForMoveInsertionPoint.Checked)
            {
                selectedTab += text.Length;
            }
            CheckForSend.Enabled = true;
        }

        private void ButtonForAddVariable_Click(object sender, EventArgs e)
        {
            bool isAdded = false;
            CheckForSend.Enabled = false;

            if (InputForNameOfVar.Text.Length == 0)
            {
                MessageBox.Show("Variable needs a name.");
                return;
            }

            foreach (String currentControl in ComboForAllVariables.Items)
            {
                if (currentControl.Equals(InputForNameOfVar.Text))
                {
                    isAdded = true;
                }
            }

            if (CheckForSaveOnly.Checked && !isAdded)
            {
                ComboForAllVariables.Items.Add(InputForNameOfVar.Text);
                ComboForEqualVarOne.Items.Add(InputForNameOfVar.Text);
                ComboForEqualVarTwo.Items.Add(InputForNameOfVar.Text);
                return;
            }

            if (!isAdded)
            {
                ComboForAllVariables.Items.Add(InputForNameOfVar.Text);
                ComboForEqualVarOne.Items.Add(InputForNameOfVar.Text);
                ComboForEqualVarTwo.Items.Add(InputForNameOfVar.Text);
            }

            String text = InputForNameOfVar.Text + " = " + InputForValueOfVariable.Text;
            
            Helper.WriteToBox(CheckToInsertAtCursor, CheckForNewLine, CheckForSend, text, MainCode, selectedTab);
            Helper.Indent(MainCode, activeLoops, indent);

            if (CheckForMoveInsertionPoint.Checked)
            {
                selectedTab += text.Length;
            }
            CheckForSend.Enabled = true;
        }

        private void ButtonForVariableHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Variable of Value is only saved when sending directly to Code Window");
        }

        private void ButtonForSaveVariableHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved Variables are stored in the text tab");
        }

        //Special Tab End



        //Main Tab Start

        private void hotKeyAssignButton_Click(object sender, EventArgs e)
        {
            hotKeySet = true;
            if (!CheckForTopOfCode.Checked)
            {
                MainCode.AppendText(savedModifierInput.Text + "::\r\n");
                return;
            }

            MainCode.Text = MainCode.Text.Insert(70, "\r\n" + savedModifierInput.Text + "::\r\n");
            topTab += savedModifierInput.TextLength + 3;
        }

        private void FileNameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExportButton.Enabled = true;
                FileNameInput.Enabled = false;
                ChangeNameButton.Enabled = true;
                ToolStripButtonExport.Enabled = true;
            }
        }

        private void FileNameInput_KeyDown()
        {
            ExportButton.Enabled = true;
            FileNameInput.Enabled = false;
            ChangeNameButton.Enabled = true;
            ToolStripButtonExport.Enabled = true;
        }

        private void ChangeNameButton_Click(object sender, EventArgs e)
        {
            ExportButton.Enabled = false;
            FileNameInput.Enabled = true;
            ChangeNameButton.Enabled = false;
            ToolStripButtonExport.Enabled = false;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

            if (!hotKeySet)
            {
                if (MessageBox.Show("You have not set a hotkey, do you still want to export the file?", "Continue?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            CreateFile(Environment.CurrentDirectory + "\\" + FileNameInput.Text + ".ahk", MainCode.Text);
        }


        //Main Tab End




        //Text Tab Start
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
            String text = TextInput.Text;
            
            Helper.WriteToBox(CheckToInsertAtCursor, CheckForNewLine, CheckForSend, text, MainCode, selectedTab);
            Helper.Indent(MainCode, activeLoops, indent);

            if (CheckForMoveInsertionPoint.Checked)
            {
                selectedTab += text.Length;
            }
        }

        private void SendMsgBoxButton_Click(object sender, EventArgs e)
        {

            String text = "MsgBox,, " + MsgBoxTitle.Text + ", " + MsgBoxTextInput.Text;

            Helper.WriteToBox(CheckToInsertAtCursor, CheckForNewLine, CheckForSend, text, MainCode, selectedTab);
            Helper.Indent(MainCode, activeLoops, indent);

            if (CheckForMoveInsertionPoint.Checked)
            {
                selectedTab += text.Length;
            }
        }

        private void ButtonToAddCurrentVariable_Click(object sender, EventArgs e)
        {
            if (!CheckForAddToMsgBox.Checked)
            {
                TextInput.AppendText("%" + ComboForAllVariables.Text + "% ");
            }
            else
            {
                MsgBoxTextInput.AppendText("%" + ComboForAllVariables.Text + "% ");
            }
        }

        private void ButtonForClearingTextWindow_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to clear all?", "Clear all", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TextInput.Text = "";
            }
        }

        private void ButtonForCurrentMouseVariable_Click(object sender, EventArgs e)
        {
            if (!mousePosAdded)
            {
                ComboForAllVariables.Items.Add("MouseX");
                ComboForAllVariables.Items.Add("MouseY");
                ComboForEqualVarOne.Items.Add("MouseX");
                ComboForEqualVarOne.Items.Add("MouseY");
                ComboForEqualVarTwo.Items.Add("MouseX");
                ComboForEqualVarTwo.Items.Add("MouseY");
            }

            String text = "MouseGetPos, MouseX, MouseY";

            Helper.WriteToBox(CheckToInsertAtCursor, CheckForNewLine, CheckForSend, text, MainCode, selectedTab);
            Helper.Indent(MainCode, activeLoops, indent);

            if (CheckForMoveInsertionPoint.Checked)
            {
                selectedTab += text.Length;
            }
            mousePosAdded = true;
        }

        private void ButtonToAddMouseVars_Click(object sender, EventArgs e)
        {
            mousePosAdded = true;
  
            String text = "MouseMove, %MouseX%, %MouseY%";

            Helper.WriteToBox(CheckToInsertAtCursor, CheckForNewLine, CheckForSend, text, MainCode, selectedTab);
            Helper.Indent(MainCode, activeLoops, indent);

            if (CheckForMoveInsertionPoint.Checked)
            {
                selectedTab += text.Length;
            }
        }

        private void ButtonToSendMsgBoxToCode_Click(object sender, EventArgs e)
        {
            if (!msgBoxVarAdded)
            {
                ComboForAllVariables.Items.Add("InputResult");
                ComboForEqualVarOne.Items.Add("InputResult");
                ComboForEqualVarTwo.Items.Add("InputResult");
            }

            String text = "InputBox, InputResult, " + InputForMessageBoxTitle.Text + ", " + InputForMessageBoxPrompt.Text;
            
            Helper.WriteToBox(CheckToInsertAtCursor, CheckForNewLine, CheckForSend, text, MainCode, selectedTab);
            Helper.Indent(MainCode, activeLoops, indent);

            if (CheckForMoveInsertionPoint.Checked)
            {
                selectedTab += text.Length;
            }
            msgBoxVarAdded = true;
        }


        private void CheckToInsertAtCursor_CheckedChanged(object sender, EventArgs e)
        {
            insertAtCursor = !insertAtCursor;
        }

        private void CheckForNewLine_CheckedChanged(object sender, EventArgs e)
        {
            newLine = !newLine;
        }

        private void CheckForSend_CheckedChanged(object sender, EventArgs e)
        {
            useSend = !useSend;
        }

        private void ButtonForVarEqualTo_Click(object sender, EventArgs e)
        {
            String text = ComboForEqualVarOne.Text + " := " + ComboForEqualVarTwo.Text;

            Helper.WriteToBox(CheckToInsertAtCursor, CheckForNewLine, CheckForSend, text, MainCode, selectedTab);
            if (CheckForMoveInsertionPoint.Checked)
            {
                selectedTab += text.Length;
            }
        }

        private void CheckForLargeTextBox_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckForLargeTextBox.Checked)
            {
                //Moved
                tabControl2.Size = new Size(240, 111);
                tabControl2.Location = new Point(4, 152);
                TextInput.Size = new Size(237, 86);
                AddToMainCode.Location = new Point(4, 122);
                ButtonForClearingTextWindow.Location = new Point(197, 122);
            }
            else
            {
                //Default
                tabControl2.Size = new Size(243, 173);
                tabControl2.Location = new Point(3, 83);
                TextInput.Size = new Size(237, 18);
                TextInput.Location = new Point(3, 30);
                AddToMainCode.Location = new Point(4, 57);
                ButtonForClearingTextWindow.Location = new Point(197, 57);
            }
        }

        //Text Tab End



        //Mouse Tab Start
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
            String mill_second;
            int sleepTime;
            int loopNumber = 1;
            bool twoPoints = TwoPointsCheck.Checked;

            if (SecondsCheck.Checked)
            {
                mill_second = " Second(s)";
            }
            else
            {
                mill_second = " Milliseconds";
            }

            if (twoPoints)
            {
                loopNumber = 2;
            }

            while (loopNumber != 0)
            {
                if (SecondsCheck.Checked)
                {
                    sleepTime = Convert.ToInt32(WaitTimeInput.Value) * 1000;
                }
                else
                {
                    sleepTime = Convert.ToInt32(WaitTimeInput.Value);
                }

                if (twoPoints)
                {
                    if (loopNumber == 1)
                    {
                        MessageBox.Show("Click to track point 2 after " + WaitTimeInput.Value + mill_second);
                    }

                    sleepTime += sleepTime / 2;
                }

                Thread.Sleep(sleepTime);

                Point p = Control.MousePosition;

                MousePosXTextBox.Text = p.X.ToString();
                MousePosYTextBox.Text = p.Y.ToString();

                //Continued Tab
                X2Input.Text = CurrXInput.Text;
                Y2Input.Text = CurrYInput.Text;

                CurrXInput.Text = MousePosXTextBox.Text;
                CurrYInput.Text = MousePosYTextBox.Text;

                loopNumber--;
            }
            currXY[0] = CurrXInput.Text;
            currXY[1] = CurrYInput.Text;
            currXY[2] = MousePosXTextBox.Text;
            currXY[3] = MousePosYTextBox.Text;
        }

        private void CreateClickButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool click = ClickCheck.Checked;
            bool xy = XYCheck.Checked;
            String x = "";
            String y = "";
            String controlUsed = "MouseMove, ";
            String toClick = "";
            String text;
            String text2;

            CheckForSend.Checked = false;


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
                text = controlUsed + " " + x + ", " + y;
                text2 = toClick + "\r\n";

                Helper.WriteToBox(CheckToInsertAtCursor, CheckForNewLine, CheckForSend, text, MainCode, selectedTab);
                Helper.Indent(MainCode, activeLoops, indent);

                Helper.WriteToBox(CheckToInsertAtCursor, CheckForNewLine, CheckForSend, text2, MainCode, selectedTab);
                Helper.Indent(MainCode, activeLoops, indent);

                if (CheckForMoveInsertionPoint.Checked)
                {
                    selectedTab += text.Length;
                }
            }
            else
            {

                sb.Append(controlUsed + " " + x + ", " + y + "\r\n");
                sb.Append("Loop, ");
                sb.Append(NumOfClickInput.Value + " {\r\n                ");
                sb.Append(toClick + "\r\n");
                sb.Append("}\r\n");

                text = sb.ToString();

                Helper.WriteToBox(CheckToInsertAtCursor, CheckForNewLine, CheckForSend, text, MainCode, selectedTab);
                Helper.Indent(MainCode, activeLoops, indent);

            }

            if (CheckForMoveInsertionPoint.Checked)
            {
                selectedTab += text.Length;
            }

            CheckForSend.Checked = true;
        }

        private void ButtonForMouseClickDrag_Click(object sender, EventArgs e)
        {
            String x1 = "X1", y1 = "Y1", x2 = "X2", y2 = "Y2", speed = UpDownSpeed.Value.ToString(), mouseButton;
            String temp;
            CheckForSend.Checked = false;

            if (CheckForXY1.Checked)
            {
                x2 = CurrXInput.Text;
                y2 = CurrYInput.Text;
            }

            if (CheckForX2Y2.Checked)
            {
                x1 = X2Input.Text;
                y1 = Y2Input.Text;
            }

            if (CheckForInvert.Checked)
            {
                temp = x1;
                x1 = x2;
                x2 = temp;

                temp = y1;
                y1 = y2;
                y2 = temp;
            }

            mouseButton = ComboForMouseButton.Text;

            String text = "MouseClickDrag, " + mouseButton + ", " + x1 + ", " + y1 + ", " + x2 + ", " + y2;

            Helper.WriteToBox(CheckToInsertAtCursor, CheckForNewLine, CheckForSend, text, MainCode, selectedTab);
            Helper.Indent(MainCode, activeLoops, indent);

            if (CheckForMoveInsertionPoint.Checked)
            {
                selectedTab += text.Length;
            }
            CheckForSend.Checked = true;
        }

        //Mouse Tab End

        //Tool Strip Start

        private void ToolStripButtonExport_Click(object sender, EventArgs e)
        {
            if (!hotKeySet)
            {
                if (MessageBox.Show("You have not set a hotkey, do you still want to export the file?", "Continue?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            CreateFile(Environment.CurrentDirectory + "\\" + FileNameInput.Text + ".ahk", MainCode.Text);
        }

        private void EndHotKey_Click(object sender, EventArgs e)
        {
            MainCode.AppendText("return\r\n");
            Helper.Indent(MainCode, activeLoops, indent);
        }

        private void ButtonForAddVarGlobal_Click(object sender, EventArgs e)
        {
            String text = InputForQuickValue.Text;

            Helper.WriteToBox(CheckToInsertAtCursor, CheckForNewLine, CheckForSend, text, MainCode, selectedTab);
            Helper.Indent(MainCode, activeLoops, indent);

            if (CheckForMoveInsertionPoint.Checked)
            {
                selectedTab += text.Length;
            }
        }

        private void ImportFile_Click(object sender, EventArgs e)
        {
            String fileName = Helper.fileParse();

            if (fileName.Length == 0)
            {
                return;
            }

            StreamReader fs = new StreamReader(fileName);
            List<String> fileContent = new List<String>();
            String line;

            while ((line = fs.ReadLine()) != null)
            {
                fileContent.Add(line);
            }

            MainCode.Text = string.Join("\r\n", fileContent);

            hotKeySet = true;
            FileNameInput.Text = Path.GetFileNameWithoutExtension(fileName);
            FileNameInput_KeyDown();
        }

        private void MainCode_Leave(object sender, EventArgs e)
        {
            selectedTab = MainCode.SelectionStart;
        }

        //Tool Strip End

    }
}
