
namespace REExtraUtils
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbLocalhostIP = new System.Windows.Forms.RadioButton();
            this.rbUseTextIP = new System.Windows.Forms.RadioButton();
            this.txtCustomIP = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeHost = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbHostDomains = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numDups = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChooseDupExe = new System.Windows.Forms.Button();
            this.txtREDupSrc = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreateDups = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.rtbLinks = new System.Windows.Forms.RichTextBox();
            this.dlgChooseDup = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDups)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "R.E Extra Utils | YoniXw | Sep. 2025 | v1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(417, 493);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.rtbHostDomains);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtCustomIP);
            this.tabPage1.Controls.Add(this.rbUseTextIP);
            this.tabPage1.Controls.Add(this.rbLocalhostIP);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(409, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1] Hosts / Redirect";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.numDups);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(409, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2] Duplicate Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rbLocalhostIP
            // 
            this.rbLocalhostIP.AutoSize = true;
            this.rbLocalhostIP.Checked = true;
            this.rbLocalhostIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbLocalhostIP.Location = new System.Drawing.Point(4, 4);
            this.rbLocalhostIP.Name = "rbLocalhostIP";
            this.rbLocalhostIP.Padding = new System.Windows.Forms.Padding(3);
            this.rbLocalhostIP.Size = new System.Drawing.Size(401, 26);
            this.rbLocalhostIP.TabIndex = 0;
            this.rbLocalhostIP.TabStop = true;
            this.rbLocalhostIP.Text = "Point to this pc (127.0.0.1)";
            this.rbLocalhostIP.UseVisualStyleBackColor = true;
            // 
            // rbUseTextIP
            // 
            this.rbUseTextIP.AutoSize = true;
            this.rbUseTextIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbUseTextIP.Location = new System.Drawing.Point(4, 30);
            this.rbUseTextIP.Name = "rbUseTextIP";
            this.rbUseTextIP.Padding = new System.Windows.Forms.Padding(3);
            this.rbUseTextIP.Size = new System.Drawing.Size(401, 26);
            this.rbUseTextIP.TabIndex = 4;
            this.rbUseTextIP.Text = "Point to \"Fake GameSpy\" IP:";
            this.rbUseTextIP.UseVisualStyleBackColor = true;
            // 
            // txtCustomIP
            // 
            this.txtCustomIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCustomIP.Location = new System.Drawing.Point(4, 56);
            this.txtCustomIP.Name = "txtCustomIP";
            this.txtCustomIP.Size = new System.Drawing.Size(401, 22);
            this.txtCustomIP.TabIndex = 5;
            this.txtCustomIP.Text = "255.255.255.255";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnChangeHost);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 151);
            this.panel1.TabIndex = 6;
            // 
            // btnChangeHost
            // 
            this.btnChangeHost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangeHost.Location = new System.Drawing.Point(0, 118);
            this.btnChangeHost.Name = "btnChangeHost";
            this.btnChangeHost.Size = new System.Drawing.Size(401, 33);
            this.btnChangeHost.TabIndex = 0;
            this.btnChangeHost.Text = "Apply changes!";
            this.btnChangeHost.UseVisualStyleBackColor = true;
            this.btnChangeHost.Click += new System.EventHandler(this.btnChangeHost_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 118);
            this.label2.TabIndex = 1;
            this.label2.Text = "This will put GameSpy domains\r\nin the local \"hosts\" file for redirect:\r\nC:\\Window" +
    "s\\System32\\drivers\\etc\\hosts\r\n\r\nNote: This will require to be run as admin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(4, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label3.Size = new System.Drawing.Size(158, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "[*] Domain list to redirect:";
            // 
            // rtbHostDomains
            // 
            this.rtbHostDomains.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbHostDomains.Location = new System.Drawing.Point(4, 100);
            this.rtbHostDomains.Name = "rtbHostDomains";
            this.rtbHostDomains.Size = new System.Drawing.Size(401, 188);
            this.rtbHostDomains.TabIndex = 8;
            this.rtbHostDomains.Text = resources.GetString("rtbHostDomains.Text");
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label4.Size = new System.Drawing.Size(401, 76);
            this.label4.TabIndex = 0;
            this.label4.Text = "This utility will allow you to duplicate\r\nthe RisingEagle.exe file to be opened\r\n" +
    "multiple times in this pc, for multiplayer\r\ntesting\r\n";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(4, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(401, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Change .log to .L??";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(4, 100);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(401, 20);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Change storage.data to storage.D??";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(4, 120);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label5.Size = new System.Drawing.Size(401, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "[*] How many duplicates? (1-99)";
            // 
            // numDups
            // 
            this.numDups.Dock = System.Windows.Forms.DockStyle.Top;
            this.numDups.Location = new System.Drawing.Point(4, 151);
            this.numDups.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numDups.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDups.Name = "numDups";
            this.numDups.Size = new System.Drawing.Size(401, 22);
            this.numDups.TabIndex = 4;
            this.numDups.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(4, 173);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label6.Size = new System.Drawing.Size(401, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "[*] RisingEagle.exe Path:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtREDupSrc);
            this.panel2.Controls.Add(this.btnChooseDupExe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 23);
            this.panel2.TabIndex = 6;
            // 
            // btnChooseDupExe
            // 
            this.btnChooseDupExe.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChooseDupExe.Location = new System.Drawing.Point(354, 0);
            this.btnChooseDupExe.Name = "btnChooseDupExe";
            this.btnChooseDupExe.Size = new System.Drawing.Size(47, 23);
            this.btnChooseDupExe.TabIndex = 0;
            this.btnChooseDupExe.Text = "...";
            this.btnChooseDupExe.UseVisualStyleBackColor = true;
            this.btnChooseDupExe.Click += new System.EventHandler(this.btnChooseDupExe_Click);
            // 
            // txtREDupSrc
            // 
            this.txtREDupSrc.AllowDrop = true;
            this.txtREDupSrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtREDupSrc.Location = new System.Drawing.Point(0, 0);
            this.txtREDupSrc.Name = "txtREDupSrc";
            this.txtREDupSrc.Size = new System.Drawing.Size(354, 22);
            this.txtREDupSrc.TabIndex = 1;
            this.txtREDupSrc.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtREDupSrc_DragDrop);
            this.txtREDupSrc.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtREDupSrc_DragEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnCreateDups);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 215);
            this.panel3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(0, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(401, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Note: This may require to be run as admin\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateDups
            // 
            this.btnCreateDups.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCreateDups.Location = new System.Drawing.Point(0, 182);
            this.btnCreateDups.Name = "btnCreateDups";
            this.btnCreateDups.Size = new System.Drawing.Size(401, 33);
            this.btnCreateDups.TabIndex = 0;
            this.btnCreateDups.Text = "Create Duplicates!";
            this.btnCreateDups.UseVisualStyleBackColor = true;
            this.btnCreateDups.Click += new System.EventHandler(this.btnCreateDups_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(409, 443);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3] Arguments Info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label8.Size = new System.Drawing.Size(403, 40);
            this.label8.TabIndex = 4;
            this.label8.Text = "This are commands I found, putting here for clarity";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtbLinks);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 46);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(409, 443);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "4] Suggested Links";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label9.Size = new System.Drawing.Size(403, 34);
            this.label9.TabIndex = 5;
            this.label9.Text = "This are links I found useful about the history of Rising Eagle";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 43);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(403, 397);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.richTextBox3);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(395, 368);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "RisingEagle.exe";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.richTextBox2);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(395, 368);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Server Admin";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(389, 362);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            this.richTextBox2.WordWrap = false;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Location = new System.Drawing.Point(3, 3);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(389, 362);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            this.richTextBox3.WordWrap = false;
            // 
            // rtbLinks
            // 
            this.rtbLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLinks.Location = new System.Drawing.Point(3, 37);
            this.rtbLinks.Name = "rtbLinks";
            this.rtbLinks.ReadOnly = true;
            this.rtbLinks.Size = new System.Drawing.Size(403, 403);
            this.rtbLinks.TabIndex = 6;
            this.rtbLinks.Text = resources.GetString("rtbLinks.Text");
            this.rtbLinks.WordWrap = false;
            this.rtbLinks.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbLinks_LinkClicked);
            // 
            // dlgChooseDup
            // 
            this.dlgChooseDup.FileName = "RisingEagle.exe";
            this.dlgChooseDup.Filter = "*.exe|*.exe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 518);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R.E Extra Utils | v1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDups)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangeHost;
        private System.Windows.Forms.TextBox txtCustomIP;
        private System.Windows.Forms.RadioButton rbUseTextIP;
        private System.Windows.Forms.RadioButton rbLocalhostIP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbHostDomains;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDups;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreateDups;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtREDupSrc;
        private System.Windows.Forms.Button btnChooseDupExe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox rtbLinks;
        private System.Windows.Forms.OpenFileDialog dlgChooseDup;
    }
}

