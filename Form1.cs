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
using SharpOSC;

namespace OSCHub
{
   
    public partial class Form1 : Form
    {
        public static List<String> AppsList = new List<String>();
        public static List<AppObject> AppsObjectList = new List<AppObject>();
        public static List<String> ParamList = new List<String>();
        BindingSource bsApps = new BindingSource();
        public static BindingSource bsParams = new BindingSource();
        public int listIndex = 0;
        public int listIndexParam = 0;
        bool isrun = false;
        public static bool isdebug = false;
        public static Thread serverThread;
        public static CancellationTokenSource ct = new CancellationTokenSource();
        public static List<OscMessage> parameter_list = new List<OscMessage>();


        public Label Label8
        {
            get { return Label_ID; }
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



        public void UpdateUI(String op,String ID)
        {
            Console.WriteLine("Event called");


            if (op == "av_id")
            {
                Label_ID.BeginInvoke((MethodInvoker)delegate ()
                {
                    Label_ID.Text = ID;
                });
            }
            
        }

      

        public Form1()
        {



            Server.IDUpdated += UpdateUI;

            InitializeComponent();
            bsApps.DataSource = AppsList;
            bsParams.DataSource = ParamList;

            //Check for a config file and load it, populating the Apps and AppsObject lists
            if(System.IO.File.Exists(Application.StartupPath + "Config.json"))
            {
                string file = System.IO.File.ReadAllText(Application.StartupPath +"Config.Json");
                AppsObjectList = Newtonsoft.Json.JsonConvert.DeserializeObject <List<AppObject>>(file);
                for(int i = 0; i<AppsObjectList.Count;i++)
                {
                    AppsList.Add(AppsObjectList[i].Name);
                }
                lblConnectedApps.Text = "Connected Apps: " + AppsList.Count;
                lAppsBox.DataSource = bsApps;

                bsApps.ResetBindings(false); //Reset bindings to show 
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(isrun == false)
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
                
                serverThread.Start(ct);
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
            
            if(!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtIP.Text) && !String.IsNullOrEmpty(txtPort.Text))
            {
                AppObject Current = new AppObject(AppsList.Count ,txtName.Text, txtIP.Text, txtPort.Text);
                                
                AppsObjectList.Add(Current);
                AppsList.Add(Current.Name.ToString());
                lAppsBox.DataSource = bsApps;
                
                bsApps.ResetBindings(false);
                lblConnectedApps.Text = "Connected Apps: " + AppsList.Count;
                //Figure out converting objects to strings and displaying on change
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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Apps have been saved to Config.json");
           
            string jsonOut = JsonSerializer.Serialize(AppsObjectList);
            System.IO.File.WriteAllText(Application.StartupPath +"Config.json",jsonOut);
        }

        private void label8_Click(object sender, EventArgs e)
        {
          
        }
       
        private void LblAvatarInfo_Click(object sender, EventArgs e)
        {

        }

        
        //Home FIX THIS
        private void btnParamDebug_Click(object sender, EventArgs e)
        {
            panel_param.Hide();
            isdebug = false;
        }

        //Parameter Debug
        private void button2_Click(object sender, EventArgs e)
        {
            panel_param.Show();
            isdebug = true;
            
            

            //Make sure we reset the bindings
            
           
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

                //Set Address and Value to selected Parameter
                label_oscaddress.Text = parameter_list[listIndexParam].Address;
                label_oscvalue.Text = parameter_list[listIndexParam].Arguments[0].ToString();
            }
        }

        private void RefreshParam_Click(object sender, EventArgs e)
        {
            
            listbox_param.DataSource = bsParams;
            bsParams.ResetBindings(true);
        }
    }

    public class AppObject
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string IP{ get; set; } 
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
