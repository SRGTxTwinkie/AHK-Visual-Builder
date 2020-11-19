namespace AHKMaker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainCode = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StoredMod = new System.Windows.Forms.TextBox();
            this.ModKeyInput = new System.Windows.Forms.TextBox();
            this.HotKey = new System.Windows.Forms.Button();
            this.AddCustomMod = new System.Windows.Forms.Button();
            this.ShiftMod = new System.Windows.Forms.RadioButton();
            this.AltMod = new System.Windows.Forms.RadioButton();
            this.ControlMod = new System.Windows.Forms.RadioButton();
            this.Loops = new System.Windows.Forms.TabPage();
            this.MouseTab1 = new System.Windows.Forms.TabPage();
            this.ClickSend = new System.Windows.Forms.Button();
            this.NumClickLabel = new System.Windows.Forms.Label();
            this.NumClickInput = new System.Windows.Forms.NumericUpDown();
            this.MouseCombo = new System.Windows.Forms.ComboBox();
            this.MouseButtonLabel = new System.Windows.Forms.Label();
            this.SleepTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MousePosYTextBox = new System.Windows.Forms.TextBox();
            this.MousePosXTextBox = new System.Windows.Forms.TextBox();
            this.XYCheckBox = new System.Windows.Forms.CheckBox();
            this.MousePositionButton = new System.Windows.Forms.Button();
            this.ClickAction = new System.Windows.Forms.Button();
            this.MainControl = new System.Windows.Forms.TabPage();
            this.InsertModKeyLabel = new System.Windows.Forms.Label();
            this.InsertModKey = new System.Windows.Forms.Button();
            this.WaitInput = new System.Windows.Forms.NumericUpDown();
            this.WaitConfirm = new System.Windows.Forms.Button();
            this.TypeTextConfirm = new System.Windows.Forms.Button();
            this.PopupConfirm = new System.Windows.Forms.Button();
            this.WaitLabel = new System.Windows.Forms.Label();
            this.TypeTextLabel = new System.Windows.Forms.Label();
            this.PopupTitleLabel = new System.Windows.Forms.Label();
            this.PopupTextLabel = new System.Windows.Forms.Label();
            this.TypeTextInput = new System.Windows.Forms.TextBox();
            this.PopupTitleInput = new System.Windows.Forms.TextBox();
            this.PopupTextInput = new System.Windows.Forms.TextBox();
            this.AddPopup = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddType = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.FileNameInput = new System.Windows.Forms.TextBox();
            this.Credits = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ClickOption = new System.Windows.Forms.CheckBox();
            this.AddLoop = new System.Windows.Forms.Button();
            this.LoopAmountLabel = new System.Windows.Forms.Label();
            this.NumOfLoops = new System.Windows.Forms.NumericUpDown();
            this.LoopAdd = new System.Windows.Forms.Button();
            this.EndLoop = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Main.SuspendLayout();
            this.Loops.SuspendLayout();
            this.MouseTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumClickInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SleepTimeUpDown)).BeginInit();
            this.MainControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitInput)).BeginInit();
            this.Export.SuspendLayout();
            this.Credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfLoops)).BeginInit();
            this.SuspendLayout();
            // 
            // MainCode
            // 
            this.MainCode.Location = new System.Drawing.Point(217, 13);
            this.MainCode.Multiline = true;
            this.MainCode.Name = "MainCode";
            this.MainCode.Size = new System.Drawing.Size(468, 511);
            this.MainCode.TabIndex = 1;
            this.MainCode.Text = "#NoEnv\r\n#Warn\r\nSendMode Input\r\nSetWorkingDir %A_ScriptDir%\r\nCoordMode, Mouse, Scr" +
    "een\r\n\r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Main);
            this.tabControl1.Controls.Add(this.Loops);
            this.tabControl1.Controls.Add(this.MouseTab1);
            this.tabControl1.Controls.Add(this.MainControl);
            this.tabControl1.Controls.Add(this.Export);
            this.tabControl1.Controls.Add(this.Credits);
            this.tabControl1.Location = new System.Drawing.Point(11, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 510);
            this.tabControl1.TabIndex = 9;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.label6);
            this.Main.Controls.Add(this.label5);
            this.Main.Controls.Add(this.StoredMod);
            this.Main.Controls.Add(this.ModKeyInput);
            this.Main.Controls.Add(this.HotKey);
            this.Main.Controls.Add(this.AddCustomMod);
            this.Main.Controls.Add(this.ShiftMod);
            this.Main.Controls.Add(this.AltMod);
            this.Main.Controls.Add(this.ControlMod);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(192, 484);
            this.Main.TabIndex = 1;
            this.Main.Text = "Set HotKeys";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Stored Modifier";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Key Modifier";
            // 
            // StoredMod
            // 
            this.StoredMod.Location = new System.Drawing.Point(9, 188);
            this.StoredMod.Name = "StoredMod";
            this.StoredMod.ReadOnly = true;
            this.StoredMod.Size = new System.Drawing.Size(96, 20);
            this.StoredMod.TabIndex = 6;
            // 
            // ModKeyInput
            // 
            this.ModKeyInput.Location = new System.Drawing.Point(9, 149);
            this.ModKeyInput.MaxLength = 1;
            this.ModKeyInput.Name = "ModKeyInput";
            this.ModKeyInput.Size = new System.Drawing.Size(96, 20);
            this.ModKeyInput.TabIndex = 5;
            // 
            // HotKey
            // 
            this.HotKey.Location = new System.Drawing.Point(9, 6);
            this.HotKey.Name = "HotKey";
            this.HotKey.Size = new System.Drawing.Size(95, 48);
            this.HotKey.TabIndex = 1;
            this.HotKey.Text = "Set As HotKey";
            this.HotKey.UseVisualStyleBackColor = true;
            this.HotKey.Click += new System.EventHandler(this.HotKey_Click);
            // 
            // AddCustomMod
            // 
            this.AddCustomMod.Location = new System.Drawing.Point(9, 214);
            this.AddCustomMod.Name = "AddCustomMod";
            this.AddCustomMod.Size = new System.Drawing.Size(95, 26);
            this.AddCustomMod.TabIndex = 7;
            this.AddCustomMod.Text = "Add Modifier";
            this.AddCustomMod.UseVisualStyleBackColor = true;
            this.AddCustomMod.Click += new System.EventHandler(this.AddCustomMod_Click);
            // 
            // ShiftMod
            // 
            this.ShiftMod.AutoSize = true;
            this.ShiftMod.Location = new System.Drawing.Point(9, 106);
            this.ShiftMod.Name = "ShiftMod";
            this.ShiftMod.Size = new System.Drawing.Size(86, 17);
            this.ShiftMod.TabIndex = 4;
            this.ShiftMod.TabStop = true;
            this.ShiftMod.Text = "Shift Modifier";
            this.ShiftMod.UseVisualStyleBackColor = true;
            // 
            // AltMod
            // 
            this.AltMod.AutoSize = true;
            this.AltMod.Location = new System.Drawing.Point(9, 83);
            this.AltMod.Name = "AltMod";
            this.AltMod.Size = new System.Drawing.Size(75, 17);
            this.AltMod.TabIndex = 3;
            this.AltMod.TabStop = true;
            this.AltMod.Text = "Alt Modifer";
            this.AltMod.UseVisualStyleBackColor = true;
            // 
            // ControlMod
            // 
            this.ControlMod.AutoSize = true;
            this.ControlMod.Checked = true;
            this.ControlMod.Location = new System.Drawing.Point(9, 60);
            this.ControlMod.Name = "ControlMod";
            this.ControlMod.Size = new System.Drawing.Size(96, 17);
            this.ControlMod.TabIndex = 2;
            this.ControlMod.TabStop = true;
            this.ControlMod.Text = "Control Modifer";
            this.ControlMod.UseVisualStyleBackColor = true;
            // 
            // Loops
            // 
            this.Loops.Controls.Add(this.EndLoop);
            this.Loops.Controls.Add(this.LoopAdd);
            this.Loops.Controls.Add(this.NumOfLoops);
            this.Loops.Controls.Add(this.LoopAmountLabel);
            this.Loops.Controls.Add(this.AddLoop);
            this.Loops.Location = new System.Drawing.Point(4, 22);
            this.Loops.Name = "Loops";
            this.Loops.Size = new System.Drawing.Size(192, 484);
            this.Loops.TabIndex = 4;
            this.Loops.Text = "Loops";
            this.Loops.UseVisualStyleBackColor = true;
            // 
            // MouseTab1
            // 
            this.MouseTab1.Controls.Add(this.ClickOption);
            this.MouseTab1.Controls.Add(this.ClickSend);
            this.MouseTab1.Controls.Add(this.NumClickLabel);
            this.MouseTab1.Controls.Add(this.NumClickInput);
            this.MouseTab1.Controls.Add(this.MouseCombo);
            this.MouseTab1.Controls.Add(this.MouseButtonLabel);
            this.MouseTab1.Controls.Add(this.SleepTimeUpDown);
            this.MouseTab1.Controls.Add(this.label3);
            this.MouseTab1.Controls.Add(this.label4);
            this.MouseTab1.Controls.Add(this.label2);
            this.MouseTab1.Controls.Add(this.MousePosYTextBox);
            this.MouseTab1.Controls.Add(this.MousePosXTextBox);
            this.MouseTab1.Controls.Add(this.XYCheckBox);
            this.MouseTab1.Controls.Add(this.MousePositionButton);
            this.MouseTab1.Controls.Add(this.ClickAction);
            this.MouseTab1.Location = new System.Drawing.Point(4, 22);
            this.MouseTab1.Name = "MouseTab1";
            this.MouseTab1.Size = new System.Drawing.Size(192, 484);
            this.MouseTab1.TabIndex = 5;
            this.MouseTab1.Text = "Mouse 1";
            this.MouseTab1.UseVisualStyleBackColor = true;
            // 
            // ClickSend
            // 
            this.ClickSend.Location = new System.Drawing.Point(139, 276);
            this.ClickSend.Name = "ClickSend";
            this.ClickSend.Size = new System.Drawing.Size(25, 20);
            this.ClickSend.TabIndex = 8;
            this.ClickSend.Text = "→";
            this.ClickSend.UseVisualStyleBackColor = true;
            this.ClickSend.Click += new System.EventHandler(this.ClickSend_Click);
            // 
            // NumClickLabel
            // 
            this.NumClickLabel.AutoSize = true;
            this.NumClickLabel.Location = new System.Drawing.Point(25, 262);
            this.NumClickLabel.Name = "NumClickLabel";
            this.NumClickLabel.Size = new System.Drawing.Size(57, 13);
            this.NumClickLabel.TabIndex = 48;
            this.NumClickLabel.Text = "# of Clicks";
            // 
            // NumClickInput
            // 
            this.NumClickInput.Location = new System.Drawing.Point(12, 278);
            this.NumClickInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumClickInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumClickInput.Name = "NumClickInput";
            this.NumClickInput.Size = new System.Drawing.Size(121, 20);
            this.NumClickInput.TabIndex = 7;
            this.NumClickInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MouseCombo
            // 
            this.MouseCombo.FormattingEnabled = true;
            this.MouseCombo.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Middle"});
            this.MouseCombo.Location = new System.Drawing.Point(12, 232);
            this.MouseCombo.Name = "MouseCombo";
            this.MouseCombo.Size = new System.Drawing.Size(121, 21);
            this.MouseCombo.TabIndex = 6;
            this.MouseCombo.Text = "Left";
            // 
            // MouseButtonLabel
            // 
            this.MouseButtonLabel.AutoSize = true;
            this.MouseButtonLabel.Location = new System.Drawing.Point(25, 216);
            this.MouseButtonLabel.Name = "MouseButtonLabel";
            this.MouseButtonLabel.Size = new System.Drawing.Size(73, 13);
            this.MouseButtonLabel.TabIndex = 45;
            this.MouseButtonLabel.Text = "Mouse Button";
            // 
            // SleepTimeUpDown
            // 
            this.SleepTimeUpDown.Location = new System.Drawing.Point(12, 39);
            this.SleepTimeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SleepTimeUpDown.Name = "SleepTimeUpDown";
            this.SleepTimeUpDown.Size = new System.Drawing.Size(41, 20);
            this.SleepTimeUpDown.TabIndex = 2;
            this.SleepTimeUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SleepTimeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Wait Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "X";
            // 
            // MousePosYTextBox
            // 
            this.MousePosYTextBox.Location = new System.Drawing.Point(12, 91);
            this.MousePosYTextBox.Name = "MousePosYTextBox";
            this.MousePosYTextBox.ReadOnly = true;
            this.MousePosYTextBox.Size = new System.Drawing.Size(54, 20);
            this.MousePosYTextBox.TabIndex = 35;
            // 
            // MousePosXTextBox
            // 
            this.MousePosXTextBox.Location = new System.Drawing.Point(12, 65);
            this.MousePosXTextBox.Name = "MousePosXTextBox";
            this.MousePosXTextBox.ReadOnly = true;
            this.MousePosXTextBox.Size = new System.Drawing.Size(54, 20);
            this.MousePosXTextBox.TabIndex = 34;
            // 
            // XYCheckBox
            // 
            this.XYCheckBox.AutoSize = true;
            this.XYCheckBox.Checked = true;
            this.XYCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.XYCheckBox.Location = new System.Drawing.Point(12, 171);
            this.XYCheckBox.Name = "XYCheckBox";
            this.XYCheckBox.Size = new System.Drawing.Size(86, 17);
            this.XYCheckBox.TabIndex = 4;
            this.XYCheckBox.Text = "Use X and Y";
            this.XYCheckBox.UseVisualStyleBackColor = true;
            // 
            // MousePositionButton
            // 
            this.MousePositionButton.Location = new System.Drawing.Point(9, 8);
            this.MousePositionButton.Name = "MousePositionButton";
            this.MousePositionButton.Size = new System.Drawing.Size(95, 25);
            this.MousePositionButton.TabIndex = 1;
            this.MousePositionButton.Text = "Mouse Position";
            this.MousePositionButton.UseVisualStyleBackColor = true;
            this.MousePositionButton.Click += new System.EventHandler(this.MousePositionButton_Click);
            // 
            // ClickAction
            // 
            this.ClickAction.Location = new System.Drawing.Point(9, 139);
            this.ClickAction.Name = "ClickAction";
            this.ClickAction.Size = new System.Drawing.Size(95, 26);
            this.ClickAction.TabIndex = 3;
            this.ClickAction.Text = "Add Click Action";
            this.ClickAction.UseVisualStyleBackColor = true;
            this.ClickAction.Click += new System.EventHandler(this.ClickAction_Click);
            // 
            // MainControl
            // 
            this.MainControl.Controls.Add(this.InsertModKeyLabel);
            this.MainControl.Controls.Add(this.InsertModKey);
            this.MainControl.Controls.Add(this.WaitInput);
            this.MainControl.Controls.Add(this.WaitConfirm);
            this.MainControl.Controls.Add(this.TypeTextConfirm);
            this.MainControl.Controls.Add(this.PopupConfirm);
            this.MainControl.Controls.Add(this.WaitLabel);
            this.MainControl.Controls.Add(this.TypeTextLabel);
            this.MainControl.Controls.Add(this.PopupTitleLabel);
            this.MainControl.Controls.Add(this.PopupTextLabel);
            this.MainControl.Controls.Add(this.TypeTextInput);
            this.MainControl.Controls.Add(this.PopupTitleInput);
            this.MainControl.Controls.Add(this.PopupTextInput);
            this.MainControl.Controls.Add(this.AddPopup);
            this.MainControl.Controls.Add(this.button2);
            this.MainControl.Controls.Add(this.AddType);
            this.MainControl.Location = new System.Drawing.Point(4, 22);
            this.MainControl.Name = "MainControl";
            this.MainControl.Padding = new System.Windows.Forms.Padding(3);
            this.MainControl.Size = new System.Drawing.Size(192, 484);
            this.MainControl.TabIndex = 0;
            this.MainControl.Text = "Common Controls";
            this.MainControl.UseVisualStyleBackColor = true;
            // 
            // InsertModKeyLabel
            // 
            this.InsertModKeyLabel.AutoSize = true;
            this.InsertModKeyLabel.Location = new System.Drawing.Point(26, 79);
            this.InsertModKeyLabel.Name = "InsertModKeyLabel";
            this.InsertModKeyLabel.Size = new System.Drawing.Size(78, 13);
            this.InsertModKeyLabel.TabIndex = 39;
            this.InsertModKeyLabel.Text = "Insert Mod Key";
            this.InsertModKeyLabel.Visible = false;
            // 
            // InsertModKey
            // 
            this.InsertModKey.Location = new System.Drawing.Point(10, 79);
            this.InsertModKey.Name = "InsertModKey";
            this.InsertModKey.Size = new System.Drawing.Size(14, 13);
            this.InsertModKey.TabIndex = 4;
            this.InsertModKey.UseVisualStyleBackColor = true;
            this.InsertModKey.Visible = false;
            this.InsertModKey.Click += new System.EventHandler(this.InsertModKey_Click);
            // 
            // WaitInput
            // 
            this.WaitInput.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.WaitInput.Location = new System.Drawing.Point(9, 291);
            this.WaitInput.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.WaitInput.Name = "WaitInput";
            this.WaitInput.Size = new System.Drawing.Size(127, 20);
            this.WaitInput.TabIndex = 10;
            this.WaitInput.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.WaitInput.Visible = false;
            // 
            // WaitConfirm
            // 
            this.WaitConfirm.Location = new System.Drawing.Point(145, 291);
            this.WaitConfirm.Name = "WaitConfirm";
            this.WaitConfirm.Size = new System.Drawing.Size(25, 20);
            this.WaitConfirm.TabIndex = 11;
            this.WaitConfirm.Text = "→";
            this.WaitConfirm.UseVisualStyleBackColor = true;
            this.WaitConfirm.Visible = false;
            this.WaitConfirm.Click += new System.EventHandler(this.WaitConfirm_Click);
            // 
            // TypeTextConfirm
            // 
            this.TypeTextConfirm.Location = new System.Drawing.Point(145, 52);
            this.TypeTextConfirm.Name = "TypeTextConfirm";
            this.TypeTextConfirm.Size = new System.Drawing.Size(25, 20);
            this.TypeTextConfirm.TabIndex = 3;
            this.TypeTextConfirm.Text = "→";
            this.TypeTextConfirm.UseVisualStyleBackColor = true;
            this.TypeTextConfirm.Visible = false;
            this.TypeTextConfirm.Click += new System.EventHandler(this.TypeTextConfirm_Click);
            // 
            // PopupConfirm
            // 
            this.PopupConfirm.Location = new System.Drawing.Point(146, 199);
            this.PopupConfirm.Name = "PopupConfirm";
            this.PopupConfirm.Size = new System.Drawing.Size(25, 20);
            this.PopupConfirm.TabIndex = 8;
            this.PopupConfirm.Text = "→";
            this.PopupConfirm.UseVisualStyleBackColor = true;
            this.PopupConfirm.Visible = false;
            this.PopupConfirm.Click += new System.EventHandler(this.PopupConfirm_Click);
            // 
            // WaitLabel
            // 
            this.WaitLabel.AutoSize = true;
            this.WaitLabel.Location = new System.Drawing.Point(18, 275);
            this.WaitLabel.Name = "WaitLabel";
            this.WaitLabel.Size = new System.Drawing.Size(119, 13);
            this.WaitLabel.TabIndex = 24;
            this.WaitLabel.Text = "Wait Time (Miliseconds)";
            this.WaitLabel.Visible = false;
            // 
            // TypeTextLabel
            // 
            this.TypeTextLabel.AutoSize = true;
            this.TypeTextLabel.Location = new System.Drawing.Point(18, 35);
            this.TypeTextLabel.Name = "TypeTextLabel";
            this.TypeTextLabel.Size = new System.Drawing.Size(55, 13);
            this.TypeTextLabel.TabIndex = 24;
            this.TypeTextLabel.Text = "Type Text";
            this.TypeTextLabel.Visible = false;
            // 
            // PopupTitleLabel
            // 
            this.PopupTitleLabel.AutoSize = true;
            this.PopupTitleLabel.Location = new System.Drawing.Point(19, 144);
            this.PopupTitleLabel.Name = "PopupTitleLabel";
            this.PopupTitleLabel.Size = new System.Drawing.Size(61, 13);
            this.PopupTitleLabel.TabIndex = 23;
            this.PopupTitleLabel.Text = "Popup Title";
            this.PopupTitleLabel.Visible = false;
            // 
            // PopupTextLabel
            // 
            this.PopupTextLabel.AutoSize = true;
            this.PopupTextLabel.Location = new System.Drawing.Point(19, 183);
            this.PopupTextLabel.Name = "PopupTextLabel";
            this.PopupTextLabel.Size = new System.Drawing.Size(62, 13);
            this.PopupTextLabel.TabIndex = 22;
            this.PopupTextLabel.Text = "Popup Text";
            this.PopupTextLabel.Visible = false;
            // 
            // TypeTextInput
            // 
            this.TypeTextInput.Location = new System.Drawing.Point(9, 53);
            this.TypeTextInput.Name = "TypeTextInput";
            this.TypeTextInput.Size = new System.Drawing.Size(131, 20);
            this.TypeTextInput.TabIndex = 2;
            this.TypeTextInput.Visible = false;
            // 
            // PopupTitleInput
            // 
            this.PopupTitleInput.Location = new System.Drawing.Point(9, 160);
            this.PopupTitleInput.Name = "PopupTitleInput";
            this.PopupTitleInput.Size = new System.Drawing.Size(131, 20);
            this.PopupTitleInput.TabIndex = 6;
            this.PopupTitleInput.Visible = false;
            // 
            // PopupTextInput
            // 
            this.PopupTextInput.Location = new System.Drawing.Point(9, 199);
            this.PopupTextInput.Name = "PopupTextInput";
            this.PopupTextInput.Size = new System.Drawing.Size(131, 20);
            this.PopupTextInput.TabIndex = 7;
            this.PopupTextInput.Visible = false;
            // 
            // AddPopup
            // 
            this.AddPopup.Location = new System.Drawing.Point(8, 115);
            this.AddPopup.Name = "AddPopup";
            this.AddPopup.Size = new System.Drawing.Size(95, 26);
            this.AddPopup.TabIndex = 5;
            this.AddPopup.Text = "Add Popup";
            this.AddPopup.UseVisualStyleBackColor = true;
            this.AddPopup.Click += new System.EventHandler(this.AddPopup_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add Wait";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddWait_Click);
            // 
            // AddType
            // 
            this.AddType.Location = new System.Drawing.Point(8, 6);
            this.AddType.Name = "AddType";
            this.AddType.Size = new System.Drawing.Size(95, 26);
            this.AddType.TabIndex = 1;
            this.AddType.Text = "Add Type";
            this.AddType.UseVisualStyleBackColor = true;
            this.AddType.Click += new System.EventHandler(this.AddType_Click);
            // 
            // Export
            // 
            this.Export.Controls.Add(this.label8);
            this.Export.Controls.Add(this.button3);
            this.Export.Controls.Add(this.label7);
            this.Export.Controls.Add(this.FileNameInput);
            this.Export.Location = new System.Drawing.Point(4, 22);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(192, 484);
            this.Export.TabIndex = 2;
            this.Export.Text = "Export To File";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "File will be put on the in the same\r\ndirectory as the Builder is in.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Export To File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "File Name";
            // 
            // FileNameInput
            // 
            this.FileNameInput.Location = new System.Drawing.Point(3, 27);
            this.FileNameInput.Name = "FileNameInput";
            this.FileNameInput.Size = new System.Drawing.Size(121, 20);
            this.FileNameInput.TabIndex = 1;
            // 
            // Credits
            // 
            this.Credits.Controls.Add(this.textBox3);
            this.Credits.Controls.Add(this.textBox2);
            this.Credits.Controls.Add(this.label9);
            this.Credits.Location = new System.Drawing.Point(4, 22);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(192, 484);
            this.Credits.TabIndex = 3;
            this.Credits.Text = "Credits";
            this.Credits.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(21, 58);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(146, 147);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Zane Reisbig";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Created By:";
            // 
            // ClickOption
            // 
            this.ClickOption.AutoSize = true;
            this.ClickOption.Checked = true;
            this.ClickOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ClickOption.Location = new System.Drawing.Point(12, 194);
            this.ClickOption.Name = "ClickOption";
            this.ClickOption.Size = new System.Drawing.Size(55, 17);
            this.ClickOption.TabIndex = 5;
            this.ClickOption.Text = "Click?";
            this.ClickOption.UseVisualStyleBackColor = true;
            // 
            // AddLoop
            // 
            this.AddLoop.Location = new System.Drawing.Point(8, 12);
            this.AddLoop.Name = "AddLoop";
            this.AddLoop.Size = new System.Drawing.Size(95, 23);
            this.AddLoop.TabIndex = 0;
            this.AddLoop.Text = "Add Loop";
            this.AddLoop.UseVisualStyleBackColor = true;
            this.AddLoop.Click += new System.EventHandler(this.AddLoop_Click);
            // 
            // LoopAmountLabel
            // 
            this.LoopAmountLabel.AutoSize = true;
            this.LoopAmountLabel.Location = new System.Drawing.Point(14, 43);
            this.LoopAmountLabel.Name = "LoopAmountLabel";
            this.LoopAmountLabel.Size = new System.Drawing.Size(70, 13);
            this.LoopAmountLabel.TabIndex = 2;
            this.LoopAmountLabel.Text = "Loop Amount";
            this.LoopAmountLabel.Visible = false;
            // 
            // NumOfLoops
            // 
            this.NumOfLoops.Location = new System.Drawing.Point(8, 59);
            this.NumOfLoops.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumOfLoops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOfLoops.Name = "NumOfLoops";
            this.NumOfLoops.Size = new System.Drawing.Size(120, 20);
            this.NumOfLoops.TabIndex = 3;
            this.NumOfLoops.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOfLoops.Visible = false;
            // 
            // LoopAdd
            // 
            this.LoopAdd.Location = new System.Drawing.Point(134, 59);
            this.LoopAdd.Name = "LoopAdd";
            this.LoopAdd.Size = new System.Drawing.Size(25, 20);
            this.LoopAdd.TabIndex = 4;
            this.LoopAdd.Text = "→";
            this.LoopAdd.UseVisualStyleBackColor = true;
            this.LoopAdd.Visible = false;
            this.LoopAdd.Click += new System.EventHandler(this.LoopAdd_Click);
            // 
            // EndLoop
            // 
            this.EndLoop.Location = new System.Drawing.Point(109, 12);
            this.EndLoop.Name = "EndLoop";
            this.EndLoop.Size = new System.Drawing.Size(80, 23);
            this.EndLoop.TabIndex = 5;
            this.EndLoop.Text = "End Loop";
            this.EndLoop.UseVisualStyleBackColor = true;
            this.EndLoop.Visible = false;
            this.EndLoop.Click += new System.EventHandler(this.EndLoop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 536);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MainCode);
            this.Name = "Form1";
            this.Text = "Hot Key Builder";
            this.tabControl1.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.Loops.ResumeLayout(false);
            this.Loops.PerformLayout();
            this.MouseTab1.ResumeLayout(false);
            this.MouseTab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumClickInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SleepTimeUpDown)).EndInit();
            this.MainControl.ResumeLayout(false);
            this.MainControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitInput)).EndInit();
            this.Export.ResumeLayout(false);
            this.Export.PerformLayout();
            this.Credits.ResumeLayout(false);
            this.Credits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfLoops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MainCode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainControl;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.Button TypeTextConfirm;
        private System.Windows.Forms.Button PopupConfirm;
        private System.Windows.Forms.Label TypeTextLabel;
        private System.Windows.Forms.Label PopupTitleLabel;
        private System.Windows.Forms.Label PopupTextLabel;
        private System.Windows.Forms.TextBox TypeTextInput;
        private System.Windows.Forms.TextBox PopupTitleInput;
        private System.Windows.Forms.TextBox PopupTextInput;
        private System.Windows.Forms.Button AddPopup;
        private System.Windows.Forms.Button AddType;
        private System.Windows.Forms.Button AddCustomMod;
        private System.Windows.Forms.RadioButton ShiftMod;
        private System.Windows.Forms.RadioButton AltMod;
        private System.Windows.Forms.RadioButton ControlMod;
        private System.Windows.Forms.NumericUpDown WaitInput;
        private System.Windows.Forms.Button WaitConfirm;
        private System.Windows.Forms.Label WaitLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ModKeyInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StoredMod;
        private System.Windows.Forms.Button HotKey;
        private System.Windows.Forms.Label InsertModKeyLabel;
        private System.Windows.Forms.Button InsertModKey;
        private System.Windows.Forms.TabPage Export;
        private System.Windows.Forms.TabPage Credits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FileNameInput;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage Loops;
        private System.Windows.Forms.TabPage MouseTab1;
        private System.Windows.Forms.NumericUpDown SleepTimeUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MousePosYTextBox;
        private System.Windows.Forms.TextBox MousePosXTextBox;
        private System.Windows.Forms.CheckBox XYCheckBox;
        private System.Windows.Forms.Button MousePositionButton;
        private System.Windows.Forms.Button ClickAction;
        private System.Windows.Forms.Label NumClickLabel;
        private System.Windows.Forms.NumericUpDown NumClickInput;
        private System.Windows.Forms.ComboBox MouseCombo;
        private System.Windows.Forms.Label MouseButtonLabel;
        private System.Windows.Forms.Button ClickSend;
        private System.Windows.Forms.CheckBox ClickOption;
        private System.Windows.Forms.Button LoopAdd;
        private System.Windows.Forms.NumericUpDown NumOfLoops;
        private System.Windows.Forms.Label LoopAmountLabel;
        private System.Windows.Forms.Button AddLoop;
        private System.Windows.Forms.Button EndLoop;
    }
}

