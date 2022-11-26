
namespace OSCHub
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnParam = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.LblAppAddress = new System.Windows.Forms.Label();
            this.LblAppName = new System.Windows.Forms.Label();
            this.LblAppPort = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lAppsBox = new System.Windows.Forms.ListBox();
            this.AppTextBox = new System.Windows.Forms.TextBox();
            this.lblConnectedApps = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.Label_SvrStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Label_ID = new System.Windows.Forms.Label();
            this.LblAvatarName = new System.Windows.Forms.Label();
            this.LblAvatarInfo = new System.Windows.Forms.Label();
            this.panel_param = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label_oscaddress = new System.Windows.Forms.Label();
            this.label_oscvalue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listbox_param = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveApp = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel_param.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnParam);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 577);
            this.panel1.TabIndex = 0;
            // 
            // btnParam
            // 
            this.btnParam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnParam.FlatAppearance.BorderSize = 0;
            this.btnParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParam.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnParam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.btnParam.Location = new System.Drawing.Point(-3, 191);
            this.btnParam.Name = "btnParam";
            this.btnParam.Size = new System.Drawing.Size(187, 32);
            this.btnParam.TabIndex = 4;
            this.btnParam.Text = "Parameter Debug";
            this.btnParam.UseVisualStyleBackColor = true;
            this.btnParam.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 346);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 231);
            this.panel3.TabIndex = 3;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 144);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(187, 42);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Home";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 144);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(60, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "OSC Hub";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label3.Location = new System.Drawing.Point(205, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "OSC Settings";
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(924, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 25);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAddApp);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtPort);
            this.panel5.Controls.Add(this.txtIP);
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.LblAppAddress);
            this.panel5.Controls.Add(this.LblAppName);
            this.panel5.Controls.Add(this.LblAppPort);
            this.panel5.Location = new System.Drawing.Point(606, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 225);
            this.panel5.TabIndex = 9;
            // 
            // btnAddApp
            // 
            this.btnAddApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.btnAddApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.btnAddApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddApp.ForeColor = System.Drawing.Color.Black;
            this.btnAddApp.Location = new System.Drawing.Point(192, 196);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(82, 27);
            this.btnAddApp.TabIndex = 13;
            this.btnAddApp.Text = "Add";
            this.btnAddApp.UseVisualStyleBackColor = false;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label7.Location = new System.Drawing.Point(150, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "New OSC App";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPort.Location = new System.Drawing.Point(150, 153);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(160, 16);
            this.txtPort.TabIndex = 10;
            this.txtPort.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP.Location = new System.Drawing.Point(150, 108);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(160, 16);
            this.txtIP.TabIndex = 9;
            this.txtIP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(150, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 16);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LblAppAddress
            // 
            this.LblAppAddress.AutoSize = true;
            this.LblAppAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAppAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.LblAppAddress.Location = new System.Drawing.Point(-2, 104);
            this.LblAppAddress.Name = "LblAppAddress";
            this.LblAppAddress.Size = new System.Drawing.Size(119, 25);
            this.LblAppAddress.TabIndex = 7;
            this.LblAppAddress.Text = "IPAddress";
            this.LblAppAddress.Click += new System.EventHandler(this.LblAppAddress_Click);
            // 
            // LblAppName
            // 
            this.LblAppName.AutoSize = true;
            this.LblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.LblAppName.Location = new System.Drawing.Point(1, 55);
            this.LblAppName.Name = "LblAppName";
            this.LblAppName.Size = new System.Drawing.Size(72, 25);
            this.LblAppName.TabIndex = 4;
            this.LblAppName.Text = "Name";
            this.LblAppName.Click += new System.EventHandler(this.LblAppName_Click);
            // 
            // LblAppPort
            // 
            this.LblAppPort.AutoSize = true;
            this.LblAppPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAppPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.LblAppPort.Location = new System.Drawing.Point(1, 145);
            this.LblAppPort.Name = "LblAppPort";
            this.LblAppPort.Size = new System.Drawing.Size(55, 25);
            this.LblAppPort.TabIndex = 6;
            this.LblAppPort.Text = "Port";
            this.LblAppPort.Click += new System.EventHandler(this.LblAppPort_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lAppsBox);
            this.panel6.Controls.Add(this.AppTextBox);
            this.panel6.Location = new System.Drawing.Point(205, 346);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 219);
            this.panel6.TabIndex = 10;
            // 
            // lAppsBox
            // 
            this.lAppsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.lAppsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lAppsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lAppsBox.FormattingEnabled = true;
            this.lAppsBox.ItemHeight = 25;
            this.lAppsBox.Location = new System.Drawing.Point(30, 0);
            this.lAppsBox.Name = "lAppsBox";
            this.lAppsBox.Size = new System.Drawing.Size(309, 204);
            this.lAppsBox.TabIndex = 1;
            this.lAppsBox.SelectedIndexChanged += new System.EventHandler(this.lAppsBox_SelectedIndexChanged);
            // 
            // AppTextBox
            // 
            this.AppTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.AppTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.AppTextBox.Location = new System.Drawing.Point(4, 4);
            this.AppTextBox.Multiline = true;
            this.AppTextBox.Name = "AppTextBox";
            this.AppTextBox.Size = new System.Drawing.Size(269, 212);
            this.AppTextBox.TabIndex = 0;
            this.AppTextBox.TextChanged += new System.EventHandler(this.AppTextBox_TextChanged);
            // 
            // lblConnectedApps
            // 
            this.lblConnectedApps.AutoSize = true;
            this.lblConnectedApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConnectedApps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblConnectedApps.Location = new System.Drawing.Point(276, 323);
            this.lblConnectedApps.Name = "lblConnectedApps";
            this.lblConnectedApps.Size = new System.Drawing.Size(142, 20);
            this.lblConnectedApps.TabIndex = 0;
            this.lblConnectedApps.Text = "Connected Apps";
            this.lblConnectedApps.Click += new System.EventHandler(this.LiveParameterLabel_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnStart.FlatAppearance.BorderSize = 4;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(782, 497);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 50);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label5.Location = new System.Drawing.Point(0, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ServerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.ServerLabel.Location = new System.Drawing.Point(0, 122);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(81, 25);
            this.ServerLabel.TabIndex = 4;
            this.ServerLabel.Text = "Server";
            // 
            // Label_SvrStatus
            // 
            this.Label_SvrStatus.AutoSize = true;
            this.Label_SvrStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_SvrStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.Label_SvrStatus.Location = new System.Drawing.Point(106, 182);
            this.Label_SvrStatus.Name = "Label_SvrStatus";
            this.Label_SvrStatus.Size = new System.Drawing.Size(55, 20);
            this.Label_SvrStatus.TabIndex = 7;
            this.Label_SvrStatus.Text = "Offline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label4.Location = new System.Drawing.Point(0, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "127.0.0.1:9000";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Label_SvrStatus);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.Label_ID);
            this.panel7.Controls.Add(this.LblAvatarName);
            this.panel7.Controls.Add(this.ServerLabel);
            this.panel7.Controls.Add(this.LblAvatarInfo);
            this.panel7.Location = new System.Drawing.Point(188, 54);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(410, 225);
            this.panel7.TabIndex = 11;
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.Label_ID.Location = new System.Drawing.Point(0, 90);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(55, 20);
            this.Label_ID.TabIndex = 8;
            this.Label_ID.Text = "Offline";
            this.Label_ID.Click += new System.EventHandler(this.label8_Click);
            // 
            // LblAvatarName
            // 
            this.LblAvatarName.AutoSize = true;
            this.LblAvatarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAvatarName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.LblAvatarName.Location = new System.Drawing.Point(0, 54);
            this.LblAvatarName.Name = "LblAvatarName";
            this.LblAvatarName.Size = new System.Drawing.Size(109, 25);
            this.LblAvatarName.TabIndex = 14;
            this.LblAvatarName.Text = "Avatar ID";
            this.LblAvatarName.Click += new System.EventHandler(this.LblAvatarName_Click);
            // 
            // LblAvatarInfo
            // 
            this.LblAvatarInfo.AutoSize = true;
            this.LblAvatarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAvatarInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.LblAvatarInfo.Location = new System.Drawing.Point(124, 6);
            this.LblAvatarInfo.Name = "LblAvatarInfo";
            this.LblAvatarInfo.Size = new System.Drawing.Size(126, 25);
            this.LblAvatarInfo.TabIndex = 14;
            this.LblAvatarInfo.Text = "Avatar Info";
            this.LblAvatarInfo.Click += new System.EventHandler(this.LblAvatarInfo_Click);
            // 
            // panel_param
            // 
            this.panel_param.Controls.Add(this.button1);
            this.panel_param.Controls.Add(this.label_oscaddress);
            this.panel_param.Controls.Add(this.label_oscvalue);
            this.panel_param.Controls.Add(this.label9);
            this.panel_param.Controls.Add(this.label8);
            this.panel_param.Controls.Add(this.label6);
            this.panel_param.Controls.Add(this.listbox_param);
            this.panel_param.Controls.Add(this.label2);
            this.panel_param.Location = new System.Drawing.Point(188, 0);
            this.panel_param.Name = "panel_param";
            this.panel_param.Size = new System.Drawing.Size(761, 568);
            this.panel_param.TabIndex = 16;
            this.panel_param.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(733, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label_oscaddress
            // 
            this.label_oscaddress.AutoSize = true;
            this.label_oscaddress.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_oscaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label_oscaddress.Location = new System.Drawing.Point(496, 100);
            this.label_oscaddress.Name = "label_oscaddress";
            this.label_oscaddress.Size = new System.Drawing.Size(56, 17);
            this.label_oscaddress.TabIndex = 6;
            this.label_oscaddress.Text = "Address";
            // 
            // label_oscvalue
            // 
            this.label_oscvalue.AutoSize = true;
            this.label_oscvalue.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_oscvalue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label_oscvalue.Location = new System.Drawing.Point(496, 157);
            this.label_oscvalue.Name = "label_oscvalue";
            this.label_oscvalue.Size = new System.Drawing.Size(39, 17);
            this.label_oscvalue.TabIndex = 5;
            this.label_oscvalue.Text = "Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label9.Location = new System.Drawing.Point(435, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Value:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label8.Location = new System.Drawing.Point(435, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label6.Location = new System.Drawing.Point(530, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Details";
            // 
            // listbox_param
            // 
            this.listbox_param.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.listbox_param.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listbox_param.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.listbox_param.FormattingEnabled = true;
            this.listbox_param.ItemHeight = 16;
            this.listbox_param.Location = new System.Drawing.Point(21, 46);
            this.listbox_param.Name = "listbox_param";
            this.listbox_param.Size = new System.Drawing.Size(392, 516);
            this.listbox_param.TabIndex = 1;
            this.listbox_param.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(88, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detected Parameters";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRemoveApp
            // 
            this.btnRemoveApp.AutoSize = true;
            this.btnRemoveApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.btnRemoveApp.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnRemoveApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveApp.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveApp.Location = new System.Drawing.Point(553, 374);
            this.btnRemoveApp.Name = "btnRemoveApp";
            this.btnRemoveApp.Size = new System.Drawing.Size(29, 32);
            this.btnRemoveApp.TabIndex = 14;
            this.btnRemoveApp.Text = "-";
            this.btnRemoveApp.UseVisualStyleBackColor = false;
            this.btnRemoveApp.Click += new System.EventHandler(this.btnRemoveApp_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(553, 515);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 32);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save Apps";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel_param);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveApp);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lblConnectedApps);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel_param.ResumeLayout(false);
            this.panel_param.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LblAppName;
        private System.Windows.Forms.Label LblAppPort;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblConnectedApps;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Label Label_SvrStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label LblAppAddress;
        private System.Windows.Forms.Button btnAddApp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label LblAvatarName;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.TextBox AppTextBox;
        private System.Windows.Forms.ListBox lAppsBox;
        private System.Windows.Forms.Button btnRemoveApp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label LblAvatarInfo;
        private System.Windows.Forms.Panel panel_param;
        private System.Windows.Forms.Button btnParam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listbox_param;
        private System.Windows.Forms.Label label_oscaddress;
        private System.Windows.Forms.Label label_oscvalue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

