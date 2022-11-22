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

namespace OSCHub
{
   
    public partial class Form1 : Form
    {
        public static List<String> AppsList = new List<String>();
        public static List<AppObject> AppsObjectList = new List<AppObject>();
        BindingSource bs = new BindingSource();
        public int listIndex = 0;
        bool isrun = false;
        public static Thread serverThread;
        public static CancellationTokenSource ct = new CancellationTokenSource();
       

        public void UpdateAvatar(String ID)
        {
            Console.WriteLine("Event called");
            

            Label_ID.BeginInvoke((MethodInvoker)delegate ()
            {
                Label_ID.Text = ID;
            });
        }

       

        public Form1()
        {



            Server.IDUpdated += UpdateAvatar;

            InitializeComponent();
            bs.DataSource = AppsList;

            //Check for a config file and load it, populating the Apps and AppsObject lists
            if(System.IO.File.Exists(Application.StartupPath + "Config.json"))
            {
                string file = System.IO.File.ReadAllText(Application.StartupPath +"Config.Json");
                //AppsObjectList = JsonSerializer.Deserialize<AppObject>(file);
                AppsObjectList = Newtonsoft.Json.JsonConvert.DeserializeObject <List<AppObject>>(file);
                for(int i = 0; i<AppsObjectList.Count;i++)
                {
                    AppsList.Add(AppsObjectList[i].Name);
                }
                lblConnectedApps.Text = "Connected Apps: " + AppsList.Count;
                lAppsBox.DataSource = bs;

                bs.ResetBindings(false); //Reset bindings to show 
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
                lAppsBox.DataSource = bs;
                
                bs.ResetBindings(false);
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
            bs.ResetBindings(false);

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

        private void LblAvatarInfo_Click(object sender, EventArgs e)
        {

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
