using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TwinCAT.Ads;

namespace Motion_GUI
{
    public partial class Panel_IO : UserControl
    {
        TcAdsClient ioClient = new TcAdsClient();
        List<Module> moduleList = new List<Module>();
        private Timer timer = new Timer();
        
        public Panel_IO()
        {
            InitializeComponent();
        }

        private void Panel_IO_Load(object sender, EventArgs e)
        {
            try
            {
                ioClient.Connect(851);

                //add notification
                XmlDocument doc = new XmlDocument();
                doc.Load("Variables.xml");

                XmlNode ioNode = doc.SelectSingleNode("/Config/IO");
                XmlNodeList xmlModuleList = ioNode.SelectNodes("Module");

                cbModule.Items.Add("All");

                foreach(XmlNode moduleNode in xmlModuleList)
                {
                    Module mod = new Module();
                    mod.name = moduleNode.Attributes["Id"].Value;

                    XmlNodeList inputs = moduleNode.SelectNodes("Input");
                    foreach(XmlNode input in inputs)
                    {
                        IO io = new IO();
                        io.name = input.SelectSingleNode("VarName").InnerText;
                        io.desc = input.SelectSingleNode("Description").InnerText;
                        io.notifHandle = ioClient.AddDeviceNotificationEx(io.name, AdsTransMode.OnChange, 100, 100, null, typeof(bool));
                        io.handle = ioClient.CreateVariableHandle(io.name);
                        io.type = 1;
                        mod.ioList.Add(io);
                    }

                    XmlNodeList outputs = moduleNode.SelectNodes("Output");
                    foreach(XmlNode output in outputs)
                    {
                        IO io = new IO();
                        io.name = output.SelectSingleNode("VarName").InnerText;
                        io.desc = output.SelectSingleNode("Description").InnerText;
                        io.notifHandle = ioClient.AddDeviceNotificationEx(io.name, AdsTransMode.OnChange, 100, 100, null, typeof(bool));
                        io.handle = ioClient.CreateVariableHandle(io.name);
                        io.type = 2;
                        mod.ioList.Add(io);
                    }

                    moduleList.Add(mod);
                    cbModule.Items.Add(mod.name);
                }

                ioClient.AdsNotificationEx += new AdsNotificationExEventHandler(onNotification);

                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //update color of textbox
            foreach(Module mod in moduleList)
            {
                foreach(IO io in mod.ioList)
                {
                    if (io.value)
                    {
                        //change textbox color to spring green
                        io.textBox.BackColor = Color.SpringGreen;
                    }else
                    {
                        //change textbox color to light gray
                        io.textBox.BackColor = Color.LightGray;
                    }
                }
            }
        }

        private void onNotification(object sender, AdsNotificationExEventArgs e)
        {
            foreach(Module mod in moduleList)
            {
                foreach(IO io in mod.ioList)
                {
                    if(e.NotificationHandle == io.notifHandle)
                    {
                        io.value = (bool)e.Value;
                    }
                }
            }
        }

        private void cbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelInput.Controls.Clear();
            panelOutput.Controls.Clear();

            if (cbModule.SelectedItem.ToString() == "All")
            {
                int i = 0, j=0;
                
                foreach (Module mod in moduleList)
                {
                    foreach(IO io in mod.ioList)
                    {
                        if(io.type == 1)
                        {
                            //add to the left
                            panelInput.Controls.Add(io.textBox);
                            io.textBox.BackColor = Color.LightGray;
                            io.textBox.ForeColor = Color.Black;
                            io.textBox.BorderStyle = BorderStyle.FixedSingle;
                            io.textBox.Location = new Point((i % 4) * 88 + 7, (i / 4) * 54 + 20);
                            io.textBox.Multiline = true;
                            io.textBox.Name = io.name;
                            io.textBox.Size = new Size(82, 48);
                            io.textBox.Cursor = Cursors.Arrow;
                            if (io.desc != "") io.textBox.Text = io.desc;
                            else io.textBox.Text = io.name;
                            io.textBox.ShortcutsEnabled = false;
                            io.textBox.ReadOnly = true;


                            i++;                     
                        }
                        else if(io.type == 2)
                        {
                            //add to the right
                            panelOutput.Controls.Add(io.textBox);
                            io.textBox.BackColor = Color.LightGray;
                            io.textBox.ForeColor = Color.Black;
                            io.textBox.BorderStyle = BorderStyle.FixedSingle;
                            io.textBox.Location = new Point((j % 4) * 88 + 7, (j / 4) * 54 + 20);
                            io.textBox.Multiline = true;
                            io.textBox.Name = io.name;
                            io.textBox.Size = new Size(82, 48);
                            io.textBox.Cursor = Cursors.Arrow;
                            if (io.desc != "") io.textBox.Text = io.desc;
                            else io.textBox.Text = io.name;
                            io.textBox.ReadOnly = true;

                            io.textBox.ContextMenuStrip = this.contextMenuIO;
                            j++;
                        }
                    }
                }
            }
            else
            {
                int i = 0, j = 0;
                foreach(Module mod in moduleList)
                {
                    if(mod.name == cbModule.SelectedItem.ToString())
                    {
                        foreach(IO io in mod.ioList)
                        {
                            if (io.type == 1)
                            {
                                //add to the left
                                panelInput.Controls.Add(io.textBox);
                                io.textBox.BackColor = Color.LightGray;
                                io.textBox.Location = new Point((i % 4) * 88 + 7, (i / 4) * 54 + 20);
                                io.textBox.Multiline = true;
                                io.textBox.Name = io.name;
                                io.textBox.Size = new Size(82, 48);
                                io.textBox.Cursor = Cursors.Arrow;
                                if (io.desc != "") io.textBox.Text = io.desc;
                                else io.textBox.Text = io.name;
                                io.textBox.ShortcutsEnabled = false;

                                i++;
                            }
                            else if (io.type == 2)
                            {
                                //add to the right
                                panelOutput.Controls.Add(io.textBox);
                                io.textBox.BackColor = Color.LightGray;
                                io.textBox.Location = new Point((j % 4) * 88 + 7, (j / 4) * 54 + 20);
                                io.textBox.Multiline = true;
                                io.textBox.Name = io.name;
                                io.textBox.Size = new Size(82, 48);
                                io.textBox.Cursor = Cursors.Arrow;
                                if (io.desc != "") io.textBox.Text = io.desc;
                                else io.textBox.Text = io.name;

                                io.textBox.ContextMenuStrip = this.contextMenuIO;
                                j++;
                            }
                        }
                    }
                }
            }
        }
        

        private void forceTRUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if(menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if(owner != null)
                {
                    Control textBox = owner.SourceControl;
                    foreach(Module mod in moduleList)
                    {
                        foreach(IO io in mod.ioList)
                        {
                            if (io.name == textBox.Name)
                            {
                                ioClient.WriteAny(io.handle, true);
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void releaseValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    Control textBox = owner.SourceControl;
                    foreach (Module mod in moduleList)
                    {
                        foreach (IO io in mod.ioList)
                        {
                            if (io.name == textBox.Name)
                            {
                                ioClient.WriteAny(io.handle, false);
                                return;
                            }
                        }
                    }
                }
            }
        }
    }

    class IO
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();

        public int handle;
        public int notifHandle;
        public string name;
        public string desc;
        public bool value;
        public int type; //1 = input, 2 = output
        public TextBox textBox = new TextBox();
    }

    class Module
    {
        public string name;
        public List<IO> ioList = new List<IO>();
    }
}
