namespace AHK_Visual_2._0
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabMain = new System.Windows.Forms.TabPage();
            this.ChangeNameButton = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileNameInput = new System.Windows.Forms.TextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.hotKeyAssignButton = new System.Windows.Forms.Button();
            this.TabMouse = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.TabMouseControls = new System.Windows.Forms.TabPage();
            this.TabMouseContinued = new System.Windows.Forms.TabPage();
            this.TabKeyBoard = new System.Windows.Forms.TabPage();
            this.SpecialKeyLabel = new System.Windows.Forms.Label();
            this.SpecialKeyInput = new System.Windows.Forms.ComboBox();
            this.AddModButtonLabel = new System.Windows.Forms.Label();
            this.ModkeyButton = new System.Windows.Forms.Button();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.TextTypeLabel = new System.Windows.Forms.Label();
            this.TabSpecial = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.ModKeyTab = new System.Windows.Forms.TabPage();
            this.savedModifierLabel = new System.Windows.Forms.Label();
            this.savedModifierInput = new System.Windows.Forms.TextBox();
            this.modifierKeyInput = new System.Windows.Forms.TextBox();
            this.modifierKeyLabel = new System.Windows.Forms.Label();
            this.ControlModifierBox = new System.Windows.Forms.GroupBox();
            this.winCheckBox = new System.Windows.Forms.CheckBox();
            this.shiftCheckBox = new System.Windows.Forms.CheckBox();
            this.altCheckBox = new System.Windows.Forms.CheckBox();
            this.ctrlCheckBox = new System.Windows.Forms.CheckBox();
            this.LoopTab = new System.Windows.Forms.TabPage();
            this.EndLoopButton = new System.Windows.Forms.Button();
            this.CreateLoopButton = new System.Windows.Forms.Button();
            this.LoopAmountBox = new System.Windows.Forms.NumericUpDown();
            this.LoopAmountLabel = new System.Windows.Forms.Label();
            this.MainCode = new System.Windows.Forms.TextBox();
            this.EndLoopButtonGlobal = new System.Windows.Forms.Button();
            this.AddToMainCode = new System.Windows.Forms.Button();
            this.MsgBoxLabel = new System.Windows.Forms.Label();
            this.MsgBoxTitle = new System.Windows.Forms.TextBox();
            this.MsgBoxTextLabel = new System.Windows.Forms.Label();
            this.MsgBoxTextInput = new System.Windows.Forms.TextBox();
            this.SendMsgBoxButton = new System.Windows.Forms.Button();
            this.MousePositionButton = new System.Windows.Forms.Button();
            this.MilisecondsCheck = new System.Windows.Forms.RadioButton();
            this.SecondsCheck = new System.Windows.Forms.RadioButton();
            this.WaitTimeInput = new System.Windows.Forms.NumericUpDown();
            this.MousePosXTextBox = new System.Windows.Forms.TextBox();
            this.MousePosYTextBox = new System.Windows.Forms.TextBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.CreateClickButton = new System.Windows.Forms.Button();
            this.ClickCheck = new System.Windows.Forms.CheckBox();
            this.XYCheck = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MouseButtonLabel = new System.Windows.Forms.Label();
            this.NumOfClickInput = new System.Windows.Forms.NumericUpDown();
            this.NumOfClickLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.TabMouse.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.TabMouseControls.SuspendLayout();
            this.TabKeyBoard.SuspendLayout();
            this.TabSpecial.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.ModKeyTab.SuspendLayout();
            this.ControlModifierBox.SuspendLayout();
            this.LoopTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoopAmountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitTimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfClickInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabMain);
            this.tabControl1.Controls.Add(this.TabMouse);
            this.tabControl1.Controls.Add(this.TabKeyBoard);
            this.tabControl1.Controls.Add(this.TabSpecial);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(251, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.ChangeNameButton);
            this.TabMain.Controls.Add(this.FileNameLabel);
            this.TabMain.Controls.Add(this.FileNameInput);
            this.TabMain.Controls.Add(this.ExportButton);
            this.TabMain.Controls.Add(this.hotKeyAssignButton);
            this.TabMain.Location = new System.Drawing.Point(4, 22);
            this.TabMain.Name = "TabMain";
            this.TabMain.Padding = new System.Windows.Forms.Padding(3);
            this.TabMain.Size = new System.Drawing.Size(243, 404);
            this.TabMain.TabIndex = 1;
            this.TabMain.Text = "Main Tab";
            this.TabMain.UseVisualStyleBackColor = true;
            // 
            // ChangeNameButton
            // 
            this.ChangeNameButton.Enabled = false;
            this.ChangeNameButton.Location = new System.Drawing.Point(6, 146);
            this.ChangeNameButton.Name = "ChangeNameButton";
            this.ChangeNameButton.Size = new System.Drawing.Size(231, 30);
            this.ChangeNameButton.TabIndex = 4;
            this.ChangeNameButton.Text = "Change Name";
            this.ChangeNameButton.UseVisualStyleBackColor = true;
            this.ChangeNameButton.Click += new System.EventHandler(this.ChangeNameButton_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(6, 68);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(183, 13);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "File Name | Press enter when finished\r\n";
            // 
            // FileNameInput
            // 
            this.FileNameInput.Location = new System.Drawing.Point(6, 84);
            this.FileNameInput.Name = "FileNameInput";
            this.FileNameInput.Size = new System.Drawing.Size(231, 20);
            this.FileNameInput.TabIndex = 2;
            this.FileNameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileNameInput_KeyDown);
            // 
            // ExportButton
            // 
            this.ExportButton.Enabled = false;
            this.ExportButton.Location = new System.Drawing.Point(6, 110);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(231, 30);
            this.ExportButton.TabIndex = 1;
            this.ExportButton.Text = "Export File";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // hotKeyAssignButton
            // 
            this.hotKeyAssignButton.Location = new System.Drawing.Point(6, 6);
            this.hotKeyAssignButton.Name = "hotKeyAssignButton";
            this.hotKeyAssignButton.Size = new System.Drawing.Size(231, 51);
            this.hotKeyAssignButton.TabIndex = 0;
            this.hotKeyAssignButton.Text = "Set HotKey As Current Mod Key";
            this.hotKeyAssignButton.UseVisualStyleBackColor = true;
            this.hotKeyAssignButton.Click += new System.EventHandler(this.hotKeyAssignButton_Click);
            // 
            // TabMouse
            // 
            this.TabMouse.Controls.Add(this.tabControl2);
            this.TabMouse.Location = new System.Drawing.Point(4, 22);
            this.TabMouse.Name = "TabMouse";
            this.TabMouse.Padding = new System.Windows.Forms.Padding(3);
            this.TabMouse.Size = new System.Drawing.Size(243, 404);
            this.TabMouse.TabIndex = 0;
            this.TabMouse.Text = "Mouse Controls";
            this.TabMouse.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.TabMouseControls);
            this.tabControl2.Controls.Add(this.TabMouseContinued);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(208, 392);
            this.tabControl2.TabIndex = 0;
            // 
            // TabMouseControls
            // 
            this.TabMouseControls.Controls.Add(this.NumOfClickLabel);
            this.TabMouseControls.Controls.Add(this.NumOfClickInput);
            this.TabMouseControls.Controls.Add(this.MouseButtonLabel);
            this.TabMouseControls.Controls.Add(this.comboBox1);
            this.TabMouseControls.Controls.Add(this.XYCheck);
            this.TabMouseControls.Controls.Add(this.ClickCheck);
            this.TabMouseControls.Controls.Add(this.CreateClickButton);
            this.TabMouseControls.Controls.Add(this.YLabel);
            this.TabMouseControls.Controls.Add(this.XLabel);
            this.TabMouseControls.Controls.Add(this.MousePosYTextBox);
            this.TabMouseControls.Controls.Add(this.MousePosXTextBox);
            this.TabMouseControls.Controls.Add(this.WaitTimeInput);
            this.TabMouseControls.Controls.Add(this.SecondsCheck);
            this.TabMouseControls.Controls.Add(this.MilisecondsCheck);
            this.TabMouseControls.Controls.Add(this.MousePositionButton);
            this.TabMouseControls.Location = new System.Drawing.Point(4, 22);
            this.TabMouseControls.Name = "TabMouseControls";
            this.TabMouseControls.Padding = new System.Windows.Forms.Padding(3);
            this.TabMouseControls.Size = new System.Drawing.Size(200, 366);
            this.TabMouseControls.TabIndex = 0;
            this.TabMouseControls.Text = "Controls";
            this.TabMouseControls.UseVisualStyleBackColor = true;
            // 
            // TabMouseContinued
            // 
            this.TabMouseContinued.Location = new System.Drawing.Point(4, 22);
            this.TabMouseContinued.Name = "TabMouseContinued";
            this.TabMouseContinued.Padding = new System.Windows.Forms.Padding(3);
            this.TabMouseContinued.Size = new System.Drawing.Size(200, 366);
            this.TabMouseContinued.TabIndex = 1;
            this.TabMouseContinued.Text = "Continued";
            this.TabMouseContinued.UseVisualStyleBackColor = true;
            // 
            // TabKeyBoard
            // 
            this.TabKeyBoard.Controls.Add(this.SendMsgBoxButton);
            this.TabKeyBoard.Controls.Add(this.MsgBoxTextInput);
            this.TabKeyBoard.Controls.Add(this.MsgBoxTextLabel);
            this.TabKeyBoard.Controls.Add(this.MsgBoxTitle);
            this.TabKeyBoard.Controls.Add(this.MsgBoxLabel);
            this.TabKeyBoard.Controls.Add(this.AddToMainCode);
            this.TabKeyBoard.Controls.Add(this.SpecialKeyLabel);
            this.TabKeyBoard.Controls.Add(this.SpecialKeyInput);
            this.TabKeyBoard.Controls.Add(this.AddModButtonLabel);
            this.TabKeyBoard.Controls.Add(this.ModkeyButton);
            this.TabKeyBoard.Controls.Add(this.TextInput);
            this.TabKeyBoard.Controls.Add(this.TextTypeLabel);
            this.TabKeyBoard.Location = new System.Drawing.Point(4, 22);
            this.TabKeyBoard.Name = "TabKeyBoard";
            this.TabKeyBoard.Size = new System.Drawing.Size(243, 404);
            this.TabKeyBoard.TabIndex = 3;
            this.TabKeyBoard.Text = "Text";
            this.TabKeyBoard.UseVisualStyleBackColor = true;
            // 
            // SpecialKeyLabel
            // 
            this.SpecialKeyLabel.AutoSize = true;
            this.SpecialKeyLabel.Location = new System.Drawing.Point(15, 111);
            this.SpecialKeyLabel.Name = "SpecialKeyLabel";
            this.SpecialKeyLabel.Size = new System.Drawing.Size(85, 13);
            this.SpecialKeyLabel.TabIndex = 5;
            this.SpecialKeyLabel.Text = "Add Special Key";
            // 
            // SpecialKeyInput
            // 
            this.SpecialKeyInput.FormattingEnabled = true;
            this.SpecialKeyInput.Items.AddRange(new object[] {
            "{CapsLock} ",
            "{Space} ",
            "{Tab} ",
            "{Enter} ",
            "{Enter} ",
            "{Escape} ",
            "{Backspace} ",
            "{Delete} ",
            "{Insert} ",
            "{Home} ",
            "{End} ",
            "{Up} ",
            "{Down} ",
            "{Left} ",
            "{Right} "});
            this.SpecialKeyInput.Location = new System.Drawing.Point(3, 127);
            this.SpecialKeyInput.Name = "SpecialKeyInput";
            this.SpecialKeyInput.Size = new System.Drawing.Size(237, 21);
            this.SpecialKeyInput.TabIndex = 4;
            this.SpecialKeyInput.SelectedIndexChanged += new System.EventHandler(this.SpecialKeyInput_SelectedIndexChanged);
            // 
            // AddModButtonLabel
            // 
            this.AddModButtonLabel.AutoSize = true;
            this.AddModButtonLabel.Location = new System.Drawing.Point(43, 86);
            this.AddModButtonLabel.Name = "AddModButtonLabel";
            this.AddModButtonLabel.Size = new System.Drawing.Size(105, 13);
            this.AddModButtonLabel.TabIndex = 3;
            this.AddModButtonLabel.Text = "Add Stored Key Mod";
            // 
            // ModkeyButton
            // 
            this.ModkeyButton.Location = new System.Drawing.Point(18, 83);
            this.ModkeyButton.Name = "ModkeyButton";
            this.ModkeyButton.Size = new System.Drawing.Size(19, 19);
            this.ModkeyButton.TabIndex = 2;
            this.ModkeyButton.UseVisualStyleBackColor = true;
            this.ModkeyButton.Click += new System.EventHandler(this.ModkeyButton_Click);
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(3, 30);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(237, 47);
            this.TextInput.TabIndex = 1;
            // 
            // TextTypeLabel
            // 
            this.TextTypeLabel.AutoSize = true;
            this.TextTypeLabel.Location = new System.Drawing.Point(15, 14);
            this.TextTypeLabel.Name = "TextTypeLabel";
            this.TextTypeLabel.Size = new System.Drawing.Size(67, 13);
            this.TextTypeLabel.TabIndex = 0;
            this.TextTypeLabel.Text = "Text to Type";
            // 
            // TabSpecial
            // 
            this.TabSpecial.Controls.Add(this.tabControl3);
            this.TabSpecial.Location = new System.Drawing.Point(4, 22);
            this.TabSpecial.Name = "TabSpecial";
            this.TabSpecial.Size = new System.Drawing.Size(243, 404);
            this.TabSpecial.TabIndex = 2;
            this.TabSpecial.Text = "Special";
            this.TabSpecial.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.ModKeyTab);
            this.tabControl3.Controls.Add(this.LoopTab);
            this.tabControl3.Location = new System.Drawing.Point(17, 22);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(204, 365);
            this.tabControl3.TabIndex = 0;
            // 
            // ModKeyTab
            // 
            this.ModKeyTab.Controls.Add(this.savedModifierLabel);
            this.ModKeyTab.Controls.Add(this.savedModifierInput);
            this.ModKeyTab.Controls.Add(this.modifierKeyInput);
            this.ModKeyTab.Controls.Add(this.modifierKeyLabel);
            this.ModKeyTab.Controls.Add(this.ControlModifierBox);
            this.ModKeyTab.Location = new System.Drawing.Point(4, 22);
            this.ModKeyTab.Name = "ModKeyTab";
            this.ModKeyTab.Padding = new System.Windows.Forms.Padding(3);
            this.ModKeyTab.Size = new System.Drawing.Size(196, 339);
            this.ModKeyTab.TabIndex = 0;
            this.ModKeyTab.Text = "Mod Keys";
            this.ModKeyTab.UseVisualStyleBackColor = true;
            // 
            // savedModifierLabel
            // 
            this.savedModifierLabel.AutoSize = true;
            this.savedModifierLabel.Location = new System.Drawing.Point(35, 174);
            this.savedModifierLabel.Name = "savedModifierLabel";
            this.savedModifierLabel.Size = new System.Drawing.Size(78, 13);
            this.savedModifierLabel.TabIndex = 10;
            this.savedModifierLabel.Text = "Saved Modifier";
            // 
            // savedModifierInput
            // 
            this.savedModifierInput.Location = new System.Drawing.Point(22, 190);
            this.savedModifierInput.Name = "savedModifierInput";
            this.savedModifierInput.Size = new System.Drawing.Size(149, 20);
            this.savedModifierInput.TabIndex = 9;
            // 
            // modifierKeyInput
            // 
            this.modifierKeyInput.Location = new System.Drawing.Point(22, 137);
            this.modifierKeyInput.MaxLength = 1;
            this.modifierKeyInput.Name = "modifierKeyInput";
            this.modifierKeyInput.Size = new System.Drawing.Size(149, 20);
            this.modifierKeyInput.TabIndex = 8;
            this.modifierKeyInput.TextChanged += new System.EventHandler(this.modifierKeyInput_TextChanged);
            this.modifierKeyInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modifierKeyInput_KeyDown);
            // 
            // modifierKeyLabel
            // 
            this.modifierKeyLabel.AutoSize = true;
            this.modifierKeyLabel.Location = new System.Drawing.Point(35, 121);
            this.modifierKeyLabel.Name = "modifierKeyLabel";
            this.modifierKeyLabel.Size = new System.Drawing.Size(65, 13);
            this.modifierKeyLabel.TabIndex = 7;
            this.modifierKeyLabel.Text = "Modifier Key";
            // 
            // ControlModifierBox
            // 
            this.ControlModifierBox.Controls.Add(this.winCheckBox);
            this.ControlModifierBox.Controls.Add(this.shiftCheckBox);
            this.ControlModifierBox.Controls.Add(this.altCheckBox);
            this.ControlModifierBox.Controls.Add(this.ctrlCheckBox);
            this.ControlModifierBox.Location = new System.Drawing.Point(22, 18);
            this.ControlModifierBox.Name = "ControlModifierBox";
            this.ControlModifierBox.Size = new System.Drawing.Size(127, 90);
            this.ControlModifierBox.TabIndex = 6;
            this.ControlModifierBox.TabStop = false;
            this.ControlModifierBox.Text = "Select Modifier";
            // 
            // winCheckBox
            // 
            this.winCheckBox.AutoSize = true;
            this.winCheckBox.Location = new System.Drawing.Point(77, 56);
            this.winCheckBox.Name = "winCheckBox";
            this.winCheckBox.Size = new System.Drawing.Size(45, 17);
            this.winCheckBox.TabIndex = 3;
            this.winCheckBox.Text = "Win";
            this.winCheckBox.UseVisualStyleBackColor = true;
            this.winCheckBox.CheckedChanged += new System.EventHandler(this.winCheckBox_CheckedChanged);
            // 
            // shiftCheckBox
            // 
            this.shiftCheckBox.AutoSize = true;
            this.shiftCheckBox.Location = new System.Drawing.Point(16, 56);
            this.shiftCheckBox.Name = "shiftCheckBox";
            this.shiftCheckBox.Size = new System.Drawing.Size(47, 17);
            this.shiftCheckBox.TabIndex = 2;
            this.shiftCheckBox.Text = "Shift";
            this.shiftCheckBox.UseVisualStyleBackColor = true;
            this.shiftCheckBox.CheckedChanged += new System.EventHandler(this.shiftCheckBox_CheckedChanged);
            // 
            // altCheckBox
            // 
            this.altCheckBox.AutoSize = true;
            this.altCheckBox.Location = new System.Drawing.Point(77, 19);
            this.altCheckBox.Name = "altCheckBox";
            this.altCheckBox.Size = new System.Drawing.Size(38, 17);
            this.altCheckBox.TabIndex = 1;
            this.altCheckBox.Text = "Alt";
            this.altCheckBox.UseVisualStyleBackColor = true;
            this.altCheckBox.CheckedChanged += new System.EventHandler(this.altCheckBox_CheckedChanged);
            // 
            // ctrlCheckBox
            // 
            this.ctrlCheckBox.AutoSize = true;
            this.ctrlCheckBox.Location = new System.Drawing.Point(16, 19);
            this.ctrlCheckBox.Name = "ctrlCheckBox";
            this.ctrlCheckBox.Size = new System.Drawing.Size(41, 17);
            this.ctrlCheckBox.TabIndex = 0;
            this.ctrlCheckBox.Text = "Ctrl";
            this.ctrlCheckBox.UseVisualStyleBackColor = true;
            this.ctrlCheckBox.CheckedChanged += new System.EventHandler(this.ctrlCheckBox_CheckedChanged);
            // 
            // LoopTab
            // 
            this.LoopTab.Controls.Add(this.EndLoopButton);
            this.LoopTab.Controls.Add(this.CreateLoopButton);
            this.LoopTab.Controls.Add(this.LoopAmountBox);
            this.LoopTab.Controls.Add(this.LoopAmountLabel);
            this.LoopTab.Location = new System.Drawing.Point(4, 22);
            this.LoopTab.Name = "LoopTab";
            this.LoopTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoopTab.Size = new System.Drawing.Size(196, 339);
            this.LoopTab.TabIndex = 1;
            this.LoopTab.Text = "Loop";
            this.LoopTab.UseVisualStyleBackColor = true;
            // 
            // EndLoopButton
            // 
            this.EndLoopButton.Location = new System.Drawing.Point(6, 87);
            this.EndLoopButton.Name = "EndLoopButton";
            this.EndLoopButton.Size = new System.Drawing.Size(176, 23);
            this.EndLoopButton.TabIndex = 3;
            this.EndLoopButton.Text = "End Loop";
            this.EndLoopButton.UseVisualStyleBackColor = true;
            this.EndLoopButton.Visible = false;
            this.EndLoopButton.Click += new System.EventHandler(this.EndLoopButton_Click);
            // 
            // CreateLoopButton
            // 
            this.CreateLoopButton.Location = new System.Drawing.Point(6, 58);
            this.CreateLoopButton.Name = "CreateLoopButton";
            this.CreateLoopButton.Size = new System.Drawing.Size(176, 23);
            this.CreateLoopButton.TabIndex = 2;
            this.CreateLoopButton.Text = "Create Loop";
            this.CreateLoopButton.UseVisualStyleBackColor = true;
            this.CreateLoopButton.Click += new System.EventHandler(this.CreateLoopButton_Click);
            // 
            // LoopAmountBox
            // 
            this.LoopAmountBox.Location = new System.Drawing.Point(6, 32);
            this.LoopAmountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LoopAmountBox.Name = "LoopAmountBox";
            this.LoopAmountBox.Size = new System.Drawing.Size(176, 20);
            this.LoopAmountBox.TabIndex = 1;
            this.LoopAmountBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LoopAmountLabel
            // 
            this.LoopAmountLabel.AutoSize = true;
            this.LoopAmountLabel.Location = new System.Drawing.Point(14, 16);
            this.LoopAmountLabel.Name = "LoopAmountLabel";
            this.LoopAmountLabel.Size = new System.Drawing.Size(70, 13);
            this.LoopAmountLabel.TabIndex = 0;
            this.LoopAmountLabel.Text = "Loop Amount";
            // 
            // MainCode
            // 
            this.MainCode.Location = new System.Drawing.Point(267, 32);
            this.MainCode.Multiline = true;
            this.MainCode.Name = "MainCode";
            this.MainCode.Size = new System.Drawing.Size(517, 407);
            this.MainCode.TabIndex = 1;
            this.MainCode.Text = "#NoEnv\r\n#Warn\r\nSendMode Input\r\nSetWorkingDir %A_ScriptDir%\r\nCoordMode, Mouse, Scr" +
    "een\r\n\r\n";
            // 
            // EndLoopButtonGlobal
            // 
            this.EndLoopButtonGlobal.Location = new System.Drawing.Point(267, 10);
            this.EndLoopButtonGlobal.Name = "EndLoopButtonGlobal";
            this.EndLoopButtonGlobal.Size = new System.Drawing.Size(75, 21);
            this.EndLoopButtonGlobal.TabIndex = 2;
            this.EndLoopButtonGlobal.Text = "End Loop";
            this.EndLoopButtonGlobal.UseVisualStyleBackColor = true;
            this.EndLoopButtonGlobal.Visible = false;
            this.EndLoopButtonGlobal.Click += new System.EventHandler(this.EndLoopButtonGlobal_Click);
            // 
            // AddToMainCode
            // 
            this.AddToMainCode.Location = new System.Drawing.Point(3, 154);
            this.AddToMainCode.Name = "AddToMainCode";
            this.AddToMainCode.Size = new System.Drawing.Size(237, 25);
            this.AddToMainCode.TabIndex = 6;
            this.AddToMainCode.Text = "Send to Code Base";
            this.AddToMainCode.UseVisualStyleBackColor = true;
            this.AddToMainCode.Click += new System.EventHandler(this.AddToMainCode_Click);
            // 
            // MsgBoxLabel
            // 
            this.MsgBoxLabel.AutoSize = true;
            this.MsgBoxLabel.Location = new System.Drawing.Point(15, 217);
            this.MsgBoxLabel.Name = "MsgBoxLabel";
            this.MsgBoxLabel.Size = new System.Drawing.Size(68, 13);
            this.MsgBoxLabel.TabIndex = 7;
            this.MsgBoxLabel.Text = "MsgBox Title";
            // 
            // MsgBoxTitle
            // 
            this.MsgBoxTitle.Location = new System.Drawing.Point(3, 233);
            this.MsgBoxTitle.Name = "MsgBoxTitle";
            this.MsgBoxTitle.Size = new System.Drawing.Size(237, 20);
            this.MsgBoxTitle.TabIndex = 8;
            // 
            // MsgBoxTextLabel
            // 
            this.MsgBoxTextLabel.AutoSize = true;
            this.MsgBoxTextLabel.Location = new System.Drawing.Point(15, 256);
            this.MsgBoxTextLabel.Name = "MsgBoxTextLabel";
            this.MsgBoxTextLabel.Size = new System.Drawing.Size(69, 13);
            this.MsgBoxTextLabel.TabIndex = 9;
            this.MsgBoxTextLabel.Text = "MsgBox Text";
            // 
            // MsgBoxTextInput
            // 
            this.MsgBoxTextInput.Location = new System.Drawing.Point(3, 272);
            this.MsgBoxTextInput.Name = "MsgBoxTextInput";
            this.MsgBoxTextInput.Size = new System.Drawing.Size(237, 20);
            this.MsgBoxTextInput.TabIndex = 10;
            // 
            // SendMsgBoxButton
            // 
            this.SendMsgBoxButton.Location = new System.Drawing.Point(3, 298);
            this.SendMsgBoxButton.Name = "SendMsgBoxButton";
            this.SendMsgBoxButton.Size = new System.Drawing.Size(237, 23);
            this.SendMsgBoxButton.TabIndex = 11;
            this.SendMsgBoxButton.Text = "Send to Code Base";
            this.SendMsgBoxButton.UseVisualStyleBackColor = true;
            this.SendMsgBoxButton.Click += new System.EventHandler(this.SendMsgBoxButton_Click);
            // 
            // MousePositionButton
            // 
            this.MousePositionButton.Location = new System.Drawing.Point(6, 15);
            this.MousePositionButton.Name = "MousePositionButton";
            this.MousePositionButton.Size = new System.Drawing.Size(188, 23);
            this.MousePositionButton.TabIndex = 0;
            this.MousePositionButton.Text = "Get Mouse Position";
            this.MousePositionButton.UseVisualStyleBackColor = true;
            this.MousePositionButton.Click += new System.EventHandler(this.MousePositionButton_Click);
            // 
            // MilisecondsCheck
            // 
            this.MilisecondsCheck.AutoSize = true;
            this.MilisecondsCheck.Checked = true;
            this.MilisecondsCheck.Location = new System.Drawing.Point(6, 44);
            this.MilisecondsCheck.Name = "MilisecondsCheck";
            this.MilisecondsCheck.Size = new System.Drawing.Size(82, 17);
            this.MilisecondsCheck.TabIndex = 2;
            this.MilisecondsCheck.TabStop = true;
            this.MilisecondsCheck.Text = "Milliseconds";
            this.MilisecondsCheck.UseVisualStyleBackColor = true;
            this.MilisecondsCheck.CheckedChanged += new System.EventHandler(this.MilisecondsCheck_CheckedChanged);
            // 
            // SecondsCheck
            // 
            this.SecondsCheck.AutoSize = true;
            this.SecondsCheck.Location = new System.Drawing.Point(94, 44);
            this.SecondsCheck.Name = "SecondsCheck";
            this.SecondsCheck.Size = new System.Drawing.Size(67, 17);
            this.SecondsCheck.TabIndex = 3;
            this.SecondsCheck.Text = "Seconds";
            this.SecondsCheck.UseVisualStyleBackColor = true;
            this.SecondsCheck.CheckedChanged += new System.EventHandler(this.SecondsCheck_CheckedChanged);
            // 
            // WaitTimeInput
            // 
            this.WaitTimeInput.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.WaitTimeInput.Location = new System.Drawing.Point(6, 67);
            this.WaitTimeInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WaitTimeInput.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.WaitTimeInput.Name = "WaitTimeInput";
            this.WaitTimeInput.Size = new System.Drawing.Size(120, 20);
            this.WaitTimeInput.TabIndex = 4;
            this.WaitTimeInput.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // MousePosXTextBox
            // 
            this.MousePosXTextBox.Enabled = false;
            this.MousePosXTextBox.Location = new System.Drawing.Point(6, 93);
            this.MousePosXTextBox.Name = "MousePosXTextBox";
            this.MousePosXTextBox.Size = new System.Drawing.Size(53, 20);
            this.MousePosXTextBox.TabIndex = 5;
            // 
            // MousePosYTextBox
            // 
            this.MousePosYTextBox.Enabled = false;
            this.MousePosYTextBox.Location = new System.Drawing.Point(73, 93);
            this.MousePosYTextBox.Name = "MousePosYTextBox";
            this.MousePosYTextBox.Size = new System.Drawing.Size(53, 20);
            this.MousePosYTextBox.TabIndex = 6;
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(25, 116);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(14, 13);
            this.XLabel.TabIndex = 7;
            this.XLabel.Text = "X";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(93, 116);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(14, 13);
            this.YLabel.TabIndex = 8;
            this.YLabel.Text = "Y";
            // 
            // CreateClickButton
            // 
            this.CreateClickButton.Location = new System.Drawing.Point(6, 154);
            this.CreateClickButton.Name = "CreateClickButton";
            this.CreateClickButton.Size = new System.Drawing.Size(188, 23);
            this.CreateClickButton.TabIndex = 9;
            this.CreateClickButton.Text = "Create Mouse Event";
            this.CreateClickButton.UseVisualStyleBackColor = true;
            this.CreateClickButton.Click += new System.EventHandler(this.CreateClickButton_Click);
            // 
            // ClickCheck
            // 
            this.ClickCheck.AutoSize = true;
            this.ClickCheck.Checked = true;
            this.ClickCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ClickCheck.Location = new System.Drawing.Point(10, 183);
            this.ClickCheck.Name = "ClickCheck";
            this.ClickCheck.Size = new System.Drawing.Size(49, 17);
            this.ClickCheck.TabIndex = 10;
            this.ClickCheck.Text = "Click";
            this.ClickCheck.UseVisualStyleBackColor = true;
            // 
            // XYCheck
            // 
            this.XYCheck.AutoSize = true;
            this.XYCheck.Checked = true;
            this.XYCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.XYCheck.Location = new System.Drawing.Point(10, 206);
            this.XYCheck.Name = "XYCheck";
            this.XYCheck.Size = new System.Drawing.Size(86, 17);
            this.XYCheck.TabIndex = 11;
            this.XYCheck.Text = "Use X and Y";
            this.XYCheck.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Middle"});
            this.comboBox1.Location = new System.Drawing.Point(6, 245);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Left";
            // 
            // MouseButtonLabel
            // 
            this.MouseButtonLabel.AutoSize = true;
            this.MouseButtonLabel.Location = new System.Drawing.Point(24, 229);
            this.MouseButtonLabel.Name = "MouseButtonLabel";
            this.MouseButtonLabel.Size = new System.Drawing.Size(73, 13);
            this.MouseButtonLabel.TabIndex = 13;
            this.MouseButtonLabel.Text = "Mouse Button";
            // 
            // NumOfClickInput
            // 
            this.NumOfClickInput.Location = new System.Drawing.Point(6, 290);
            this.NumOfClickInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOfClickInput.Name = "NumOfClickInput";
            this.NumOfClickInput.Size = new System.Drawing.Size(120, 20);
            this.NumOfClickInput.TabIndex = 14;
            this.NumOfClickInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumOfClickLabel
            // 
            this.NumOfClickLabel.AutoSize = true;
            this.NumOfClickLabel.Location = new System.Drawing.Point(25, 274);
            this.NumOfClickLabel.Name = "NumOfClickLabel";
            this.NumOfClickLabel.Size = new System.Drawing.Size(89, 13);
            this.NumOfClickLabel.TabIndex = 15;
            this.NumOfClickLabel.Text = "Number Of Clicks";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndLoopButtonGlobal);
            this.Controls.Add(this.MainCode);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "AHK Visual Studio";
            this.tabControl1.ResumeLayout(false);
            this.TabMain.ResumeLayout(false);
            this.TabMain.PerformLayout();
            this.TabMouse.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.TabMouseControls.ResumeLayout(false);
            this.TabMouseControls.PerformLayout();
            this.TabKeyBoard.ResumeLayout(false);
            this.TabKeyBoard.PerformLayout();
            this.TabSpecial.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.ModKeyTab.ResumeLayout(false);
            this.ModKeyTab.PerformLayout();
            this.ControlModifierBox.ResumeLayout(false);
            this.ControlModifierBox.PerformLayout();
            this.LoopTab.ResumeLayout(false);
            this.LoopTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoopAmountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitTimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfClickInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabMain;
        private System.Windows.Forms.Button hotKeyAssignButton;
        private System.Windows.Forms.TabPage TabMouse;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage TabMouseControls;
        private System.Windows.Forms.TabPage TabMouseContinued;
        private System.Windows.Forms.TabPage TabKeyBoard;
        private System.Windows.Forms.TabPage TabSpecial;
        private System.Windows.Forms.TextBox MainCode;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileNameInput;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ChangeNameButton;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage ModKeyTab;
        private System.Windows.Forms.Label savedModifierLabel;
        private System.Windows.Forms.TextBox savedModifierInput;
        private System.Windows.Forms.TextBox modifierKeyInput;
        private System.Windows.Forms.Label modifierKeyLabel;
        private System.Windows.Forms.GroupBox ControlModifierBox;
        private System.Windows.Forms.CheckBox winCheckBox;
        private System.Windows.Forms.CheckBox shiftCheckBox;
        private System.Windows.Forms.CheckBox altCheckBox;
        private System.Windows.Forms.CheckBox ctrlCheckBox;
        private System.Windows.Forms.TabPage LoopTab;
        private System.Windows.Forms.Button EndLoopButton;
        private System.Windows.Forms.Button CreateLoopButton;
        private System.Windows.Forms.NumericUpDown LoopAmountBox;
        private System.Windows.Forms.Label LoopAmountLabel;
        private System.Windows.Forms.Button EndLoopButtonGlobal;
        private System.Windows.Forms.Label SpecialKeyLabel;
        private System.Windows.Forms.ComboBox SpecialKeyInput;
        private System.Windows.Forms.Label AddModButtonLabel;
        private System.Windows.Forms.Button ModkeyButton;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Label TextTypeLabel;
        private System.Windows.Forms.Button AddToMainCode;
        private System.Windows.Forms.TextBox MsgBoxTextInput;
        private System.Windows.Forms.Label MsgBoxTextLabel;
        private System.Windows.Forms.TextBox MsgBoxTitle;
        private System.Windows.Forms.Label MsgBoxLabel;
        private System.Windows.Forms.Button SendMsgBoxButton;
        private System.Windows.Forms.RadioButton SecondsCheck;
        private System.Windows.Forms.RadioButton MilisecondsCheck;
        private System.Windows.Forms.Button MousePositionButton;
        private System.Windows.Forms.NumericUpDown WaitTimeInput;
        private System.Windows.Forms.Label NumOfClickLabel;
        private System.Windows.Forms.NumericUpDown NumOfClickInput;
        private System.Windows.Forms.Label MouseButtonLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox XYCheck;
        private System.Windows.Forms.CheckBox ClickCheck;
        private System.Windows.Forms.Button CreateClickButton;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TextBox MousePosYTextBox;
        private System.Windows.Forms.TextBox MousePosXTextBox;
    }
}

