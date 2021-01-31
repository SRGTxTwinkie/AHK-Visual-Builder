namespace AHK_Visual_2._0
{
    partial class SettingsForm
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
            this.CheckForInsertAtCursor = new System.Windows.Forms.CheckBox();
            this.CheckForUseNewLine = new System.Windows.Forms.CheckBox();
            this.CheckForUseSend = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxForModKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxForQuickVar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxForFileName = new System.Windows.Forms.TextBox();
            this.ButtonForSave = new System.Windows.Forms.Button();
            this.ButtonForCancel = new System.Windows.Forms.Button();
            this.CheckForMoveInsertion = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CheckForInsertAtCursor
            // 
            this.CheckForInsertAtCursor.AutoSize = true;
            this.CheckForInsertAtCursor.Location = new System.Drawing.Point(154, 12);
            this.CheckForInsertAtCursor.Name = "CheckForInsertAtCursor";
            this.CheckForInsertAtCursor.Size = new System.Drawing.Size(98, 17);
            this.CheckForInsertAtCursor.TabIndex = 0;
            this.CheckForInsertAtCursor.Text = "Insert At Cursor";
            this.CheckForInsertAtCursor.UseVisualStyleBackColor = true;
            // 
            // CheckForUseNewLine
            // 
            this.CheckForUseNewLine.AutoSize = true;
            this.CheckForUseNewLine.Location = new System.Drawing.Point(154, 35);
            this.CheckForUseNewLine.Name = "CheckForUseNewLine";
            this.CheckForUseNewLine.Size = new System.Drawing.Size(93, 17);
            this.CheckForUseNewLine.TabIndex = 1;
            this.CheckForUseNewLine.Text = "Use New Line";
            this.CheckForUseNewLine.UseVisualStyleBackColor = true;
            // 
            // CheckForUseSend
            // 
            this.CheckForUseSend.AutoSize = true;
            this.CheckForUseSend.Location = new System.Drawing.Point(13, 12);
            this.CheckForUseSend.Name = "CheckForUseSend";
            this.CheckForUseSend.Size = new System.Drawing.Size(73, 17);
            this.CheckForUseSend.TabIndex = 2;
            this.CheckForUseSend.Text = "Use Send";
            this.CheckForUseSend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Default Mod Key";
            // 
            // TextBoxForModKey
            // 
            this.TextBoxForModKey.Location = new System.Drawing.Point(32, 85);
            this.TextBoxForModKey.Name = "TextBoxForModKey";
            this.TextBoxForModKey.Size = new System.Drawing.Size(188, 20);
            this.TextBoxForModKey.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quick Var";
            // 
            // TextBoxForQuickVar
            // 
            this.TextBoxForQuickVar.Location = new System.Drawing.Point(32, 124);
            this.TextBoxForQuickVar.Name = "TextBoxForQuickVar";
            this.TextBoxForQuickVar.Size = new System.Drawing.Size(188, 20);
            this.TextBoxForQuickVar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Default File Name";
            // 
            // TextBoxForFileName
            // 
            this.TextBoxForFileName.Location = new System.Drawing.Point(32, 164);
            this.TextBoxForFileName.Name = "TextBoxForFileName";
            this.TextBoxForFileName.Size = new System.Drawing.Size(188, 20);
            this.TextBoxForFileName.TabIndex = 9;
            // 
            // ButtonForSave
            // 
            this.ButtonForSave.Location = new System.Drawing.Point(32, 190);
            this.ButtonForSave.Name = "ButtonForSave";
            this.ButtonForSave.Size = new System.Drawing.Size(84, 27);
            this.ButtonForSave.TabIndex = 10;
            this.ButtonForSave.Text = "Save";
            this.ButtonForSave.UseVisualStyleBackColor = true;
            this.ButtonForSave.Click += new System.EventHandler(this.ButtonForSave_Click);
            // 
            // ButtonForCancel
            // 
            this.ButtonForCancel.Location = new System.Drawing.Point(136, 190);
            this.ButtonForCancel.Name = "ButtonForCancel";
            this.ButtonForCancel.Size = new System.Drawing.Size(84, 27);
            this.ButtonForCancel.TabIndex = 11;
            this.ButtonForCancel.Text = "Cancel";
            this.ButtonForCancel.UseVisualStyleBackColor = true;
            this.ButtonForCancel.Click += new System.EventHandler(this.ButtonForCancel_Click);
            // 
            // CheckForMoveInsertion
            // 
            this.CheckForMoveInsertion.AutoSize = true;
            this.CheckForMoveInsertion.Location = new System.Drawing.Point(12, 35);
            this.CheckForMoveInsertion.Name = "CheckForMoveInsertion";
            this.CheckForMoveInsertion.Size = new System.Drawing.Size(123, 17);
            this.CheckForMoveInsertion.TabIndex = 3;
            this.CheckForMoveInsertion.Text = "Move Insertion Point";
            this.CheckForMoveInsertion.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 231);
            this.Controls.Add(this.ButtonForCancel);
            this.Controls.Add(this.ButtonForSave);
            this.Controls.Add(this.TextBoxForFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxForQuickVar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxForModKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckForMoveInsertion);
            this.Controls.Add(this.CheckForUseSend);
            this.Controls.Add(this.CheckForUseNewLine);
            this.Controls.Add(this.CheckForInsertAtCursor);
            this.Name = "SettingsForm";
            this.Text = "Startup Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckForInsertAtCursor;
        private System.Windows.Forms.CheckBox CheckForUseNewLine;
        private System.Windows.Forms.CheckBox CheckForUseSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxForModKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxForQuickVar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxForFileName;
        private System.Windows.Forms.Button ButtonForSave;
        private System.Windows.Forms.Button ButtonForCancel;
        private System.Windows.Forms.CheckBox CheckForMoveInsertion;
    }
}