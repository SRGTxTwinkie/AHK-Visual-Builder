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
            this.MainControl = new System.Windows.Forms.TabPage();
            this.InsertModKeyLabel = new System.Windows.Forms.Label();
            this.InsertModKey = new System.Windows.Forms.Button();
            this.WaitInput = new System.Windows.Forms.NumericUpDown();
            this.WaitConfirm = new System.Windows.Forms.Button();
            this.TypeTextConfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PopupConfirm = new System.Windows.Forms.Button();
            this.SleepTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MousePosYTextBox = new System.Windows.Forms.TextBox();
            this.MousePosXTextBox = new System.Windows.Forms.TextBox();
            this.XYCheckBox = new System.Windows.Forms.CheckBox();
            this.WaitLabel = new System.Windows.Forms.Label();
            this.TypeTextLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PopupTitleLabel = new System.Windows.Forms.Label();
            this.PopupTextLabel = new System.Windows.Forms.Label();
            this.TypeTextInput = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PopupTitleInput = new System.Windows.Forms.TextBox();
            this.PopupTextInput = new System.Windows.Forms.TextBox();
            this.AddPopup = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddType = new System.Windows.Forms.Button();
            this.MousePositionButton = new System.Windows.Forms.Button();
            this.ClickAction = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.TabPage();
            this.Credits = new System.Windows.Forms.TabPage();
            this.FileNameInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Main.SuspendLayout();
            this.MainControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SleepTimeUpDown)).BeginInit();
            this.Export.SuspendLayout();
            this.Credits.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainCode
            // 
            this.MainCode.Location = new System.Drawing.Point(217, 13);
            this.MainCode.Multiline = true;
            this.MainCode.Name = "MainCode";
            this.MainCode.Size = new System.Drawing.Size(468, 511);
            this.MainCode.TabIndex = 1;
            this.MainCode.Text = "#NoEnv\r\n#Warn\r\nSendMode Input\r\nSetWorkingDir %A_ScriptDir%\r\n\r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Main);
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
            this.StoredMod.TabIndex = 23;
            // 
            // ModKeyInput
            // 
            this.ModKeyInput.Location = new System.Drawing.Point(9, 149);
            this.ModKeyInput.MaxLength = 1;
            this.ModKeyInput.Name = "ModKeyInput";
            this.ModKeyInput.Size = new System.Drawing.Size(96, 20);
            this.ModKeyInput.TabIndex = 23;
            // 
            // HotKey
            // 
            this.HotKey.Location = new System.Drawing.Point(9, 6);
            this.HotKey.Name = "HotKey";
            this.HotKey.Size = new System.Drawing.Size(95, 48);
            this.HotKey.TabIndex = 18;
            this.HotKey.Text = "Set As HotKey";
            this.HotKey.UseVisualStyleBackColor = true;
            this.HotKey.Click += new System.EventHandler(this.HotKey_Click);
            // 
            // AddCustomMod
            // 
            this.AddCustomMod.Location = new System.Drawing.Point(9, 214);
            this.AddCustomMod.Name = "AddCustomMod";
            this.AddCustomMod.Size = new System.Drawing.Size(95, 26);
            this.AddCustomMod.TabIndex = 18;
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
            this.ShiftMod.TabIndex = 22;
            this.ShiftMod.Text = "Shift Modifier";
            this.ShiftMod.UseVisualStyleBackColor = true;
            // 
            // AltMod
            // 
            this.AltMod.AutoSize = true;
            this.AltMod.Location = new System.Drawing.Point(9, 83);
            this.AltMod.Name = "AltMod";
            this.AltMod.Size = new System.Drawing.Size(75, 17);
            this.AltMod.TabIndex = 21;
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
            this.ControlMod.TabIndex = 20;
            this.ControlMod.TabStop = true;
            this.ControlMod.Text = "Control Modifer";
            this.ControlMod.UseVisualStyleBackColor = true;
            // 
            // MainControl
            // 
            this.MainControl.Controls.Add(this.InsertModKeyLabel);
            this.MainControl.Controls.Add(this.InsertModKey);
            this.MainControl.Controls.Add(this.WaitInput);
            this.MainControl.Controls.Add(this.WaitConfirm);
            this.MainControl.Controls.Add(this.TypeTextConfirm);
            this.MainControl.Controls.Add(this.button1);
            this.MainControl.Controls.Add(this.PopupConfirm);
            this.MainControl.Controls.Add(this.SleepTimeUpDown);
            this.MainControl.Controls.Add(this.label3);
            this.MainControl.Controls.Add(this.label4);
            this.MainControl.Controls.Add(this.label2);
            this.MainControl.Controls.Add(this.MousePosYTextBox);
            this.MainControl.Controls.Add(this.MousePosXTextBox);
            this.MainControl.Controls.Add(this.XYCheckBox);
            this.MainControl.Controls.Add(this.WaitLabel);
            this.MainControl.Controls.Add(this.TypeTextLabel);
            this.MainControl.Controls.Add(this.label1);
            this.MainControl.Controls.Add(this.PopupTitleLabel);
            this.MainControl.Controls.Add(this.PopupTextLabel);
            this.MainControl.Controls.Add(this.TypeTextInput);
            this.MainControl.Controls.Add(this.textBox1);
            this.MainControl.Controls.Add(this.PopupTitleInput);
            this.MainControl.Controls.Add(this.PopupTextInput);
            this.MainControl.Controls.Add(this.AddPopup);
            this.MainControl.Controls.Add(this.button2);
            this.MainControl.Controls.Add(this.AddType);
            this.MainControl.Controls.Add(this.MousePositionButton);
            this.MainControl.Controls.Add(this.ClickAction);
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
            this.InsertModKeyLabel.Location = new System.Drawing.Point(25, 268);
            this.InsertModKeyLabel.Name = "InsertModKeyLabel";
            this.InsertModKeyLabel.Size = new System.Drawing.Size(78, 13);
            this.InsertModKeyLabel.TabIndex = 39;
            this.InsertModKeyLabel.Text = "Insert Mod Key";
            this.InsertModKeyLabel.Visible = false;
            // 
            // InsertModKey
            // 
            this.InsertModKey.Location = new System.Drawing.Point(9, 268);
            this.InsertModKey.Name = "InsertModKey";
            this.InsertModKey.Size = new System.Drawing.Size(14, 13);
            this.InsertModKey.TabIndex = 38;
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
            this.WaitInput.Location = new System.Drawing.Point(9, 456);
            this.WaitInput.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.WaitInput.Name = "WaitInput";
            this.WaitInput.Size = new System.Drawing.Size(127, 20);
            this.WaitInput.TabIndex = 37;
            this.WaitInput.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.WaitInput.Visible = false;
            // 
            // WaitConfirm
            // 
            this.WaitConfirm.Location = new System.Drawing.Point(145, 456);
            this.WaitConfirm.Name = "WaitConfirm";
            this.WaitConfirm.Size = new System.Drawing.Size(24, 22);
            this.WaitConfirm.TabIndex = 36;
            this.WaitConfirm.Text = "→";
            this.WaitConfirm.UseVisualStyleBackColor = true;
            this.WaitConfirm.Visible = false;
            this.WaitConfirm.Click += new System.EventHandler(this.WaitConfirm_Click);
            // 
            // TypeTextConfirm
            // 
            this.TypeTextConfirm.Location = new System.Drawing.Point(144, 241);
            this.TypeTextConfirm.Name = "TypeTextConfirm";
            this.TypeTextConfirm.Size = new System.Drawing.Size(24, 21);
            this.TypeTextConfirm.TabIndex = 36;
            this.TypeTextConfirm.Text = "→";
            this.TypeTextConfirm.UseVisualStyleBackColor = true;
            this.TypeTextConfirm.Visible = false;
            this.TypeTextConfirm.Click += new System.EventHandler(this.TypeTextConfirm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 21);
            this.button1.TabIndex = 35;
            this.button1.Text = "→";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // PopupConfirm
            // 
            this.PopupConfirm.Location = new System.Drawing.Point(145, 371);
            this.PopupConfirm.Name = "PopupConfirm";
            this.PopupConfirm.Size = new System.Drawing.Size(24, 21);
            this.PopupConfirm.TabIndex = 33;
            this.PopupConfirm.Text = "→";
            this.PopupConfirm.UseVisualStyleBackColor = true;
            this.PopupConfirm.Visible = false;
            this.PopupConfirm.Click += new System.EventHandler(this.PopupConfirm_Click);
            // 
            // SleepTimeUpDown
            // 
            this.SleepTimeUpDown.Location = new System.Drawing.Point(7, 36);
            this.SleepTimeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SleepTimeUpDown.Name = "SleepTimeUpDown";
            this.SleepTimeUpDown.Size = new System.Drawing.Size(41, 20);
            this.SleepTimeUpDown.TabIndex = 32;
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
            this.label3.Location = new System.Drawing.Point(65, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Wait Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "X";
            // 
            // MousePosYTextBox
            // 
            this.MousePosYTextBox.Location = new System.Drawing.Point(7, 88);
            this.MousePosYTextBox.Name = "MousePosYTextBox";
            this.MousePosYTextBox.ReadOnly = true;
            this.MousePosYTextBox.Size = new System.Drawing.Size(54, 20);
            this.MousePosYTextBox.TabIndex = 28;
            // 
            // MousePosXTextBox
            // 
            this.MousePosXTextBox.Location = new System.Drawing.Point(7, 62);
            this.MousePosXTextBox.Name = "MousePosXTextBox";
            this.MousePosXTextBox.ReadOnly = true;
            this.MousePosXTextBox.Size = new System.Drawing.Size(54, 20);
            this.MousePosXTextBox.TabIndex = 27;
            // 
            // XYCheckBox
            // 
            this.XYCheckBox.AutoSize = true;
            this.XYCheckBox.Location = new System.Drawing.Point(7, 145);
            this.XYCheckBox.Name = "XYCheckBox";
            this.XYCheckBox.Size = new System.Drawing.Size(86, 17);
            this.XYCheckBox.TabIndex = 26;
            this.XYCheckBox.Text = "Use X and Y";
            this.XYCheckBox.UseVisualStyleBackColor = true;
            // 
            // WaitLabel
            // 
            this.WaitLabel.AutoSize = true;
            this.WaitLabel.Location = new System.Drawing.Point(18, 440);
            this.WaitLabel.Name = "WaitLabel";
            this.WaitLabel.Size = new System.Drawing.Size(119, 13);
            this.WaitLabel.TabIndex = 24;
            this.WaitLabel.Text = "Wait Time (Miliseconds)";
            this.WaitLabel.Visible = false;
            // 
            // TypeTextLabel
            // 
            this.TypeTextLabel.AutoSize = true;
            this.TypeTextLabel.Location = new System.Drawing.Point(17, 224);
            this.TypeTextLabel.Name = "TypeTextLabel";
            this.TypeTextLabel.Size = new System.Drawing.Size(55, 13);
            this.TypeTextLabel.TabIndex = 24;
            this.TypeTextLabel.Text = "Type Text";
            this.TypeTextLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Popup Title";
            this.label1.Visible = false;
            // 
            // PopupTitleLabel
            // 
            this.PopupTitleLabel.AutoSize = true;
            this.PopupTitleLabel.Location = new System.Drawing.Point(18, 316);
            this.PopupTitleLabel.Name = "PopupTitleLabel";
            this.PopupTitleLabel.Size = new System.Drawing.Size(61, 13);
            this.PopupTitleLabel.TabIndex = 23;
            this.PopupTitleLabel.Text = "Popup Title";
            this.PopupTitleLabel.Visible = false;
            // 
            // PopupTextLabel
            // 
            this.PopupTextLabel.AutoSize = true;
            this.PopupTextLabel.Location = new System.Drawing.Point(18, 355);
            this.PopupTextLabel.Name = "PopupTextLabel";
            this.PopupTextLabel.Size = new System.Drawing.Size(62, 13);
            this.PopupTextLabel.TabIndex = 22;
            this.PopupTextLabel.Text = "Popup Text";
            this.PopupTextLabel.Visible = false;
            // 
            // TypeTextInput
            // 
            this.TypeTextInput.Location = new System.Drawing.Point(8, 242);
            this.TypeTextInput.Name = "TypeTextInput";
            this.TypeTextInput.Size = new System.Drawing.Size(131, 20);
            this.TypeTextInput.TabIndex = 21;
            this.TypeTextInput.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            // 
            // PopupTitleInput
            // 
            this.PopupTitleInput.Location = new System.Drawing.Point(8, 332);
            this.PopupTitleInput.Name = "PopupTitleInput";
            this.PopupTitleInput.Size = new System.Drawing.Size(131, 20);
            this.PopupTitleInput.TabIndex = 19;
            this.PopupTitleInput.Visible = false;
            // 
            // PopupTextInput
            // 
            this.PopupTextInput.Location = new System.Drawing.Point(8, 371);
            this.PopupTextInput.Name = "PopupTextInput";
            this.PopupTextInput.Size = new System.Drawing.Size(131, 20);
            this.PopupTextInput.TabIndex = 18;
            this.PopupTextInput.Visible = false;
            // 
            // AddPopup
            // 
            this.AddPopup.Location = new System.Drawing.Point(7, 287);
            this.AddPopup.Name = "AddPopup";
            this.AddPopup.Size = new System.Drawing.Size(95, 26);
            this.AddPopup.TabIndex = 13;
            this.AddPopup.Text = "Add Popup";
            this.AddPopup.UseVisualStyleBackColor = true;
            this.AddPopup.Click += new System.EventHandler(this.AddPopup_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add Wait";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddWait_Click);
            // 
            // AddType
            // 
            this.AddType.Location = new System.Drawing.Point(7, 195);
            this.AddType.Name = "AddType";
            this.AddType.Size = new System.Drawing.Size(95, 26);
            this.AddType.TabIndex = 10;
            this.AddType.Text = "Add Type";
            this.AddType.UseVisualStyleBackColor = true;
            this.AddType.Click += new System.EventHandler(this.AddType_Click);
            // 
            // MousePositionButton
            // 
            this.MousePositionButton.Location = new System.Drawing.Point(4, 5);
            this.MousePositionButton.Name = "MousePositionButton";
            this.MousePositionButton.Size = new System.Drawing.Size(95, 25);
            this.MousePositionButton.TabIndex = 14;
            this.MousePositionButton.Text = "Mouse Position";
            this.MousePositionButton.UseVisualStyleBackColor = true;
            this.MousePositionButton.Click += new System.EventHandler(this.MousePositionButton_Click);
            // 
            // ClickAction
            // 
            this.ClickAction.Location = new System.Drawing.Point(6, 114);
            this.ClickAction.Name = "ClickAction";
            this.ClickAction.Size = new System.Drawing.Size(95, 26);
            this.ClickAction.TabIndex = 9;
            this.ClickAction.Text = "Add Click Action";
            this.ClickAction.UseVisualStyleBackColor = true;
            this.ClickAction.Click += new System.EventHandler(this.ClickAction_Click);
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
            // FileNameInput
            // 
            this.FileNameInput.Location = new System.Drawing.Point(3, 27);
            this.FileNameInput.Name = "FileNameInput";
            this.FileNameInput.Size = new System.Drawing.Size(121, 20);
            this.FileNameInput.TabIndex = 0;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "File will be put on the in the same\r\ndirectory as the Builder is in.";
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
            this.MainControl.ResumeLayout(false);
            this.MainControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SleepTimeUpDown)).EndInit();
            this.Export.ResumeLayout(false);
            this.Export.PerformLayout();
            this.Credits.ResumeLayout(false);
            this.Credits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MainCode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainControl;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.Button TypeTextConfirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PopupConfirm;
        private System.Windows.Forms.NumericUpDown SleepTimeUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MousePosYTextBox;
        private System.Windows.Forms.TextBox MousePosXTextBox;
        private System.Windows.Forms.CheckBox XYCheckBox;
        private System.Windows.Forms.Label TypeTextLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PopupTitleLabel;
        private System.Windows.Forms.Label PopupTextLabel;
        private System.Windows.Forms.TextBox TypeTextInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox PopupTitleInput;
        private System.Windows.Forms.TextBox PopupTextInput;
        private System.Windows.Forms.Button AddPopup;
        private System.Windows.Forms.Button AddType;
        private System.Windows.Forms.Button MousePositionButton;
        private System.Windows.Forms.Button ClickAction;
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
    }
}

