namespace Motion_GUI
{
    partial class Panel_IO
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModule = new System.Windows.Forms.ComboBox();
            this.contextMenuIO = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.forceTRUEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.contextMenuIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module: ";
            // 
            // cbModule
            // 
            this.cbModule.FormattingEnabled = true;
            this.cbModule.Location = new System.Drawing.Point(72, 12);
            this.cbModule.Name = "cbModule";
            this.cbModule.Size = new System.Drawing.Size(331, 21);
            this.cbModule.TabIndex = 1;
            this.cbModule.SelectedIndexChanged += new System.EventHandler(this.cbModule_SelectedIndexChanged);
            // 
            // contextMenuIO
            // 
            this.contextMenuIO.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forceTRUEToolStripMenuItem,
            this.releaseValueToolStripMenuItem});
            this.contextMenuIO.Name = "contextMenuIO";
            this.contextMenuIO.Size = new System.Drawing.Size(137, 48);
            // 
            // forceTRUEToolStripMenuItem
            // 
            this.forceTRUEToolStripMenuItem.Name = "forceTRUEToolStripMenuItem";
            this.forceTRUEToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.forceTRUEToolStripMenuItem.Text = "Write TRUE";
            this.forceTRUEToolStripMenuItem.Click += new System.EventHandler(this.forceTRUEToolStripMenuItem_Click);
            // 
            // releaseValueToolStripMenuItem
            // 
            this.releaseValueToolStripMenuItem.Name = "releaseValueToolStripMenuItem";
            this.releaseValueToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.releaseValueToolStripMenuItem.Text = "Write FALSE";
            this.releaseValueToolStripMenuItem.Click += new System.EventHandler(this.releaseValueToolStripMenuItem_Click);
            // 
            // panelInput
            // 
            this.panelInput.AutoScroll = true;
            this.panelInput.Location = new System.Drawing.Point(21, 60);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(382, 475);
            this.panelInput.TabIndex = 4;
            // 
            // panelOutput
            // 
            this.panelOutput.AutoScroll = true;
            this.panelOutput.Location = new System.Drawing.Point(409, 60);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(382, 475);
            this.panelOutput.TabIndex = 5;
            // 
            // Panel_IO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.cbModule);
            this.Controls.Add(this.label1);
            this.Name = "Panel_IO";
            this.Size = new System.Drawing.Size(807, 555);
            this.Load += new System.EventHandler(this.Panel_IO_Load);
            this.contextMenuIO.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModule;
        private System.Windows.Forms.ContextMenuStrip contextMenuIO;
        private System.Windows.Forms.ToolStripMenuItem forceTRUEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseValueToolStripMenuItem;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelOutput;
    }
}
