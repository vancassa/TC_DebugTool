namespace Motion_GUI
{
    partial class Panel_Axes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.comboFunction = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbBwd = new System.Windows.Forms.CheckBox();
            this.cbFwd = new System.Windows.Forms.CheckBox();
            this.cbController = new System.Windows.Forms.CheckBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTargetVelo = new System.Windows.Forms.TextBox();
            this.tbTargetPos = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAbsMove = new System.Windows.Forms.Button();
            this.btnJogFw = new System.Windows.Forms.Button();
            this.btnJogBw = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbReady = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbErrId = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbActVelo = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbActPos = new System.Windows.Forms.TextBox();
            this.tabAxis = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboFunction);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbTargetVelo);
            this.panel1.Controls.Add(this.tbTargetPos);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnAbsMove);
            this.panel1.Controls.Add(this.btnJogFw);
            this.panel1.Controls.Add(this.btnJogBw);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbErrId);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.tbActVelo);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.tbActPos);
            this.panel1.Location = new System.Drawing.Point(15, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 444);
            this.panel1.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(270, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Function:";
            // 
            // comboFunction
            // 
            this.comboFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFunction.FormattingEnabled = true;
            this.comboFunction.Items.AddRange(new object[] {
            "Move Absolute",
            "Move Relative",
            "Move Velocity"});
            this.comboFunction.Location = new System.Drawing.Point(273, 279);
            this.comboFunction.Name = "comboFunction";
            this.comboFunction.Size = new System.Drawing.Size(217, 21);
            this.comboFunction.TabIndex = 56;
            this.comboFunction.SelectedIndexChanged += new System.EventHandler(this.comboFunction_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbBwd);
            this.groupBox3.Controls.Add(this.cbFwd);
            this.groupBox3.Controls.Add(this.cbController);
            this.groupBox3.Controls.Add(this.btnSet);
            this.groupBox3.Location = new System.Drawing.Point(273, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 98);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enabling";
            // 
            // cbBwd
            // 
            this.cbBwd.AutoSize = true;
            this.cbBwd.Location = new System.Drawing.Point(6, 66);
            this.cbBwd.Name = "cbBwd";
            this.cbBwd.Size = new System.Drawing.Size(77, 17);
            this.cbBwd.TabIndex = 6;
            this.cbBwd.Text = "Move Bwd";
            this.cbBwd.UseVisualStyleBackColor = true;
            // 
            // cbFwd
            // 
            this.cbFwd.AutoSize = true;
            this.cbFwd.Location = new System.Drawing.Point(6, 43);
            this.cbFwd.Name = "cbFwd";
            this.cbFwd.Size = new System.Drawing.Size(76, 17);
            this.cbFwd.TabIndex = 5;
            this.cbFwd.Text = "Move Fwd";
            this.cbFwd.UseVisualStyleBackColor = true;
            // 
            // cbController
            // 
            this.cbController.AutoSize = true;
            this.cbController.Location = new System.Drawing.Point(6, 20);
            this.cbController.Name = "cbController";
            this.cbController.Size = new System.Drawing.Size(70, 17);
            this.cbController.TabIndex = 4;
            this.cbController.Text = "Controller";
            this.cbController.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(124, 20);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(55, 23);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Target Velo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Target Position:";
            // 
            // tbTargetVelo
            // 
            this.tbTargetVelo.Location = new System.Drawing.Point(10, 319);
            this.tbTargetVelo.Name = "tbTargetVelo";
            this.tbTargetVelo.Size = new System.Drawing.Size(213, 20);
            this.tbTargetVelo.TabIndex = 53;
            this.tbTargetVelo.Text = "0";
            // 
            // tbTargetPos
            // 
            this.tbTargetPos.Location = new System.Drawing.Point(10, 280);
            this.tbTargetPos.Name = "tbTargetPos";
            this.tbTargetPos.Size = new System.Drawing.Size(213, 20);
            this.tbTargetPos.TabIndex = 52;
            this.tbTargetPos.Text = "0";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(415, 354);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 62);
            this.btnHome.TabIndex = 51;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHome_MouseDown);
            this.btnHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHome_MouseUp);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(334, 354);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 62);
            this.btnReset.TabIndex = 50;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnReset_MouseDown);
            this.btnReset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnReset_MouseUp);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(253, 354);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 62);
            this.btnStop.TabIndex = 49;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseDown);
            this.btnStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // btnAbsMove
            // 
            this.btnAbsMove.Location = new System.Drawing.Point(172, 354);
            this.btnAbsMove.Name = "btnAbsMove";
            this.btnAbsMove.Size = new System.Drawing.Size(75, 62);
            this.btnAbsMove.TabIndex = 48;
            this.btnAbsMove.Text = "Move";
            this.btnAbsMove.UseVisualStyleBackColor = true;
            this.btnAbsMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAbsMove_Click);
            this.btnAbsMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAbsMove_MouseUp);
            // 
            // btnJogFw
            // 
            this.btnJogFw.Location = new System.Drawing.Point(91, 354);
            this.btnJogFw.Name = "btnJogFw";
            this.btnJogFw.Size = new System.Drawing.Size(75, 62);
            this.btnJogFw.TabIndex = 47;
            this.btnJogFw.Text = "Jog +";
            this.btnJogFw.UseVisualStyleBackColor = true;
            this.btnJogFw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogFw_MouseDown);
            this.btnJogFw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogFw_MouseUp);
            // 
            // btnJogBw
            // 
            this.btnJogBw.Location = new System.Drawing.Point(10, 354);
            this.btnJogBw.Name = "btnJogBw";
            this.btnJogBw.Size = new System.Drawing.Size(75, 62);
            this.btnJogBw.TabIndex = 45;
            this.btnJogBw.Text = "Jog -";
            this.btnJogBw.UseVisualStyleBackColor = true;
            this.btnJogBw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogBw_MouseDown);
            this.btnJogBw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogBw_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.cbReady);
            this.groupBox1.Location = new System.Drawing.Point(10, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 98);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status (log.)";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(101, 66);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(79, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Moving Bw";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(101, 43);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(78, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Moving Fw";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(101, 20);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(87, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "NOT Moving";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 66);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(65, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Has Job";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Calibrated";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cbReady
            // 
            this.cbReady.AutoSize = true;
            this.cbReady.Location = new System.Drawing.Point(7, 20);
            this.cbReady.Name = "cbReady";
            this.cbReady.Size = new System.Drawing.Size(57, 17);
            this.cbReady.TabIndex = 0;
            this.cbReady.Text = "Ready";
            this.cbReady.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Override:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Total/Control Output:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Error:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Lag Distance (min/max):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Actual Velocity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Setpoint Velocity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Setpoint Position: ";
            // 
            // tbErrId
            // 
            this.tbErrId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbErrId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbErrId.Location = new System.Drawing.Point(348, 104);
            this.tbErrId.Name = "tbErrId";
            this.tbErrId.Size = new System.Drawing.Size(163, 23);
            this.tbErrId.TabIndex = 35;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(348, 62);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(163, 23);
            this.textBox7.TabIndex = 34;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(348, 20);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(163, 23);
            this.textBox6.TabIndex = 33;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(179, 104);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(163, 23);
            this.textBox5.TabIndex = 32;
            // 
            // tbActVelo
            // 
            this.tbActVelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActVelo.Location = new System.Drawing.Point(179, 62);
            this.tbActVelo.Name = "tbActVelo";
            this.tbActVelo.Size = new System.Drawing.Size(163, 23);
            this.tbActVelo.TabIndex = 31;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(10, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 23);
            this.textBox3.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(10, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 23);
            this.textBox2.TabIndex = 29;
            // 
            // tbActPos
            // 
            this.tbActPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActPos.Location = new System.Drawing.Point(50, 5);
            this.tbActPos.Name = "tbActPos";
            this.tbActPos.Size = new System.Drawing.Size(292, 38);
            this.tbActPos.TabIndex = 28;
            this.tbActPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabAxis
            // 
            this.tabAxis.Location = new System.Drawing.Point(15, 12);
            this.tabAxis.Name = "tabAxis";
            this.tabAxis.SelectedIndex = 0;
            this.tabAxis.Size = new System.Drawing.Size(529, 23);
            this.tabAxis.TabIndex = 2;
            this.tabAxis.SelectedIndexChanged += new System.EventHandler(this.tabAxis_SelectedIndexChanged);
            // 
            // Panel_Axes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabAxis);
            this.Name = "Panel_Axes";
            this.Size = new System.Drawing.Size(567, 499);
            this.Load += new System.EventHandler(this.Panel_Axes_Load);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Panel_Axes_ControlRemoved);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboFunction;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbBwd;
        private System.Windows.Forms.CheckBox cbFwd;
        private System.Windows.Forms.CheckBox cbController;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTargetVelo;
        private System.Windows.Forms.TextBox tbTargetPos;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAbsMove;
        private System.Windows.Forms.Button btnJogFw;
        private System.Windows.Forms.Button btnJogBw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cbReady;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbErrId;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbActVelo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbActPos;
        private System.Windows.Forms.TabControl tabAxis;
    }
}
