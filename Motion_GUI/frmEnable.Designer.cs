namespace Motion_GUI
{
    partial class frmEnable
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
            this.btnAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOverride = new System.Windows.Forms.TextBox();
            this.cbBwd = new System.Windows.Forms.CheckBox();
            this.cbFwd = new System.Windows.Forms.CheckBox();
            this.cbController = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(136, 102);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 15;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(136, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(136, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Override [%]:";
            // 
            // tbOverride
            // 
            this.tbOverride.Enabled = false;
            this.tbOverride.Location = new System.Drawing.Point(10, 105);
            this.tbOverride.Name = "tbOverride";
            this.tbOverride.Size = new System.Drawing.Size(100, 20);
            this.tbOverride.TabIndex = 11;
            this.tbOverride.Text = "100";
            // 
            // cbBwd
            // 
            this.cbBwd.AutoSize = true;
            this.cbBwd.Location = new System.Drawing.Point(10, 57);
            this.cbBwd.Name = "cbBwd";
            this.cbBwd.Size = new System.Drawing.Size(68, 17);
            this.cbBwd.TabIndex = 10;
            this.cbBwd.Text = "Feed Bw";
            this.cbBwd.UseVisualStyleBackColor = true;
            // 
            // cbFwd
            // 
            this.cbFwd.AutoSize = true;
            this.cbFwd.Location = new System.Drawing.Point(10, 34);
            this.cbFwd.Name = "cbFwd";
            this.cbFwd.Size = new System.Drawing.Size(67, 17);
            this.cbFwd.TabIndex = 9;
            this.cbFwd.Text = "Feed Fw";
            this.cbFwd.UseVisualStyleBackColor = true;
            // 
            // cbController
            // 
            this.cbController.AutoSize = true;
            this.cbController.Location = new System.Drawing.Point(10, 11);
            this.cbController.Name = "cbController";
            this.cbController.Size = new System.Drawing.Size(70, 17);
            this.cbController.TabIndex = 8;
            this.cbController.Text = "Controller";
            this.cbController.UseVisualStyleBackColor = true;
            // 
            // frmEnable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 139);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOverride);
            this.Controls.Add(this.cbBwd);
            this.Controls.Add(this.cbFwd);
            this.Controls.Add(this.cbController);
            this.Name = "frmEnable";
            this.Text = "frmEnable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOverride;
        private System.Windows.Forms.CheckBox cbBwd;
        private System.Windows.Forms.CheckBox cbFwd;
        private System.Windows.Forms.CheckBox cbController;
    }
}