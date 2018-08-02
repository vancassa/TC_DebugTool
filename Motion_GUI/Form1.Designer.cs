using System.Windows.Forms;

namespace Motion_GUI
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnAxes = new System.Windows.Forms.Button();
            this.btnIo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDebugging = new System.Windows.Forms.CheckBox();
            this.tbAmsNetId = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(0, 135);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(818, 541);
            this.panelMain.TabIndex = 0;
            // 
            // btnAxes
            // 
            this.btnAxes.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAxes.Enabled = false;
            this.btnAxes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAxes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAxes.Location = new System.Drawing.Point(604, 41);
            this.btnAxes.Name = "btnAxes";
            this.btnAxes.Size = new System.Drawing.Size(98, 54);
            this.btnAxes.TabIndex = 1;
            this.btnAxes.Text = "MOTION";
            this.btnAxes.UseVisualStyleBackColor = false;
            this.btnAxes.Click += new System.EventHandler(this.btnAxes_Click);
            // 
            // btnIo
            // 
            this.btnIo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIo.Enabled = false;
            this.btnIo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIo.Location = new System.Drawing.Point(708, 41);
            this.btnIo.Name = "btnIo";
            this.btnIo.Size = new System.Drawing.Size(98, 54);
            this.btnIo.TabIndex = 2;
            this.btnIo.Text = "I/O";
            this.btnIo.UseVisualStyleBackColor = false;
            this.btnIo.Click += new System.EventHandler(this.btnIo_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Maroon;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(-9, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(827, 102);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ams Net ID:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(275, 57);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(356, 57);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem1.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 677);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(818, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Set empty for local target";
            // 
            // cbDebugging
            // 
            this.cbDebugging.AutoSize = true;
            this.cbDebugging.BackColor = System.Drawing.Color.DarkRed;
            this.cbDebugging.Enabled = false;
            this.cbDebugging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDebugging.ForeColor = System.Drawing.Color.White;
            this.cbDebugging.Location = new System.Drawing.Point(604, 101);
            this.cbDebugging.Name = "cbDebugging";
            this.cbDebugging.Size = new System.Drawing.Size(145, 19);
            this.cbDebugging.TabIndex = 11;
            this.cbDebugging.Text = "Enable Debugging";
            this.cbDebugging.UseVisualStyleBackColor = false;
            this.cbDebugging.CheckedChanged += new System.EventHandler(this.cbDebugging_CheckedChanged);
            // 
            // tbAmsNetId
            // 
            this.tbAmsNetId.FormattingEnabled = true;
            this.tbAmsNetId.Location = new System.Drawing.Point(106, 57);
            this.tbAmsNetId.Name = "tbAmsNetId";
            this.tbAmsNetId.Size = new System.Drawing.Size(152, 21);
            this.tbAmsNetId.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 699);
            this.Controls.Add(this.tbAmsNetId);
            this.Controls.Add(this.cbDebugging);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIo);
            this.Controls.Add(this.btnAxes);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Motion_GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMain;
        private Button btnAxes;
        private Button btnIo;
        private TextBox textBox1;
        private Label label1;
        private Button btnConnect;
        private Button btnDisconnect;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private Label label2;
        private CheckBox cbDebugging;
        private ComboBox tbAmsNetId;
    }
}

