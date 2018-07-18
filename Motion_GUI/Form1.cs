using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TwinCAT.Ads;

namespace Motion_GUI
{
    public partial class Form1 : Form
    {
        Panel_Axes panelAxes;
        Panel_IO panelIO;
        public TcAdsClient client = new TcAdsClient();
        

        private void btnAxes_Click(object sender, EventArgs e)
        {
            btnAxes.BackColor = Color.Silver;
            btnIo.BackColor = Color.Gainsboro;

            panelAxes.Dock = DockStyle.Fill;

            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(panelAxes);
        }

        private void btnIo_Click(object sender, EventArgs e)
        {
            btnAxes.BackColor = Color.Gainsboro;
            btnIo.BackColor = Color.Silver;

            panelIO.Dock = DockStyle.Fill;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(panelIO);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panelAxes.Dock = DockStyle.Fill;
            //this.panelMain.Controls.Clear();
            //this.panelMain.Controls.Add(panelAxes);

        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            panelMain.Controls.Remove(panelAxes);
            panelMain.Controls.Remove(panelIO);
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            panelMain.Controls.Remove(panelAxes);
            panelMain.Controls.Remove(panelIO);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(tbAmsNetId.Text, 851);
                btnDisconnect.Enabled = true;
                btnConnect.Enabled = false;

                panelAxes = new Panel_Axes();
                panelIO = new Panel_IO();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error connecting to target.\nMake sure you have added route to remote target.\nMake sure TwinCAT in target system is in Run Mode and PLC is running.");

            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Disconnect();
                panelMain.Controls.Remove(panelAxes);
                panelMain.Controls.Remove(panelIO);
                panelAxes.Dispose();
                panelIO.Dispose();
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    class Axis
    {
        public string
            varEnable, varEnablePos, varEnableNeg, varOverride, varReset, varAbsMove, varAbsPos, varAbsVelo,
            varStop, varHalt, varJogFw, varJogBw, varHome, varHomePos, varRelMove, varRelPos, varRelVelo,
            varJogVelo, varMoveVelo, varVeloVelo, varVeloDirection,
            varReady, varActPos, varActVelo, varErrId;

        public int
            hdlEnable, hdlEnablePos, hdlEnableNeg, hdlOverride, hdlReset, hdlAbsMove, hdlAbsPos, hdlAbsVelo,
            hdlStop, hdlHalt, hdlJogFw, hdlJogBw, hdlHome, hdlHomePos, hdlRelMove, hdlRelPos, hdlRelVelo,
            hdlJogVelo, hdlMoveVelo, hdlVeloVelo, hdlVeloDirection,

            hdlReady, hdlActPos, hdlActVelo, hdlErrId,
            hdlReadyNotif, hdlActPosNotif, hdlActVeloNotif, hdlErrIdNotif;
    }
}
