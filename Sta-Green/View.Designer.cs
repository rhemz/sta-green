namespace Sta_Green
{
    partial class View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.optionsGroup = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.threshholdField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mouseYField = new System.Windows.Forms.TextBox();
            this.mouseXField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sendMouseCheckbox = new System.Windows.Forms.CheckBox();
            this.sendKeystrokesCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.intervalField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.blockShutdownCheckbox = new System.Windows.Forms.CheckBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.enabledCheckbox = new Sta_Green.BigCheckbox();
            this.optionsGroup.SuspendLayout();
            this.trayIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsGroup
            // 
            this.optionsGroup.Controls.Add(this.label7);
            this.optionsGroup.Controls.Add(this.threshholdField);
            this.optionsGroup.Controls.Add(this.label6);
            this.optionsGroup.Controls.Add(this.mouseYField);
            this.optionsGroup.Controls.Add(this.mouseXField);
            this.optionsGroup.Controls.Add(this.label5);
            this.optionsGroup.Controls.Add(this.label4);
            this.optionsGroup.Controls.Add(this.sendMouseCheckbox);
            this.optionsGroup.Controls.Add(this.sendKeystrokesCheckbox);
            this.optionsGroup.Controls.Add(this.label3);
            this.optionsGroup.Controls.Add(this.intervalField);
            this.optionsGroup.Controls.Add(this.label1);
            this.optionsGroup.Location = new System.Drawing.Point(7, 47);
            this.optionsGroup.Name = "optionsGroup";
            this.optionsGroup.Size = new System.Drawing.Size(170, 160);
            this.optionsGroup.TabIndex = 0;
            this.optionsGroup.TabStop = false;
            this.optionsGroup.Text = "Options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "seconds";
            // 
            // threshholdField
            // 
            this.threshholdField.Location = new System.Drawing.Point(73, 45);
            this.threshholdField.Name = "threshholdField";
            this.threshholdField.Size = new System.Drawing.Size(38, 20);
            this.threshholdField.TabIndex = 10;
            this.threshholdField.Text = "240";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Threshhold:";
            // 
            // mouseYField
            // 
            this.mouseYField.Enabled = false;
            this.mouseYField.Location = new System.Drawing.Point(87, 128);
            this.mouseYField.Name = "mouseYField";
            this.mouseYField.Size = new System.Drawing.Size(34, 20);
            this.mouseYField.TabIndex = 8;
            this.mouseYField.Text = "20";
            // 
            // mouseXField
            // 
            this.mouseXField.Enabled = false;
            this.mouseXField.Location = new System.Drawing.Point(29, 128);
            this.mouseXField.Name = "mouseXField";
            this.mouseXField.Size = new System.Drawing.Size(34, 20);
            this.mouseXField.TabIndex = 7;
            this.mouseXField.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "X:";
            // 
            // sendMouseCheckbox
            // 
            this.sendMouseCheckbox.AutoSize = true;
            this.sendMouseCheckbox.Location = new System.Drawing.Point(10, 104);
            this.sendMouseCheckbox.Name = "sendMouseCheckbox";
            this.sendMouseCheckbox.Size = new System.Drawing.Size(154, 17);
            this.sendMouseCheckbox.TabIndex = 4;
            this.sendMouseCheckbox.Text = "Simulate Mouse Movement";
            this.sendMouseCheckbox.UseVisualStyleBackColor = true;
            // 
            // sendKeystrokesCheckbox
            // 
            this.sendKeystrokesCheckbox.AutoSize = true;
            this.sendKeystrokesCheckbox.Checked = true;
            this.sendKeystrokesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sendKeystrokesCheckbox.Location = new System.Drawing.Point(10, 80);
            this.sendKeystrokesCheckbox.Name = "sendKeystrokesCheckbox";
            this.sendKeystrokesCheckbox.Size = new System.Drawing.Size(114, 17);
            this.sendKeystrokesCheckbox.TabIndex = 3;
            this.sendKeystrokesCheckbox.Text = "Simulate Keyboard";
            this.sendKeystrokesCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "seconds";
            // 
            // intervalField
            // 
            this.intervalField.Location = new System.Drawing.Point(56, 20);
            this.intervalField.Name = "intervalField";
            this.intervalField.Size = new System.Drawing.Size(38, 20);
            this.intervalField.TabIndex = 1;
            this.intervalField.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interval:";
            // 
            // blockShutdownCheckbox
            // 
            this.blockShutdownCheckbox.AutoSize = true;
            this.blockShutdownCheckbox.Location = new System.Drawing.Point(7, 213);
            this.blockShutdownCheckbox.Name = "blockShutdownCheckbox";
            this.blockShutdownCheckbox.Size = new System.Drawing.Size(151, 17);
            this.blockShutdownCheckbox.TabIndex = 13;
            this.blockShutdownCheckbox.Text = "Block Windows Shutdown";
            this.blockShutdownCheckbox.UseVisualStyleBackColor = true;
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayIconMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Sta-Green";
            this.trayIcon.Visible = true;
            // 
            // trayIconMenu
            // 
            this.trayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.trayIconMenu.Name = "trayIconMenu";
            this.trayIconMenu.Size = new System.Drawing.Size(104, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(52, 28);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 15);
            this.statusLabel.TabIndex = 3;
            // 
            // enabledCheckbox
            // 
            this.enabledCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enabledCheckbox.Location = new System.Drawing.Point(56, 6);
            this.enabledCheckbox.Name = "enabledCheckbox";
            this.enabledCheckbox.Size = new System.Drawing.Size(88, 20);
            this.enabledCheckbox.TabIndex = 14;
            this.enabledCheckbox.Text = "Enabled";
            this.enabledCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(184, 233);
            this.Controls.Add(this.blockShutdownCheckbox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.enabledCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.optionsGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "View";
            this.Text = "Sta-Green!";
            this.optionsGroup.ResumeLayout(false);
            this.optionsGroup.PerformLayout();
            this.trayIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox optionsGroup;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox intervalField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mouseYField;
        private System.Windows.Forms.TextBox mouseXField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox sendMouseCheckbox;
        private System.Windows.Forms.CheckBox sendKeystrokesCheckbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox threshholdField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox blockShutdownCheckbox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ContextMenuStrip trayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private BigCheckbox enabledCheckbox;
    }
}

