using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;
using System.Xml;

namespace Motion_GUI
{
    public partial class Panel_Axes : UserControl
    {
        //TcAdsClient client = new TcAdsClient();

        public static bool enable, enableFw, enableBw;
        public static double lrOverride;
        public Control activeForm;


        frmEnable testForm;

        Axis axis = new Axis();
        List<Axis> axes = new List<Axis>();
        int idxAxis = 0;

        public Panel_Axes()
        {
            InitializeComponent();
        }

        private void comboFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFunction.Text == "Move Velocity")
            {
                tbTargetPos.Enabled = false;
            }
            else
            {
                tbTargetPos.Enabled = true;
            }
        }

        

        private void btnHome_MouseUp(object sender, MouseEventArgs e)
        {
            ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlHome, false);
        }

        private void btnHome_MouseDown(object sender, MouseEventArgs e)
        {
            ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlHome, true);
        }

        private void btnReset_MouseUp(object sender, MouseEventArgs e)
        {
            ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlReset, false);
        }

        private void btnReset_MouseDown(object sender, MouseEventArgs e)
        {
            ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlReset, true);
        }

        private void btnStop_MouseUp(object sender, MouseEventArgs e)
        {
            ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlStop, false);
        }

        private void btnStop_MouseDown(object sender, MouseEventArgs e)
        {
            ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlStop, true);
        }

        private void btnAbsMove_MouseUp(object sender, MouseEventArgs e)
        {
            if (comboFunction.Text == "Move Absolute")
            {
                ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlAbsMove, false);
            }
            else if (comboFunction.Text == "Move Relative")
            {
                ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlRelMove, false);
            }
            else if (comboFunction.Text == "Move Velocity")
            {
                ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlMoveVelo, false);
            }
        }

        private void btnJogFw_MouseUp(object sender, MouseEventArgs e)
        {
            ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlJogFw, false);
        }

        private void btnJogFw_MouseDown(object sender, MouseEventArgs e)
        {
            ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlJogFw, true);
        }

        private void btnJogBw_MouseUp(object sender, MouseEventArgs e)
        {
            ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlJogBw, false);
        }

        private void btnJogBw_MouseDown(object sender, MouseEventArgs e)
        {
            ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlJogBw, true);
        }
        
        private void tabAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            idxAxis = tabAxis.SelectedIndex;
            //refresh values
            double temp = (double)((Form1)activeForm).client.ReadAny(axes[idxAxis].hdlActPos, typeof(double));
            tbActPos.Text = temp.ToString("#0.0000");
            temp = (double)((Form1)activeForm).client.ReadAny(axes[idxAxis].hdlActVelo, typeof(double));
            tbActVelo.Text = temp.ToString("#0.0000");

            tbErrId.Text = ((Form1)activeForm).client.ReadAny(axes[idxAxis].hdlErrId, typeof(uint)).ToString();
            cbReady.Checked = (bool)((Form1)activeForm).client.ReadAny(axes[idxAxis].hdlReady, typeof(bool));
            cbController.Checked = (bool)((Form1)activeForm).client.ReadAny(axes[idxAxis].hdlEnable, typeof(bool));
            cbFwd.Checked = (bool)((Form1)activeForm).client.ReadAny(axes[idxAxis].hdlEnablePos, typeof(bool));
            cbBwd.Checked = (bool)((Form1)activeForm).client.ReadAny(axes[idxAxis].hdlEnableNeg, typeof(bool));

        }

        void testFunction(object sender, FormClosedEventArgs e)
        {
            if (enable) { ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlEnable, true); cbController.Checked = true; }
            else { ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlEnable, false); cbController.Checked = false; }

            if (enableFw) { ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlEnablePos, true); cbFwd.Checked = true; }
            else { ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlEnablePos, false); cbFwd.Checked = false; }

            if (enableBw) { ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlEnableNeg, true); cbBwd.Checked = true; }
            else { ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlEnableNeg, false); cbBwd.Checked = false; }

            this.Enabled = true;

        }

        private void Panel_Axes_ControlRemoved(object sender, ControlEventArgs e)
        {
            ((Form1)activeForm).client.Dispose();
            MessageBox.Show("Panel axes removed");
        }

        private void btnSet_Click(object sender, MouseEventArgs e)
        {
            this.Enabled = false;
            testForm = new frmEnable(cbController.Checked, cbFwd.Checked, cbBwd.Checked);
            testForm.Show();
            testForm.FormClosed += new FormClosedEventHandler(testFunction);
        }

        private void btnAbsMove_Click(object sender, MouseEventArgs e)
        {
            if (comboFunction.Text == "Move Absolute")
            {
                ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlAbsPos, double.Parse(tbTargetPos.Text));
                ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlAbsVelo, double.Parse(tbTargetVelo.Text));
                ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlAbsMove, true);
            }
            else if (comboFunction.Text == "Move Relative")
            {
                ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlRelPos, Double.Parse(tbTargetPos.Text));
                ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlRelVelo, double.Parse(tbTargetVelo.Text));
                ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlRelMove, true);
            }
            else if (comboFunction.Text == "Move Velocity")
            {
                double velo = double.Parse(tbTargetVelo.Text);
                if (velo == 0)
                {
                    MessageBox.Show("Velocity cannot be 0.", "Warning");
                }
                else if (velo < 0)
                {
                    ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlVeloVelo, double.Parse(tbTargetVelo.Text) * -1);
                    ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlVeloDirection, (short)3); //negative direction
                    ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlMoveVelo, true);
                }
                else
                {
                    ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlVeloVelo, double.Parse(tbTargetVelo.Text));
                    ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlVeloDirection, (short)1); //positive direction
                    ((Form1)activeForm).client.WriteAny(axes[idxAxis].hdlMoveVelo, true);
                }

            }
            else if (comboFunction.Text == "")
            {
                MessageBox.Show("Please select a function.", "Warning");
            }
        }

        private void Panel_Axes_Load(object sender, EventArgs e)
        {
            activeForm = this.FindForm();
            try
            {
                ((Form1)activeForm).client.Connect(851);

                //Read XML
                XmlDocument doc = new XmlDocument();
                doc.Load("Variables.xml");

                XmlNode axesNode = doc.SelectSingleNode("/Config/Axes");
                XmlNodeList axisList = axesNode.SelectNodes("Axis");

                foreach (XmlNode axisNode in axisList)
                {
                    Axis axis = new Axis();
                    axis.varEnable = axisNode.SelectSingleNode("Enable").InnerText;
                    axis.varEnablePos = axisNode.SelectSingleNode("Enable_Positive").InnerText;
                    axis.varEnableNeg = axisNode.SelectSingleNode("Enable_Negative").InnerText;
                    axis.varOverride = axisNode.SelectSingleNode("Override").InnerText;

                    axis.varJogFw = axisNode.SelectSingleNode("JogFwd").InnerText;
                    axis.varJogBw = axisNode.SelectSingleNode("JogBwd").InnerText;
                    axis.varAbsPos = axisNode.SelectSingleNode("MoveAbsPosition").InnerText;
                    axis.varAbsVelo = axisNode.SelectSingleNode("MoveAbsVelocity").InnerText;
                    axis.varAbsMove = axisNode.SelectSingleNode("MoveAbs").InnerText;
                    axis.varStop = axisNode.SelectSingleNode("Stop").InnerText;
                    axis.varReset = axisNode.SelectSingleNode("Reset").InnerText;
                    axis.varHome = axisNode.SelectSingleNode("Home").InnerText;

                    axis.varRelMove = axisNode.SelectSingleNode("MoveRelative").InnerText;
                    axis.varRelPos = axisNode.SelectSingleNode("MoveRelDistance").InnerText;
                    axis.varRelVelo = axisNode.SelectSingleNode("MoveRelVelocity").InnerText;
                    axis.varMoveVelo = axisNode.SelectSingleNode("MoveVelocity").InnerText;
                    axis.varVeloVelo = axisNode.SelectSingleNode("MoveVeloVelocity").InnerText;
                    axis.varVeloDirection = axisNode.SelectSingleNode("MoveVeloDirection").InnerText;

                    axis.varReady = axisNode.SelectSingleNode("Ready").InnerText;
                    axis.varActPos = axisNode.SelectSingleNode("ActPos").InnerText;
                    axis.varActVelo = axisNode.SelectSingleNode("ActVelo").InnerText;
                    axis.varErrId = axisNode.SelectSingleNode("ErrorId").InnerText;

                    //create handle
                    axis.hdlEnable = ((Form1)activeForm).client.CreateVariableHandle(axis.varEnable);
                    axis.hdlEnableNeg = ((Form1)activeForm).client.CreateVariableHandle(axis.varEnablePos);
                    axis.hdlEnablePos = ((Form1)activeForm).client.CreateVariableHandle(axis.varEnableNeg);
                    axis.hdlOverride = ((Form1)activeForm).client.CreateVariableHandle(axis.varOverride);

                    axis.hdlJogFw = ((Form1)activeForm).client.CreateVariableHandle(axis.varJogFw);
                    axis.hdlJogBw = ((Form1)activeForm).client.CreateVariableHandle(axis.varJogBw);
                    axis.hdlAbsPos = ((Form1)activeForm).client.CreateVariableHandle(axis.varAbsPos);
                    axis.hdlAbsVelo = ((Form1)activeForm).client.CreateVariableHandle(axis.varAbsVelo);
                    axis.hdlAbsMove = ((Form1)activeForm).client.CreateVariableHandle(axis.varAbsMove);
                    axis.hdlStop = ((Form1)activeForm).client.CreateVariableHandle(axis.varStop);
                    axis.hdlReset = ((Form1)activeForm).client.CreateVariableHandle(axis.varReset);
                    axis.hdlHome = ((Form1)activeForm).client.CreateVariableHandle(axis.varHome);

                    axis.hdlRelMove = ((Form1)activeForm).client.CreateVariableHandle(axis.varRelMove);
                    axis.hdlRelPos = ((Form1)activeForm).client.CreateVariableHandle(axis.varRelPos);
                    axis.hdlRelVelo = ((Form1)activeForm).client.CreateVariableHandle(axis.varRelVelo);
                    axis.hdlMoveVelo = ((Form1)activeForm).client.CreateVariableHandle(axis.varMoveVelo);
                    axis.hdlVeloVelo = ((Form1)activeForm).client.CreateVariableHandle(axis.varVeloVelo);
                    axis.hdlVeloDirection = ((Form1)activeForm).client.CreateVariableHandle(axis.varVeloDirection);

                    axis.hdlReady = ((Form1)activeForm).client.CreateVariableHandle(axis.varReady);
                    axis.hdlActPos = ((Form1)activeForm).client.CreateVariableHandle(axis.varActPos);
                    axis.hdlActVelo = ((Form1)activeForm).client.CreateVariableHandle(axis.varActVelo);
                    axis.hdlErrId = ((Form1)activeForm).client.CreateVariableHandle(axis.varErrId);

                    
                    axis.hdlReadyNotif = ((Form1)activeForm).client.AddDeviceNotificationEx(axis.varReady, AdsTransMode.OnChange, 100, 100, cbReady, typeof(bool));
                    axis.hdlActPosNotif = ((Form1)activeForm).client.AddDeviceNotificationEx(axis.varActPos, AdsTransMode.OnChange, 100, 100, tbActPos, typeof(double));
                    axis.hdlActVeloNotif = ((Form1)activeForm).client.AddDeviceNotificationEx(axis.varActVelo, AdsTransMode.OnChange, 100, 100, tbActVelo, typeof(double));
                    axis.hdlErrIdNotif = ((Form1)activeForm).client.AddDeviceNotificationEx(axis.varErrId, AdsTransMode.OnChange, 100, 100, tbErrId, typeof(uint));

                    axes.Add(axis);
                    TabPage tp = new TabPage("Axis " + axes.Count.ToString());
                    tabAxis.TabPages.Add(tp);
                }
                //create notification for status
                ((Form1)activeForm).client.AdsNotificationEx += new AdsNotificationExEventHandler(onNotification);

                double temp = (double)((Form1)activeForm).client.ReadAny(axes[idxAxis].hdlActPos, typeof(double));
                tbActPos.Text = temp.ToString("#0.0000");
                temp = (double)((Form1)activeForm).client.ReadAny(axes[idxAxis].hdlActVelo, typeof(double));
                tbActVelo.Text = temp.ToString("#0.0000");

                tbErrId.Text = ((Form1)activeForm).client.ReadAny(axes[idxAxis].hdlErrId, typeof(uint)).ToString();
                cbReady.Checked = (bool)((Form1)activeForm).client.ReadAny(axes[idxAxis].hdlReady, typeof(bool));
                cbController.Checked = (bool)((Form1)activeForm).client.ReadAny(axes[idxAxis].hdlEnable, typeof(bool));
                cbFwd.Checked = (bool)((Form1)activeForm).client.ReadAny(axes[idxAxis].hdlEnablePos, typeof(bool));
                cbBwd.Checked = (bool)((Form1)activeForm).client.ReadAny(axes[idxAxis].hdlEnableNeg, typeof(bool));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error loading page.\n\nPlease make sure: \n1.TwinCAT is running \n2.TwinCAT variable names match the \"Variables.xml\" file", "Error");

            }
        }
        

        void onNotification(object sender, AdsNotificationExEventArgs e)
        {
            if (e.NotificationHandle == axes[idxAxis].hdlReadyNotif)
            {
                CheckBox cbReady = e.UserData as CheckBox;
                if (cbReady != null)
                {
                    cbReady.Checked = (bool)e.Value;
                }
            }
            else if (e.NotificationHandle == axes[idxAxis].hdlActPosNotif)
            {
                TextBox tbActPos = e.UserData as TextBox;
                if (tbActPos != null)
                {
                    double pos = (double)e.Value;
                    tbActPos.Text = pos.ToString("#0.0000");
                }
            }
            else if (e.NotificationHandle == axes[idxAxis].hdlActVeloNotif)
            {
                double velo = (double)e.Value;
                tbActVelo.Text = velo.ToString("#0.0000");
            }
            else if (e.NotificationHandle == axes[idxAxis].hdlErrIdNotif)
            {
                TextBox tbErrId = e.UserData as TextBox;
                if (tbErrId != null)
                {
                    tbErrId.Text = e.Value.ToString();
                    if (tbErrId.Text == "0") tbErrId.ForeColor = Color.Black;
                    else tbErrId.ForeColor = Color.Red;
                }
            }
        }

    }

    
}
