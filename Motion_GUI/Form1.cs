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
using System.IO;
using System.Xml;

namespace Motion_GUI
{
    public partial class Form1 : Form
    {
        Panel_Axes panelAxes;
        Panel_IO panelIO;
        public TcAdsClient client = new TcAdsClient();
        public string xmlFile, debugVar;
        public int debugVarHandle;
        public bool debugState;
        XmlDocument docu = new XmlDocument();
        XmlNodeList savedTargets;

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

            checkSavedTargets();   
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            panelMain.Controls.Remove(panelAxes);
            panelMain.Controls.Remove(panelIO);
            client.Dispose();
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
                

                if (tbAmsNetId.Text == "") statusLabel.Text = "Connected to local computer.";
                else statusLabel.Text = "Connected to " + tbAmsNetId.Text;
                
                //search for xml file
                xmlFile = searchXML();
                if (xmlFile == "")
                {
                    MessageBox.Show("XML file for the specified AMS Net Id is not found.");
                    return;
                }else
                {
                    statusLabel.Text = xmlFile + " loaded.";
                    panelAxes = new Panel_Axes();
                    panelIO = new Panel_IO();

                    //search for debugging flag
                    XmlDocument doc = new XmlDocument();
                    doc.Load(xmlFile);
                    if(doc.SelectSingleNode("/Config/DebugVariable") != null)
                    {
                        debugVar = doc.SelectSingleNode("/Config/DebugVariable").InnerText;
                        if(debugVar != "")
                        {
                            try
                            {
                                debugVarHandle = client.CreateVariableHandle(debugVar);
                                cbDebugging.Enabled = true;
                            }
                            catch
                            {
                                MessageBox.Show("DebugVariable name is not correct.\nPlease check your XML file.");
                                return;
                            }
                        }
                    }
                    else
                    {
                        debugVar = "";
                    }

                    if (debugVar == "")
                    {
                        statusLabel.Text = "Debug variable is not found in XML.";
                    }

                    btnDisconnect.Enabled = true;
                    btnConnect.Enabled = false;
                    btnAxes.Enabled = true;
                    btnIo.Enabled = true;
                }

                //check if the connected has been added to xml
                bool notAdded = true;

                foreach(XmlNode node in savedTargets)
                {
                    if (node.InnerText == tbAmsNetId.Text) notAdded = false;
                }

                if (notAdded)
                {
                    //add to xml file
                    XmlElement newAms = docu.CreateElement("AmsNetId");
                    newAms.InnerText = tbAmsNetId.Text;
                    docu.DocumentElement.InsertBefore(newAms, docu.DocumentElement.FirstChild);
                    docu.Save("SavedTargets.xml");
                }
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
                btnAxes.Enabled = false;
                btnIo.Enabled = false;
                cbDebugging.Enabled = false;
                cbDebugging.Checked = false;
                debugState = false;
                statusLabel.Text = "Disconnected";

                checkSavedTargets();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkSavedTargets()
        {
            docu.Load("SavedTargets.xml");
            savedTargets = docu.SelectNodes("/Targets/AmsNetId");

            tbAmsNetId.Items.Clear();
            foreach (XmlNode node in savedTargets)
            {
                tbAmsNetId.Items.Add(node.InnerText);
            }
        }

        private string searchXML()
        {
            string[] files = Directory.GetFiles("Setup").Where(o => o.EndsWith(".xml")).ToArray();
            XmlDocument doc = new XmlDocument();
            foreach (string file in files)
            {
                doc.Load(file);
                string amsNetId = doc.SelectSingleNode("/Config/AmsNetId").InnerText;
                if (amsNetId == tbAmsNetId.Text)
                {
                    return file;
                }
            }
            return "";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            textBox1.Width = this.Width;
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            frmAbout formAbout = new frmAbout();
            formAbout.Show();
        }

        private void menuHelp_Click(object sender, EventArgs e)
        {
            frmHelp formHelp = new frmHelp();
            formHelp.Show();
        }

        private void cbDebugging_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (client.IsConnected)
                {
                    if (cbDebugging.Checked)
                    {
                        client.WriteAny(debugVarHandle, true);
                        debugState = true;
                    }
                    else
                    {
                        client.WriteAny(debugVarHandle, false);
                        debugState = false;
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error accessing variable.\nPlease make sure the variable name in XML file is correct.");
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
