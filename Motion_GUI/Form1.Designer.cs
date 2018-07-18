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
            this.tbAmsNetId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(-1, 87);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(818, 538);
            this.panelMain.TabIndex = 0;
            // 
            // btnAxes
            // 
            this.btnAxes.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAxes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAxes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAxes.Location = new System.Drawing.Point(585, 12);
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
            this.btnIo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIo.Location = new System.Drawing.Point(703, 12);
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
            this.textBox1.Location = new System.Drawing.Point(-1, -1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(818, 82);
            this.textBox1.TabIndex = 3;
            // 
            // tbAmsNetId
            // 
            this.tbAmsNetId.Location = new System.Drawing.Point(105, 30);
            this.tbAmsNetId.Name = "tbAmsNetId";
            this.tbAmsNetId.Size = new System.Drawing.Size(152, 20);
            this.tbAmsNetId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ams Net ID:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(275, 28);
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
            this.btnDisconnect.Location = new System.Drawing.Point(356, 28);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 659);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAmsNetId);
            this.Controls.Add(this.btnIo);
            this.Controls.Add(this.btnAxes);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Motion_GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMain;
        private Button btnAxes;
        private Button btnIo;
        private TextBox textBox1;
        private TextBox tbAmsNetId;
        private Label label1;
        private Button btnConnect;
        private Button btnDisconnect;
    }
}

