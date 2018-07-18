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
        //TcAdsClient ioClient = new TcAdsClient();
        List<Module> moduleList = new List<Module>();
        private Timer timer = new Timer();
        Control activeForm;
        
        public Panel_IO()
        {
            InitializeComponent();
        }

        private void Panel_IO_Load(object sender, EventArgs e)
        {
            activeForm = this.FindForm();
            try
            {
                //ioClient.Connect(851);

                //add notification
                XmlDocument doc = new XmlDocument();
                doc.Load(((Form1)activeForm).xmlFile);

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
                        io.notifHandle = ((Form1)activeForm).client.AddDeviceNotificationEx(io.name, AdsTransMode.OnChange, 100, 100, null, typeof(bool));
                        io.handle = ((Form1)activeForm).client.CreateVariableHandle(io.name);
                        io.type = 1;
                        mod.ioList.Add(io);
                    }

                    XmlNodeList outputs = moduleNode.SelectNodes("Output");
                    foreach(XmlNode output in outputs)
                    {
                        IO io = new IO();
                        io.name = output.SelectSingleNode("VarName").InnerText;
                        io.desc = output.SelectSingleNode("Description").InnerText;
                        io.notifHandle = ((Form1)activeForm).client.AddDeviceNotificationEx(io.name, AdsTransMode.OnChange, 100, 100, null, typeof(bool));
                        io.handle = ((Form1)activeForm).client.CreateVariableHandle(io.name);
                        io.type = 2;
                        mod.ioList.Add(io);
                    }

                    moduleList.Add(mod);
                    cbModule.Items.Add(mod.name);
                }

                ((Form1)activeForm).client.AdsNotificationEx += new AdsNotificationExEventHandler(onNotification);

                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error loading page.\n\nPlease make sure: \n1.TwinCAT is running \n2.TwinCAT variable names match the \"Variables.xml\" file", "Error");
                this.Dispose();
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
                        io.button.BackColor = Color.SpringGreen;
                    }else
                    {
                        //change textbox color to light gray
                        io.button.BackColor = Color.LightGray;
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

            int width = 82, height = 52;

            if (cbModule.SelectedItem.ToString() == "All")
            {
                int i = 0, j=0;
                
                foreach (Module mod in moduleList)
                {
                    foreach(IO io in mod.ioList)
                    {
                        if(io.type == 1)
                        {
                            panelInput.Controls.Add(io.button);
                            io.button.BackColor = Color.LightGray;
                            io.button.ForeColor = Color.Black;
                            io.button.Location = new Point((i % 4) * (width+6) + 7, (i / 4) * (height+6) + 20);
                            io.button.Name = io.name;
                            io.button.Size = new Size(width, height);
                            io.button.FlatStyle = FlatStyle.Flat;
                            io.button.FlatAppearance.MouseOverBackColor = io.button.BackColor;
                            io.button.BackColorChanged += (s, err) =>
                            {
                                io.button.FlatAppearance.MouseOverBackColor = io.button.BackColor;
                            };
                            io.button.TextAlign = ContentAlignment.TopLeft;
                            io.button.Font = new Font(FontFamily.GenericSansSerif, 7);
                            if (io.desc != "") io.button.Text = io.desc;
                            else io.button.Text = io.name;

                            i++;                     
                        }
                        else if(io.type == 2)
                        {
                            panelOutput.Controls.Add(io.button);
                            io.button.BackColor = Color.LightGray;
                            io.button.Location = new Point((j % 4) * (width + 6) + 7, (j / 4) * (height + 6) + 20);
                            io.button.Name = io.name;
                            io.button.Size = new Size(width, height);
                            io.button.FlatStyle = FlatStyle.Flat;
                            io.button.FlatAppearance.MouseOverBackColor = io.button.BackColor;
                            io.button.BackColorChanged += (s, err) =>
                            {
                                io.button.FlatAppearance.MouseOverBackColor = io.button.BackColor;
                            };
                            io.button.TextAlign = ContentAlignment.TopLeft;
                            io.button.Font = new Font(FontFamily.GenericSansSerif, 7);
                            if (io.desc != "") io.button.Text = io.desc;
                            else io.button.Text = io.name;

                            io.button.ContextMenuStrip = this.contextMenuIO;

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
                                panelInput.Controls.Add(io.button);
                                io.button.BackColor = Color.LightGray;
                                io.button.ForeColor = Color.Black;
                                io.button.Location = new Point((i % 4) * (width + 6) + 7, (i / 4) * (height + 6) + 20);
                                io.button.Name = io.name;
                                io.button.Size = new Size(width, height);
                                io.button.FlatStyle = FlatStyle.Flat;
                                io.button.FlatAppearance.MouseOverBackColor = io.button.BackColor;
                                io.button.BackColorChanged += (s, err) =>
                                {
                                    io.button.FlatAppearance.MouseOverBackColor = io.button.BackColor;
                                };
                                io.button.TextAlign = ContentAlignment.TopLeft;
                                io.button.Font = new Font(FontFamily.GenericSansSerif, 7);
                                if (io.desc != "") io.button.Text = io.desc;
                                else io.button.Text = io.name;

                                i++;
                            }
                            else if (io.type == 2)
                            {
                                //add to the right
                                panelOutput.Controls.Add(io.button);
                                io.button.BackColor = Color.LightGray;
                                io.button.Location = new Point((j % 4) * (width + 6) + 7, (j / 4) * (height + 6) + 20);
                                io.button.Name = io.name;
                                io.button.Size = new Size(82, height);
                                io.button.FlatStyle = FlatStyle.Flat;
                                io.button.FlatAppearance.MouseOverBackColor = io.button.BackColor;
                                io.button.BackColorChanged += (s, err) =>
                                {
                                    io.button.FlatAppearance.MouseOverBackColor = io.button.BackColor;
                                };
                                io.button.TextAlign = ContentAlignment.TopLeft;
                                io.button.Font = new Font(FontFamily.GenericSansSerif, 7);
                                if (io.desc != "") io.button.Text = io.desc;
                                else io.button.Text = io.name;

                                io.button.ContextMenuStrip = this.contextMenuIO;
                                j++;
                            }
                        }
                    }
                }
            }
        }
        

        private void forceTRUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
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
                                    ((Form1)activeForm).client.WriteAny(io.handle, true);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error writing value.\nPlease make sure:\n1. TwinCAT is in Running mode.\n2.Variable type is BOOL.");
            }
            
        }

        private void releaseValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
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
                                    ((Form1)activeForm).client.WriteAny(io.handle, false);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error writing value.\nPlease make sure:\n1. TwinCAT is in Running mode.\n2.Variable type is BOOL.");
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
        public Button button = new Button();
    }

    class Module
    {
        public string name;
        public List<IO> ioList = new List<IO>();
    }
}
