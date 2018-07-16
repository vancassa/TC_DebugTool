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
            this.btnAxes.Location = new System.Drawing.Point(12, 12);
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
            this.btnIo.Location = new System.Drawing.Point(136, 12);
            this.btnIo.Name = "btnIo";
            this.btnIo.Size = new System.Drawing.Size(98, 54);
            this.btnIo.TabIndex = 2;
            this.btnIo.Text = "I/O";
            this.btnIo.UseVisualStyleBackColor = false;
            this.btnIo.Click += new System.EventHandler(this.btnIo_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(-1, -1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(818, 82);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 659);
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
    }
}

