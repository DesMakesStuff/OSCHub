using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Sockets;
using System.Net;
using SharpOSC;

namespace OSCHub
{
    public partial class Form1 : Form
    {
        //Fix this eventually
        public static List<String> AppsList = new List<String>();
        public static List<AppObject> AppsObjectList = new List<AppObject>();
        public static List<String> ParamList = new List<String>();
        public static List<OscMessage> ParamObjectList = new List<OscMessage>();

        BindingSource bsApps = new BindingSource();
        public static BindingSource bsParams = new BindingSource();

        
        public int listIndex = 0;
        public static int listIndexParam = 0;
        bool isrun = false;
        public static bool isdebug = false;
        public static Thread serverThread;
       
        

        //WINAPI Vars
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        //Window Dragging WINAPI Voodoo
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        public bool isDuplicateUsed(string pendingName,string pendingPort)
        {
            foreach (AppObject App in AppsObjectList)
            {
                if (App.Port == pendingPort)
                {
                    return true;
                }
                else if(App.Name == pendingName)
                {
                    return true;
                }
            }
            return false;
        }
        public void SaveApps()
        {
            string jsonOut = JsonSerializer.Serialize(AppsObjectList);
            System.IO.File.WriteAllText(Application.StartupPath + "Config.json", jsonOut);
        }

        public Label Label8
        {
            get { return Label_ID; }
        }

        public ListBox parambox
        {
            get { return this.listbox_param; }
        }

        public string LabelText
        {
            get
            {
                return this.Label_ID.Text;
            }

            set
            {
                this.Label_ID.Text = value;
            }
        }



        public void DebugRefresh()
        {
            while (isdebug == true)
            {
                if (ParamObjectList.Count > 0)
                {
                    label_oscaddress.BeginInvoke((MethodInvoker)delegate ()
                    {
                        label_oscaddress.Text = ParamObjectList[listIndexParam].Address;
                    });

                    label_oscvalue.BeginInvoke((MethodInvoker)delegate ()
                    {
                        label_oscvalue.Text = ParamObjectList[listIndexParam].Arguments[0].ToString();
                    });

                    listbox_param.BeginInvoke((MethodInvoker)delegate ()
                    {
                        listbox_param.DataSource = bsParams;
                        bsParams.ResetBindings(false);
                    });

                    Thread.Sleep(2000);
                }
            }
        }

        public string setAddress
        {
            get
            {
                return this.label_oscaddress.Text;
            }

            set
            {
                this.label_oscaddress.Text = value;
            }
        }

        public string setValue
        {
            get
            {
                return this.label_oscvalue.Text;
            }

            set
            {
                this.label_oscvalue.Text = value;
            }
        }

        //Update Avatar ID on UI Thread
        public void UpdateUI(String ID)
        {
            Label_ID.BeginInvoke((MethodInvoker)delegate ()
            {
                Label_ID.Text = ID;
            });
        }

        public Form1()
        {
            Server.IDUpdated += UpdateUI;

            InitializeComponent();
            bsApps.DataSource = AppsList;
            bsParams.DataSource = ParamList;

            //Check for a config file and load it, populating the Apps and AppsObject lists
            if (System.IO.File.Exists(Application.StartupPath + "Config.json"))
            {
                string file = System.IO.File.ReadAllText(Application.StartupPath + "Config.Json");
                AppsObjectList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<AppObject>>(file);
                for (int i = 0; i < AppsObjectList.Count; i++)
                {
                    AppsList.Add(AppsObjectList[i].Name + ":" + AppsObjectList[i].Port);
                }
                lblConnectedApps.Text = "Connected Apps: " + AppsList.Count;
                lAppsBox.DataSource = bsApps;

                bsApps.ResetBindings(false); //Reset bindings to update
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            if(InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate ()
                {
                    this.Close();
                });
            }
            this.Close();
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isrun == false)
            {
                //Start
                Label_SvrStatus.Text = "Online";
                Label_SvrStatus.Font = new Font(Label_SvrStatus.Font, FontStyle.Bold);
                btnStart.Text = "STOP";
                btnStart.BackColor = System.Drawing.Color.Red;
                btnStart.FlatStyle = FlatStyle.Flat;
                btnStart.FlatAppearance.BorderColor = Color.Red;
                isrun = true;

                serverThread = new Thread(Server.StartServer);

                serverThread.Start();
            }

            else
            {
                //Stop

                Label_SvrStatus.Text = "Offline";
                Label_SvrStatus.Font = new Font(Label_SvrStatus.Font, FontStyle.Regular);
                btnStart.Text = "START";
                btnStart.BackColor = System.Drawing.Color.Green;
                btnStart.FlatStyle = FlatStyle.Flat;
                btnStart.FlatAppearance.BorderColor = Color.Green;
                isrun = false;
                Server.listener.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void LblAppPort_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            IPAddress IP;
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtIP.Text) && !String.IsNullOrEmpty(txtPort.Text))
            {
                AppObject Current = new AppObject(AppsList.Count, txtName.Text, txtIP.Text, txtPort.Text);

                if (isDuplicateUsed(Current.Name,Current.Port) == true)
                {
                    MessageBox.Show("The port or name: "+ Current.Name+":"+Current.Port+
                        " is already in use, please use another port");
                }
                else if(IPAddress.TryParse(Current.IP,out IP)==false)
                {
                    MessageBox.Show("The IP Address: " + Current.IP + " is invalid please try another address");
                }
                else
                {
                    AppsObjectList.Add(Current);
                    AppsList.Add(Current.Name.ToString()+":"+Current.Port.ToString());
                    lAppsBox.DataSource = bsApps;

                    bsApps.ResetBindings(false);
                    lblConnectedApps.Text = "Connected Apps: " + AppsList.Count;
                    SaveApps();
                    
                }
            }

            else
            {
                MessageBox.Show("Please fill Name,IP, and port before adding!");
            }
        }

        private void LblAppName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LblAppAddress_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LblAvatarName_Click(object sender, EventArgs e)
        {

        }

        private void AppTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void AppTextBox_Set(string text)
        {

        }

        private void LiveParameterLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lAppsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lAppsBox.SelectedIndex >= 0)
            {
                listIndex = lAppsBox.SelectedIndex;
            }
        }

        private void btnRemoveApp_Click(object sender, EventArgs e)
        {
            AppsList.RemoveAt(listIndex);
            AppsObjectList.RemoveAt(listIndex);
            lblConnectedApps.Text = "Connected Apps: " + AppsList.Count;
            bsApps.ResetBindings(false);
            SaveApps();
        }

    
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LblAvatarInfo_Click(object sender, EventArgs e)
        {

        }

        
        private void btnHome_Click(object sender, EventArgs e)
        {
            panel_param.Hide();
            isdebug = false;
        }

      
        private void btnDebug_Click(object sender, EventArgs e)
        {

            if (isrun == true)
            {
                ErrorText.Hide();
                panel_param.Show();
                isdebug = true;

                Thread refreshThread = new Thread(new ThreadStart(DebugRefresh));
                refreshThread.Start();
            }
            else
            {
                ErrorText.Show();
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_param.SelectedIndex >= 0)
            {
                listIndexParam = listbox_param.SelectedIndex;
            }
        }

        private void RefreshParam_Click(object sender, EventArgs e)
        {
            //Refresh Parameters
            listbox_param.DataSource = bsParams;
            bsParams.ResetBindings(true);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }

    public class AppObject
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }

        public AppObject(int Index, string Name, string IP, string Port)
        {
            this.Index = Index;
            this.Name = Name;
            this.IP = IP;
            this.Port = Port;
        }
    }
}
