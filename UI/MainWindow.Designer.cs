namespace UI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Panel_WindowTitle = new System.Windows.Forms.Panel();
            this.Button_Minimize = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Label_WindowTitle = new System.Windows.Forms.Label();
            this.Panel_Footer = new System.Windows.Forms.Panel();
            this.ProgressBar_Scanning = new System.Windows.Forms.ProgressBar();
            this.Label_Tip = new System.Windows.Forms.Label();
            this.Label_Time = new System.Windows.Forms.Label();
            this.Label_Footer = new System.Windows.Forms.Label();
            this.DynamicShowTime = new System.Windows.Forms.Timer(this.components);
            this.Panel_System = new System.Windows.Forms.Panel();
            this.PictureBox_Computer = new System.Windows.Forms.PictureBox();
            this.Label_DeviceName = new System.Windows.Forms.Label();
            this.Label_ProductID = new System.Windows.Forms.Label();
            this.Label_RegisterUser = new System.Windows.Forms.Label();
            this.Label_InstallPath = new System.Windows.Forms.Label();
            this.Label_SystemSource = new System.Windows.Forms.Label();
            this.Label_InstallTime = new System.Windows.Forms.Label();
            this.Label_SystemFramework = new System.Windows.Forms.Label();
            this.Label_OSVersion = new System.Windows.Forms.Label();
            this.Label_OS = new System.Windows.Forms.Label();
            this.Label_UUID = new System.Windows.Forms.Label();
            this.Label_DeviceSN = new System.Windows.Forms.Label();
            this.Label_BIOSVersion = new System.Windows.Forms.Label();
            this.Label_ComputerManufacturer = new System.Windows.Forms.Label();
            this.Label_DeviceModel = new System.Windows.Forms.Label();
            this.Label_ConfigDetail = new System.Windows.Forms.Label();
            this.Panel_CPU = new System.Windows.Forms.Panel();
            this.PictureBox_CPU = new System.Windows.Forms.PictureBox();
            this.Label_L3Cache = new System.Windows.Forms.Label();
            this.Label_L2Cache = new System.Windows.Forms.Label();
            this.Label_CPUFramework = new System.Windows.Forms.Label();
            this.Label_CPUThreadCount = new System.Windows.Forms.Label();
            this.Label_CPUCoreCount = new System.Windows.Forms.Label();
            this.Label_CPUClockSpeed = new System.Windows.Forms.Label();
            this.Label_CPUModel = new System.Windows.Forms.Label();
            this.Panel_Memory = new System.Windows.Forms.Panel();
            this.PictureBox_Memory = new System.Windows.Forms.PictureBox();
            this.Label_VirtualMemory = new System.Windows.Forms.Label();
            this.Label_MaxMemory = new System.Windows.Forms.Label();
            this.Label_AvailableMemory = new System.Windows.Forms.Label();
            this.Label_InstallMemory = new System.Windows.Forms.Label();
            this.Label_MemorySpeed = new System.Windows.Forms.Label();
            this.Label_MemoryInstallNumber = new System.Windows.Forms.Label();
            this.Label_MemoryManufacturer = new System.Windows.Forms.Label();
            this.Panel_GPU = new System.Windows.Forms.Panel();
            this.PictureBox_GPU = new System.Windows.Forms.PictureBox();
            this.Label_GPU2DriverDate = new System.Windows.Forms.Label();
            this.Label_GPU2Memory = new System.Windows.Forms.Label();
            this.Label_GPU2Model = new System.Windows.Forms.Label();
            this.Label_GPU1DriverDate = new System.Windows.Forms.Label();
            this.Label_GPU1Memory = new System.Windows.Forms.Label();
            this.Label_GPU1Model = new System.Windows.Forms.Label();
            this.Panel_Disk = new System.Windows.Forms.Panel();
            this.Label_Disk2InterfaceType = new System.Windows.Forms.Label();
            this.Label_Disk2Size = new System.Windows.Forms.Label();
            this.Label_Disk2Model = new System.Windows.Forms.Label();
            this.Label_Disk1InterfaceType = new System.Windows.Forms.Label();
            this.Label_Disk1Size = new System.Windows.Forms.Label();
            this.Label_Disk1Model = new System.Windows.Forms.Label();
            this.PictureBox_Disk = new System.Windows.Forms.PictureBox();
            this.Label_UserName = new System.Windows.Forms.Label();
            this.BackgroundWorker_GetInfo = new System.ComponentModel.BackgroundWorker();
            this.Label_InternalIP = new System.Windows.Forms.Label();
            this.Label_InternetIP = new System.Windows.Forms.Label();
            this.Label_NetState = new System.Windows.Forms.Label();
            this.Panel_WindowTitle.SuspendLayout();
            this.Panel_Footer.SuspendLayout();
            this.Panel_System.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Computer)).BeginInit();
            this.Panel_CPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_CPU)).BeginInit();
            this.Panel_Memory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Memory)).BeginInit();
            this.Panel_GPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_GPU)).BeginInit();
            this.Panel_Disk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Disk)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_WindowTitle
            // 
            this.Panel_WindowTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_WindowTitle.Controls.Add(this.Button_Minimize);
            this.Panel_WindowTitle.Controls.Add(this.Button_Close);
            this.Panel_WindowTitle.Controls.Add(this.Label_WindowTitle);
            this.Panel_WindowTitle.Location = new System.Drawing.Point(0, 0);
            this.Panel_WindowTitle.Name = "Panel_WindowTitle";
            this.Panel_WindowTitle.Size = new System.Drawing.Size(1366, 40);
            this.Panel_WindowTitle.TabIndex = 0;
            this.Panel_WindowTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_WindowTitle_MouseDown);
            this.Panel_WindowTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_WindowTitle_MouseMove);
            this.Panel_WindowTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_WindowTitle_MouseUp);
            // 
            // Button_Minimize
            // 
            this.Button_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Button_Minimize.FlatAppearance.BorderSize = 0;
            this.Button_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Button_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.Button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Minimize.Image = global::UI.Properties.Resources.Minimize;
            this.Button_Minimize.Location = new System.Drawing.Point(1286, 0);
            this.Button_Minimize.Name = "Button_Minimize";
            this.Button_Minimize.Size = new System.Drawing.Size(40, 40);
            this.Button_Minimize.TabIndex = 3;
            this.Button_Minimize.TabStop = false;
            this.Button_Minimize.UseVisualStyleBackColor = false;
            this.Button_Minimize.Click += new System.EventHandler(this.Button_Minimize_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.BackColor = System.Drawing.Color.Transparent;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.Button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Image = global::UI.Properties.Resources.close;
            this.Button_Close.Location = new System.Drawing.Point(1326, 0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(40, 40);
            this.Button_Close.TabIndex = 2;
            this.Button_Close.TabStop = false;
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Label_WindowTitle
            // 
            this.Label_WindowTitle.AutoSize = true;
            this.Label_WindowTitle.Font = new System.Drawing.Font("华文楷体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Label_WindowTitle.ForeColor = System.Drawing.Color.White;
            this.Label_WindowTitle.Location = new System.Drawing.Point(12, 7);
            this.Label_WindowTitle.Name = "Label_WindowTitle";
            this.Label_WindowTitle.Size = new System.Drawing.Size(174, 27);
            this.Label_WindowTitle.TabIndex = 1;
            this.Label_WindowTitle.Text = "PC Information";
            this.Label_WindowTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_WindowTitle_MouseDown);
            this.Label_WindowTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_WindowTitle_MouseMove);
            this.Label_WindowTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_WindowTitle_MouseUp);
            // 
            // Panel_Footer
            // 
            this.Panel_Footer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_Footer.Controls.Add(this.ProgressBar_Scanning);
            this.Panel_Footer.Controls.Add(this.Label_Tip);
            this.Panel_Footer.Controls.Add(this.Label_Time);
            this.Panel_Footer.Controls.Add(this.Label_Footer);
            this.Panel_Footer.Location = new System.Drawing.Point(0, 740);
            this.Panel_Footer.Name = "Panel_Footer";
            this.Panel_Footer.Size = new System.Drawing.Size(1366, 28);
            this.Panel_Footer.TabIndex = 1;
            // 
            // ProgressBar_Scanning
            // 
            this.ProgressBar_Scanning.Location = new System.Drawing.Point(7, 2);
            this.ProgressBar_Scanning.Name = "ProgressBar_Scanning";
            this.ProgressBar_Scanning.Size = new System.Drawing.Size(200, 23);
            this.ProgressBar_Scanning.TabIndex = 5;
            // 
            // Label_Tip
            // 
            this.Label_Tip.AutoSize = true;
            this.Label_Tip.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Tip.ForeColor = System.Drawing.Color.White;
            this.Label_Tip.Location = new System.Drawing.Point(213, 7);
            this.Label_Tip.Name = "Label_Tip";
            this.Label_Tip.Size = new System.Drawing.Size(87, 16);
            this.Label_Tip.TabIndex = 4;
            this.Label_Tip.Text = "正在扫描：";
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Time.ForeColor = System.Drawing.Color.White;
            this.Label_Time.Location = new System.Drawing.Point(1215, 7);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(87, 16);
            this.Label_Time.TabIndex = 3;
            this.Label_Time.Text = "当前时间：";
            // 
            // Label_Footer
            // 
            this.Label_Footer.AutoSize = true;
            this.Label_Footer.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Footer.ForeColor = System.Drawing.Color.White;
            this.Label_Footer.Location = new System.Drawing.Point(549, 4);
            this.Label_Footer.Name = "Label_Footer";
            this.Label_Footer.Size = new System.Drawing.Size(269, 20);
            this.Label_Footer.TabIndex = 2;
            this.Label_Footer.Text = "软件仅供学习交流，切勿乱传";
            // 
            // DynamicShowTime
            // 
            this.DynamicShowTime.Interval = 1000;
            this.DynamicShowTime.Tick += new System.EventHandler(this.DynamicShowTime_Tick);
            // 
            // Panel_System
            // 
            this.Panel_System.BackColor = System.Drawing.Color.SpringGreen;
            this.Panel_System.Controls.Add(this.PictureBox_Computer);
            this.Panel_System.Controls.Add(this.Label_DeviceName);
            this.Panel_System.Controls.Add(this.Label_ProductID);
            this.Panel_System.Controls.Add(this.Label_RegisterUser);
            this.Panel_System.Controls.Add(this.Label_InstallPath);
            this.Panel_System.Controls.Add(this.Label_SystemSource);
            this.Panel_System.Controls.Add(this.Label_InstallTime);
            this.Panel_System.Controls.Add(this.Label_SystemFramework);
            this.Panel_System.Controls.Add(this.Label_OSVersion);
            this.Panel_System.Controls.Add(this.Label_OS);
            this.Panel_System.Controls.Add(this.Label_UUID);
            this.Panel_System.Controls.Add(this.Label_DeviceSN);
            this.Panel_System.Controls.Add(this.Label_BIOSVersion);
            this.Panel_System.Controls.Add(this.Label_ComputerManufacturer);
            this.Panel_System.Controls.Add(this.Label_DeviceModel);
            this.Panel_System.Location = new System.Drawing.Point(7, 80);
            this.Panel_System.Name = "Panel_System";
            this.Panel_System.Size = new System.Drawing.Size(450, 630);
            this.Panel_System.TabIndex = 2;
            // 
            // PictureBox_Computer
            // 
            this.PictureBox_Computer.Image = global::UI.Properties.Resources.laptop;
            this.PictureBox_Computer.Location = new System.Drawing.Point(330, 510);
            this.PictureBox_Computer.Name = "PictureBox_Computer";
            this.PictureBox_Computer.Size = new System.Drawing.Size(120, 120);
            this.PictureBox_Computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Computer.TabIndex = 14;
            this.PictureBox_Computer.TabStop = false;
            // 
            // Label_DeviceName
            // 
            this.Label_DeviceName.AutoSize = true;
            this.Label_DeviceName.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_DeviceName.ForeColor = System.Drawing.Color.White;
            this.Label_DeviceName.Location = new System.Drawing.Point(15, 600);
            this.Label_DeviceName.Name = "Label_DeviceName";
            this.Label_DeviceName.Size = new System.Drawing.Size(92, 16);
            this.Label_DeviceName.TabIndex = 13;
            this.Label_DeviceName.Text = "设备名称：";
            // 
            // Label_ProductID
            // 
            this.Label_ProductID.AutoSize = true;
            this.Label_ProductID.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_ProductID.ForeColor = System.Drawing.Color.White;
            this.Label_ProductID.Location = new System.Drawing.Point(31, 555);
            this.Label_ProductID.Name = "Label_ProductID";
            this.Label_ProductID.Size = new System.Drawing.Size(76, 16);
            this.Label_ProductID.TabIndex = 12;
            this.Label_ProductID.Text = "产品ID：";
            // 
            // Label_RegisterUser
            // 
            this.Label_RegisterUser.AutoSize = true;
            this.Label_RegisterUser.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_RegisterUser.ForeColor = System.Drawing.Color.White;
            this.Label_RegisterUser.Location = new System.Drawing.Point(15, 510);
            this.Label_RegisterUser.Name = "Label_RegisterUser";
            this.Label_RegisterUser.Size = new System.Drawing.Size(92, 16);
            this.Label_RegisterUser.TabIndex = 11;
            this.Label_RegisterUser.Text = "注册用户：";
            // 
            // Label_InstallPath
            // 
            this.Label_InstallPath.AutoSize = true;
            this.Label_InstallPath.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_InstallPath.ForeColor = System.Drawing.Color.White;
            this.Label_InstallPath.Location = new System.Drawing.Point(15, 465);
            this.Label_InstallPath.Name = "Label_InstallPath";
            this.Label_InstallPath.Size = new System.Drawing.Size(92, 16);
            this.Label_InstallPath.TabIndex = 10;
            this.Label_InstallPath.Text = "安装路径：";
            // 
            // Label_SystemSource
            // 
            this.Label_SystemSource.AutoSize = true;
            this.Label_SystemSource.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_SystemSource.ForeColor = System.Drawing.Color.White;
            this.Label_SystemSource.Location = new System.Drawing.Point(15, 420);
            this.Label_SystemSource.Name = "Label_SystemSource";
            this.Label_SystemSource.Size = new System.Drawing.Size(92, 16);
            this.Label_SystemSource.TabIndex = 9;
            this.Label_SystemSource.Text = "系统来源：";
            // 
            // Label_InstallTime
            // 
            this.Label_InstallTime.AutoSize = true;
            this.Label_InstallTime.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_InstallTime.ForeColor = System.Drawing.Color.White;
            this.Label_InstallTime.Location = new System.Drawing.Point(15, 375);
            this.Label_InstallTime.Name = "Label_InstallTime";
            this.Label_InstallTime.Size = new System.Drawing.Size(92, 16);
            this.Label_InstallTime.TabIndex = 8;
            this.Label_InstallTime.Text = "安装时间：";
            // 
            // Label_SystemFramework
            // 
            this.Label_SystemFramework.AutoSize = true;
            this.Label_SystemFramework.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_SystemFramework.ForeColor = System.Drawing.Color.White;
            this.Label_SystemFramework.Location = new System.Drawing.Point(15, 330);
            this.Label_SystemFramework.Name = "Label_SystemFramework";
            this.Label_SystemFramework.Size = new System.Drawing.Size(92, 16);
            this.Label_SystemFramework.TabIndex = 7;
            this.Label_SystemFramework.Text = "系统架构：";
            // 
            // Label_OSVersion
            // 
            this.Label_OSVersion.AutoSize = true;
            this.Label_OSVersion.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_OSVersion.ForeColor = System.Drawing.Color.White;
            this.Label_OSVersion.Location = new System.Drawing.Point(32, 285);
            this.Label_OSVersion.Name = "Label_OSVersion";
            this.Label_OSVersion.Size = new System.Drawing.Size(75, 16);
            this.Label_OSVersion.TabIndex = 6;
            this.Label_OSVersion.Text = "版本号：";
            // 
            // Label_OS
            // 
            this.Label_OS.AutoSize = true;
            this.Label_OS.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_OS.ForeColor = System.Drawing.Color.White;
            this.Label_OS.Location = new System.Drawing.Point(15, 240);
            this.Label_OS.Name = "Label_OS";
            this.Label_OS.Size = new System.Drawing.Size(92, 16);
            this.Label_OS.TabIndex = 5;
            this.Label_OS.Text = "操作系统：";
            // 
            // Label_UUID
            // 
            this.Label_UUID.AutoSize = true;
            this.Label_UUID.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_UUID.ForeColor = System.Drawing.Color.White;
            this.Label_UUID.Location = new System.Drawing.Point(47, 195);
            this.Label_UUID.Name = "Label_UUID";
            this.Label_UUID.Size = new System.Drawing.Size(60, 16);
            this.Label_UUID.TabIndex = 4;
            this.Label_UUID.Text = "UUID：";
            // 
            // Label_DeviceSN
            // 
            this.Label_DeviceSN.AutoSize = true;
            this.Label_DeviceSN.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_DeviceSN.ForeColor = System.Drawing.Color.White;
            this.Label_DeviceSN.Location = new System.Drawing.Point(31, 150);
            this.Label_DeviceSN.Name = "Label_DeviceSN";
            this.Label_DeviceSN.Size = new System.Drawing.Size(76, 16);
            this.Label_DeviceSN.TabIndex = 3;
            this.Label_DeviceSN.Text = "设备SN：";
            // 
            // Label_BIOSVersion
            // 
            this.Label_BIOSVersion.AutoSize = true;
            this.Label_BIOSVersion.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_BIOSVersion.ForeColor = System.Drawing.Color.White;
            this.Label_BIOSVersion.Location = new System.Drawing.Point(13, 105);
            this.Label_BIOSVersion.Name = "Label_BIOSVersion";
            this.Label_BIOSVersion.Size = new System.Drawing.Size(94, 16);
            this.Label_BIOSVersion.TabIndex = 2;
            this.Label_BIOSVersion.Text = "BIOS版本：";
            // 
            // Label_ComputerManufacturer
            // 
            this.Label_ComputerManufacturer.AutoSize = true;
            this.Label_ComputerManufacturer.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_ComputerManufacturer.ForeColor = System.Drawing.Color.White;
            this.Label_ComputerManufacturer.Location = new System.Drawing.Point(32, 60);
            this.Label_ComputerManufacturer.Name = "Label_ComputerManufacturer";
            this.Label_ComputerManufacturer.Size = new System.Drawing.Size(75, 16);
            this.Label_ComputerManufacturer.TabIndex = 1;
            this.Label_ComputerManufacturer.Text = "制造商：";
            // 
            // Label_DeviceModel
            // 
            this.Label_DeviceModel.AutoSize = true;
            this.Label_DeviceModel.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_DeviceModel.ForeColor = System.Drawing.Color.White;
            this.Label_DeviceModel.Location = new System.Drawing.Point(15, 15);
            this.Label_DeviceModel.Name = "Label_DeviceModel";
            this.Label_DeviceModel.Size = new System.Drawing.Size(92, 16);
            this.Label_DeviceModel.TabIndex = 0;
            this.Label_DeviceModel.Text = "设备型号：";
            // 
            // Label_ConfigDetail
            // 
            this.Label_ConfigDetail.AutoSize = true;
            this.Label_ConfigDetail.Enabled = false;
            this.Label_ConfigDetail.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_ConfigDetail.Location = new System.Drawing.Point(632, 50);
            this.Label_ConfigDetail.Name = "Label_ConfigDetail";
            this.Label_ConfigDetail.Size = new System.Drawing.Size(102, 21);
            this.Label_ConfigDetail.TabIndex = 3;
            this.Label_ConfigDetail.Text = "配置详情";
            this.Label_ConfigDetail.Click += new System.EventHandler(this.Label_ConfigDetail_Click);
            // 
            // Panel_CPU
            // 
            this.Panel_CPU.BackColor = System.Drawing.Color.Gold;
            this.Panel_CPU.Controls.Add(this.PictureBox_CPU);
            this.Panel_CPU.Controls.Add(this.Label_L3Cache);
            this.Panel_CPU.Controls.Add(this.Label_L2Cache);
            this.Panel_CPU.Controls.Add(this.Label_CPUFramework);
            this.Panel_CPU.Controls.Add(this.Label_CPUThreadCount);
            this.Panel_CPU.Controls.Add(this.Label_CPUCoreCount);
            this.Panel_CPU.Controls.Add(this.Label_CPUClockSpeed);
            this.Panel_CPU.Controls.Add(this.Label_CPUModel);
            this.Panel_CPU.Location = new System.Drawing.Point(466, 80);
            this.Panel_CPU.Name = "Panel_CPU";
            this.Panel_CPU.Size = new System.Drawing.Size(445, 310);
            this.Panel_CPU.TabIndex = 4;
            // 
            // PictureBox_CPU
            // 
            this.PictureBox_CPU.Image = global::UI.Properties.Resources.cpu;
            this.PictureBox_CPU.Location = new System.Drawing.Point(325, 190);
            this.PictureBox_CPU.Name = "PictureBox_CPU";
            this.PictureBox_CPU.Size = new System.Drawing.Size(120, 120);
            this.PictureBox_CPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_CPU.TabIndex = 15;
            this.PictureBox_CPU.TabStop = false;
            // 
            // Label_L3Cache
            // 
            this.Label_L3Cache.AutoSize = true;
            this.Label_L3Cache.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_L3Cache.ForeColor = System.Drawing.Color.White;
            this.Label_L3Cache.Location = new System.Drawing.Point(21, 285);
            this.Label_L3Cache.Name = "Label_L3Cache";
            this.Label_L3Cache.Size = new System.Drawing.Size(76, 16);
            this.Label_L3Cache.TabIndex = 13;
            this.Label_L3Cache.Text = "L3缓存：";
            // 
            // Label_L2Cache
            // 
            this.Label_L2Cache.AutoSize = true;
            this.Label_L2Cache.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_L2Cache.ForeColor = System.Drawing.Color.White;
            this.Label_L2Cache.Location = new System.Drawing.Point(21, 240);
            this.Label_L2Cache.Name = "Label_L2Cache";
            this.Label_L2Cache.Size = new System.Drawing.Size(76, 16);
            this.Label_L2Cache.TabIndex = 12;
            this.Label_L2Cache.Text = "L2缓存：";
            // 
            // Label_CPUFramework
            // 
            this.Label_CPUFramework.AutoSize = true;
            this.Label_CPUFramework.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_CPUFramework.ForeColor = System.Drawing.Color.White;
            this.Label_CPUFramework.Location = new System.Drawing.Point(12, 195);
            this.Label_CPUFramework.Name = "Label_CPUFramework";
            this.Label_CPUFramework.Size = new System.Drawing.Size(85, 16);
            this.Label_CPUFramework.TabIndex = 11;
            this.Label_CPUFramework.Text = "CPU架构：";
            // 
            // Label_CPUThreadCount
            // 
            this.Label_CPUThreadCount.AutoSize = true;
            this.Label_CPUThreadCount.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_CPUThreadCount.ForeColor = System.Drawing.Color.White;
            this.Label_CPUThreadCount.Location = new System.Drawing.Point(12, 150);
            this.Label_CPUThreadCount.Name = "Label_CPUThreadCount";
            this.Label_CPUThreadCount.Size = new System.Drawing.Size(85, 16);
            this.Label_CPUThreadCount.TabIndex = 10;
            this.Label_CPUThreadCount.Text = "CPU线程：";
            // 
            // Label_CPUCoreCount
            // 
            this.Label_CPUCoreCount.AutoSize = true;
            this.Label_CPUCoreCount.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_CPUCoreCount.ForeColor = System.Drawing.Color.White;
            this.Label_CPUCoreCount.Location = new System.Drawing.Point(12, 105);
            this.Label_CPUCoreCount.Name = "Label_CPUCoreCount";
            this.Label_CPUCoreCount.Size = new System.Drawing.Size(85, 16);
            this.Label_CPUCoreCount.TabIndex = 9;
            this.Label_CPUCoreCount.Text = "CPU内核：";
            // 
            // Label_CPUClockSpeed
            // 
            this.Label_CPUClockSpeed.AutoSize = true;
            this.Label_CPUClockSpeed.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_CPUClockSpeed.ForeColor = System.Drawing.Color.White;
            this.Label_CPUClockSpeed.Location = new System.Drawing.Point(12, 60);
            this.Label_CPUClockSpeed.Name = "Label_CPUClockSpeed";
            this.Label_CPUClockSpeed.Size = new System.Drawing.Size(85, 16);
            this.Label_CPUClockSpeed.TabIndex = 8;
            this.Label_CPUClockSpeed.Text = "CPU主频：";
            // 
            // Label_CPUModel
            // 
            this.Label_CPUModel.AutoSize = true;
            this.Label_CPUModel.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_CPUModel.ForeColor = System.Drawing.Color.White;
            this.Label_CPUModel.Location = new System.Drawing.Point(12, 15);
            this.Label_CPUModel.Name = "Label_CPUModel";
            this.Label_CPUModel.Size = new System.Drawing.Size(85, 16);
            this.Label_CPUModel.TabIndex = 7;
            this.Label_CPUModel.Text = "CPU型号：";
            // 
            // Panel_Memory
            // 
            this.Panel_Memory.BackColor = System.Drawing.Color.DarkOrange;
            this.Panel_Memory.Controls.Add(this.PictureBox_Memory);
            this.Panel_Memory.Controls.Add(this.Label_VirtualMemory);
            this.Panel_Memory.Controls.Add(this.Label_MaxMemory);
            this.Panel_Memory.Controls.Add(this.Label_AvailableMemory);
            this.Panel_Memory.Controls.Add(this.Label_InstallMemory);
            this.Panel_Memory.Controls.Add(this.Label_MemorySpeed);
            this.Panel_Memory.Controls.Add(this.Label_MemoryInstallNumber);
            this.Panel_Memory.Controls.Add(this.Label_MemoryManufacturer);
            this.Panel_Memory.Location = new System.Drawing.Point(466, 400);
            this.Panel_Memory.Name = "Panel_Memory";
            this.Panel_Memory.Size = new System.Drawing.Size(445, 310);
            this.Panel_Memory.TabIndex = 5;
            // 
            // PictureBox_Memory
            // 
            this.PictureBox_Memory.Image = global::UI.Properties.Resources.memory;
            this.PictureBox_Memory.Location = new System.Drawing.Point(325, 190);
            this.PictureBox_Memory.Name = "PictureBox_Memory";
            this.PictureBox_Memory.Size = new System.Drawing.Size(120, 120);
            this.PictureBox_Memory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Memory.TabIndex = 23;
            this.PictureBox_Memory.TabStop = false;
            // 
            // Label_VirtualMemory
            // 
            this.Label_VirtualMemory.AutoSize = true;
            this.Label_VirtualMemory.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_VirtualMemory.ForeColor = System.Drawing.Color.White;
            this.Label_VirtualMemory.Location = new System.Drawing.Point(10, 280);
            this.Label_VirtualMemory.Name = "Label_VirtualMemory";
            this.Label_VirtualMemory.Size = new System.Drawing.Size(92, 16);
            this.Label_VirtualMemory.TabIndex = 22;
            this.Label_VirtualMemory.Text = "虚拟内存：";
            this.Label_VirtualMemory.Visible = false;
            // 
            // Label_MaxMemory
            // 
            this.Label_MaxMemory.AutoSize = true;
            this.Label_MaxMemory.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_MaxMemory.ForeColor = System.Drawing.Color.White;
            this.Label_MaxMemory.Location = new System.Drawing.Point(10, 145);
            this.Label_MaxMemory.Name = "Label_MaxMemory";
            this.Label_MaxMemory.Size = new System.Drawing.Size(92, 16);
            this.Label_MaxMemory.TabIndex = 21;
            this.Label_MaxMemory.Text = "最大内存：";
            // 
            // Label_AvailableMemory
            // 
            this.Label_AvailableMemory.AutoSize = true;
            this.Label_AvailableMemory.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_AvailableMemory.ForeColor = System.Drawing.Color.White;
            this.Label_AvailableMemory.Location = new System.Drawing.Point(10, 235);
            this.Label_AvailableMemory.Name = "Label_AvailableMemory";
            this.Label_AvailableMemory.Size = new System.Drawing.Size(92, 16);
            this.Label_AvailableMemory.TabIndex = 20;
            this.Label_AvailableMemory.Text = "可用内存：";
            // 
            // Label_InstallMemory
            // 
            this.Label_InstallMemory.AutoSize = true;
            this.Label_InstallMemory.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_InstallMemory.ForeColor = System.Drawing.Color.White;
            this.Label_InstallMemory.Location = new System.Drawing.Point(10, 190);
            this.Label_InstallMemory.Name = "Label_InstallMemory";
            this.Label_InstallMemory.Size = new System.Drawing.Size(92, 16);
            this.Label_InstallMemory.TabIndex = 19;
            this.Label_InstallMemory.Text = "安装内存：";
            // 
            // Label_MemorySpeed
            // 
            this.Label_MemorySpeed.AutoSize = true;
            this.Label_MemorySpeed.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_MemorySpeed.ForeColor = System.Drawing.Color.White;
            this.Label_MemorySpeed.Location = new System.Drawing.Point(10, 100);
            this.Label_MemorySpeed.Name = "Label_MemorySpeed";
            this.Label_MemorySpeed.Size = new System.Drawing.Size(92, 16);
            this.Label_MemorySpeed.TabIndex = 18;
            this.Label_MemorySpeed.Text = "内存速度：";
            // 
            // Label_MemoryInstallNumber
            // 
            this.Label_MemoryInstallNumber.AutoSize = true;
            this.Label_MemoryInstallNumber.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_MemoryInstallNumber.ForeColor = System.Drawing.Color.White;
            this.Label_MemoryInstallNumber.Location = new System.Drawing.Point(10, 55);
            this.Label_MemoryInstallNumber.Name = "Label_MemoryInstallNumber";
            this.Label_MemoryInstallNumber.Size = new System.Drawing.Size(92, 16);
            this.Label_MemoryInstallNumber.TabIndex = 17;
            this.Label_MemoryInstallNumber.Text = "安装数量：";
            // 
            // Label_MemoryManufacturer
            // 
            this.Label_MemoryManufacturer.AutoSize = true;
            this.Label_MemoryManufacturer.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_MemoryManufacturer.ForeColor = System.Drawing.Color.White;
            this.Label_MemoryManufacturer.Location = new System.Drawing.Point(27, 10);
            this.Label_MemoryManufacturer.Name = "Label_MemoryManufacturer";
            this.Label_MemoryManufacturer.Size = new System.Drawing.Size(75, 16);
            this.Label_MemoryManufacturer.TabIndex = 16;
            this.Label_MemoryManufacturer.Text = "制造商：";
            // 
            // Panel_GPU
            // 
            this.Panel_GPU.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Panel_GPU.Controls.Add(this.PictureBox_GPU);
            this.Panel_GPU.Controls.Add(this.Label_GPU2DriverDate);
            this.Panel_GPU.Controls.Add(this.Label_GPU2Memory);
            this.Panel_GPU.Controls.Add(this.Label_GPU2Model);
            this.Panel_GPU.Controls.Add(this.Label_GPU1DriverDate);
            this.Panel_GPU.Controls.Add(this.Label_GPU1Memory);
            this.Panel_GPU.Controls.Add(this.Label_GPU1Model);
            this.Panel_GPU.Location = new System.Drawing.Point(915, 80);
            this.Panel_GPU.Name = "Panel_GPU";
            this.Panel_GPU.Size = new System.Drawing.Size(445, 310);
            this.Panel_GPU.TabIndex = 6;
            // 
            // PictureBox_GPU
            // 
            this.PictureBox_GPU.Image = global::UI.Properties.Resources.gpu;
            this.PictureBox_GPU.Location = new System.Drawing.Point(325, 190);
            this.PictureBox_GPU.Name = "PictureBox_GPU";
            this.PictureBox_GPU.Size = new System.Drawing.Size(120, 120);
            this.PictureBox_GPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_GPU.TabIndex = 16;
            this.PictureBox_GPU.TabStop = false;
            // 
            // Label_GPU2DriverDate
            // 
            this.Label_GPU2DriverDate.AutoSize = true;
            this.Label_GPU2DriverDate.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_GPU2DriverDate.ForeColor = System.Drawing.Color.White;
            this.Label_GPU2DriverDate.Location = new System.Drawing.Point(12, 285);
            this.Label_GPU2DriverDate.Name = "Label_GPU2DriverDate";
            this.Label_GPU2DriverDate.Size = new System.Drawing.Size(92, 16);
            this.Label_GPU2DriverDate.TabIndex = 15;
            this.Label_GPU2DriverDate.Text = "驱动日期：";
            this.Label_GPU2DriverDate.Visible = false;
            // 
            // Label_GPU2Memory
            // 
            this.Label_GPU2Memory.AutoSize = true;
            this.Label_GPU2Memory.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_GPU2Memory.ForeColor = System.Drawing.Color.White;
            this.Label_GPU2Memory.Location = new System.Drawing.Point(19, 231);
            this.Label_GPU2Memory.Name = "Label_GPU2Memory";
            this.Label_GPU2Memory.Size = new System.Drawing.Size(85, 16);
            this.Label_GPU2Memory.TabIndex = 14;
            this.Label_GPU2Memory.Text = "GPU显存：";
            this.Label_GPU2Memory.Visible = false;
            // 
            // Label_GPU2Model
            // 
            this.Label_GPU2Model.AutoSize = true;
            this.Label_GPU2Model.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_GPU2Model.ForeColor = System.Drawing.Color.White;
            this.Label_GPU2Model.Location = new System.Drawing.Point(19, 177);
            this.Label_GPU2Model.Name = "Label_GPU2Model";
            this.Label_GPU2Model.Size = new System.Drawing.Size(85, 16);
            this.Label_GPU2Model.TabIndex = 13;
            this.Label_GPU2Model.Text = "GPU型号：";
            this.Label_GPU2Model.Visible = false;
            // 
            // Label_GPU1DriverDate
            // 
            this.Label_GPU1DriverDate.AutoSize = true;
            this.Label_GPU1DriverDate.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_GPU1DriverDate.ForeColor = System.Drawing.Color.White;
            this.Label_GPU1DriverDate.Location = new System.Drawing.Point(12, 123);
            this.Label_GPU1DriverDate.Name = "Label_GPU1DriverDate";
            this.Label_GPU1DriverDate.Size = new System.Drawing.Size(92, 16);
            this.Label_GPU1DriverDate.TabIndex = 12;
            this.Label_GPU1DriverDate.Text = "驱动日期：";
            // 
            // Label_GPU1Memory
            // 
            this.Label_GPU1Memory.AutoSize = true;
            this.Label_GPU1Memory.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_GPU1Memory.ForeColor = System.Drawing.Color.White;
            this.Label_GPU1Memory.Location = new System.Drawing.Point(19, 69);
            this.Label_GPU1Memory.Name = "Label_GPU1Memory";
            this.Label_GPU1Memory.Size = new System.Drawing.Size(85, 16);
            this.Label_GPU1Memory.TabIndex = 11;
            this.Label_GPU1Memory.Text = "GPU显存：";
            // 
            // Label_GPU1Model
            // 
            this.Label_GPU1Model.AutoSize = true;
            this.Label_GPU1Model.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_GPU1Model.ForeColor = System.Drawing.Color.White;
            this.Label_GPU1Model.Location = new System.Drawing.Point(19, 15);
            this.Label_GPU1Model.Name = "Label_GPU1Model";
            this.Label_GPU1Model.Size = new System.Drawing.Size(85, 16);
            this.Label_GPU1Model.TabIndex = 10;
            this.Label_GPU1Model.Text = "GPU型号：";
            // 
            // Panel_Disk
            // 
            this.Panel_Disk.BackColor = System.Drawing.Color.Fuchsia;
            this.Panel_Disk.Controls.Add(this.Label_Disk2InterfaceType);
            this.Panel_Disk.Controls.Add(this.Label_Disk2Size);
            this.Panel_Disk.Controls.Add(this.Label_Disk2Model);
            this.Panel_Disk.Controls.Add(this.Label_Disk1InterfaceType);
            this.Panel_Disk.Controls.Add(this.Label_Disk1Size);
            this.Panel_Disk.Controls.Add(this.Label_Disk1Model);
            this.Panel_Disk.Controls.Add(this.PictureBox_Disk);
            this.Panel_Disk.Location = new System.Drawing.Point(915, 400);
            this.Panel_Disk.Name = "Panel_Disk";
            this.Panel_Disk.Size = new System.Drawing.Size(445, 310);
            this.Panel_Disk.TabIndex = 7;
            // 
            // Label_Disk2InterfaceType
            // 
            this.Label_Disk2InterfaceType.AutoSize = true;
            this.Label_Disk2InterfaceType.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Disk2InterfaceType.ForeColor = System.Drawing.Color.White;
            this.Label_Disk2InterfaceType.Location = new System.Drawing.Point(12, 282);
            this.Label_Disk2InterfaceType.Name = "Label_Disk2InterfaceType";
            this.Label_Disk2InterfaceType.Size = new System.Drawing.Size(92, 16);
            this.Label_Disk2InterfaceType.TabIndex = 23;
            this.Label_Disk2InterfaceType.Text = "接口类型：";
            this.Label_Disk2InterfaceType.Visible = false;
            // 
            // Label_Disk2Size
            // 
            this.Label_Disk2Size.AutoSize = true;
            this.Label_Disk2Size.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Disk2Size.ForeColor = System.Drawing.Color.White;
            this.Label_Disk2Size.Location = new System.Drawing.Point(12, 228);
            this.Label_Disk2Size.Name = "Label_Disk2Size";
            this.Label_Disk2Size.Size = new System.Drawing.Size(92, 16);
            this.Label_Disk2Size.TabIndex = 22;
            this.Label_Disk2Size.Text = "硬盘大小：";
            this.Label_Disk2Size.Visible = false;
            // 
            // Label_Disk2Model
            // 
            this.Label_Disk2Model.AutoSize = true;
            this.Label_Disk2Model.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Disk2Model.ForeColor = System.Drawing.Color.White;
            this.Label_Disk2Model.Location = new System.Drawing.Point(12, 174);
            this.Label_Disk2Model.Name = "Label_Disk2Model";
            this.Label_Disk2Model.Size = new System.Drawing.Size(92, 16);
            this.Label_Disk2Model.TabIndex = 21;
            this.Label_Disk2Model.Text = "硬盘型号：";
            this.Label_Disk2Model.Visible = false;
            // 
            // Label_Disk1InterfaceType
            // 
            this.Label_Disk1InterfaceType.AutoSize = true;
            this.Label_Disk1InterfaceType.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Disk1InterfaceType.ForeColor = System.Drawing.Color.White;
            this.Label_Disk1InterfaceType.Location = new System.Drawing.Point(12, 120);
            this.Label_Disk1InterfaceType.Name = "Label_Disk1InterfaceType";
            this.Label_Disk1InterfaceType.Size = new System.Drawing.Size(92, 16);
            this.Label_Disk1InterfaceType.TabIndex = 20;
            this.Label_Disk1InterfaceType.Text = "接口类型：";
            // 
            // Label_Disk1Size
            // 
            this.Label_Disk1Size.AutoSize = true;
            this.Label_Disk1Size.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Disk1Size.ForeColor = System.Drawing.Color.White;
            this.Label_Disk1Size.Location = new System.Drawing.Point(12, 66);
            this.Label_Disk1Size.Name = "Label_Disk1Size";
            this.Label_Disk1Size.Size = new System.Drawing.Size(92, 16);
            this.Label_Disk1Size.TabIndex = 19;
            this.Label_Disk1Size.Text = "硬盘大小：";
            // 
            // Label_Disk1Model
            // 
            this.Label_Disk1Model.AutoSize = true;
            this.Label_Disk1Model.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Disk1Model.ForeColor = System.Drawing.Color.White;
            this.Label_Disk1Model.Location = new System.Drawing.Point(12, 12);
            this.Label_Disk1Model.Name = "Label_Disk1Model";
            this.Label_Disk1Model.Size = new System.Drawing.Size(92, 16);
            this.Label_Disk1Model.TabIndex = 18;
            this.Label_Disk1Model.Text = "硬盘型号：";
            // 
            // PictureBox_Disk
            // 
            this.PictureBox_Disk.Image = global::UI.Properties.Resources.disk;
            this.PictureBox_Disk.Location = new System.Drawing.Point(325, 190);
            this.PictureBox_Disk.Name = "PictureBox_Disk";
            this.PictureBox_Disk.Size = new System.Drawing.Size(120, 120);
            this.PictureBox_Disk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Disk.TabIndex = 17;
            this.PictureBox_Disk.TabStop = false;
            // 
            // Label_UserName
            // 
            this.Label_UserName.AutoSize = true;
            this.Label_UserName.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_UserName.ForeColor = System.Drawing.Color.Fuchsia;
            this.Label_UserName.Location = new System.Drawing.Point(12, 50);
            this.Label_UserName.Name = "Label_UserName";
            this.Label_UserName.Size = new System.Drawing.Size(72, 20);
            this.Label_UserName.TabIndex = 8;
            this.Label_UserName.Text = "你好！";
            // 
            // BackgroundWorker_GetInfo
            // 
            this.BackgroundWorker_GetInfo.WorkerReportsProgress = true;
            this.BackgroundWorker_GetInfo.WorkerSupportsCancellation = true;
            this.BackgroundWorker_GetInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_GetInfo_DoWork);
            this.BackgroundWorker_GetInfo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_GetInfo_ProgressChanged);
            this.BackgroundWorker_GetInfo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_GetInfo_RunWorkerCompleted);
            // 
            // Label_InternalIP
            // 
            this.Label_InternalIP.AutoSize = true;
            this.Label_InternalIP.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_InternalIP.ForeColor = System.Drawing.Color.Blue;
            this.Label_InternalIP.Location = new System.Drawing.Point(12, 717);
            this.Label_InternalIP.Name = "Label_InternalIP";
            this.Label_InternalIP.Size = new System.Drawing.Size(76, 16);
            this.Label_InternalIP.TabIndex = 9;
            this.Label_InternalIP.Text = "内网IP：";
            // 
            // Label_InternetIP
            // 
            this.Label_InternetIP.AutoSize = true;
            this.Label_InternetIP.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_InternetIP.ForeColor = System.Drawing.Color.Blue;
            this.Label_InternetIP.Location = new System.Drawing.Point(1150, 717);
            this.Label_InternetIP.Name = "Label_InternetIP";
            this.Label_InternetIP.Size = new System.Drawing.Size(76, 16);
            this.Label_InternetIP.TabIndex = 10;
            this.Label_InternetIP.Text = "外网IP：";
            // 
            // Label_NetState
            // 
            this.Label_NetState.AutoSize = true;
            this.Label_NetState.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_NetState.ForeColor = System.Drawing.Color.Blue;
            this.Label_NetState.Location = new System.Drawing.Point(600, 717);
            this.Label_NetState.Name = "Label_NetState";
            this.Label_NetState.Size = new System.Drawing.Size(92, 16);
            this.Label_NetState.TabIndex = 11;
            this.Label_NetState.Text = "当前网络：";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.Label_NetState);
            this.Controls.Add(this.Label_InternetIP);
            this.Controls.Add(this.Label_InternalIP);
            this.Controls.Add(this.Label_UserName);
            this.Controls.Add(this.Panel_Disk);
            this.Controls.Add(this.Panel_GPU);
            this.Controls.Add(this.Panel_Memory);
            this.Controls.Add(this.Panel_CPU);
            this.Controls.Add(this.Label_ConfigDetail);
            this.Controls.Add(this.Panel_System);
            this.Controls.Add(this.Panel_Footer);
            this.Controls.Add(this.Panel_WindowTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Panel_WindowTitle.ResumeLayout(false);
            this.Panel_WindowTitle.PerformLayout();
            this.Panel_Footer.ResumeLayout(false);
            this.Panel_Footer.PerformLayout();
            this.Panel_System.ResumeLayout(false);
            this.Panel_System.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Computer)).EndInit();
            this.Panel_CPU.ResumeLayout(false);
            this.Panel_CPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_CPU)).EndInit();
            this.Panel_Memory.ResumeLayout(false);
            this.Panel_Memory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Memory)).EndInit();
            this.Panel_GPU.ResumeLayout(false);
            this.Panel_GPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_GPU)).EndInit();
            this.Panel_Disk.ResumeLayout(false);
            this.Panel_Disk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Disk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Panel_WindowTitle;
        private Label Label_WindowTitle;
        private Panel Panel_Footer;
        private Label Label_Time;
        private Label Label_Footer;
        private Button Button_Close;
        private Button Button_Minimize;
        private System.Windows.Forms.Timer DynamicShowTime;
        private Panel Panel_System;
        private Label Label_ConfigDetail;
        private PictureBox PictureBox_Computer;
        private Label Label_DeviceName;
        private Label Label_ProductID;
        private Label Label_RegisterUser;
        private Label Label_InstallPath;
        private Label Label_SystemSource;
        private Label Label_InstallTime;
        private Label Label_SystemFramework;
        private Label Label_OSVersion;
        private Label Label_OS;
        private Label Label_UUID;
        private Label Label_DeviceSN;
        private Label Label_BIOSVersion;
        private Label Label_ComputerManufacturer;
        private Label Label_DeviceModel;
        private Panel Panel_CPU;
        private Panel Panel_Memory;
        private Panel Panel_GPU;
        private Panel Panel_Disk;
        private PictureBox PictureBox_CPU;
        private Label Label_L3Cache;
        private Label Label_L2Cache;
        private Label Label_CPUFramework;
        private Label Label_CPUThreadCount;
        private Label Label_CPUCoreCount;
        private Label Label_CPUClockSpeed;
        private Label Label_CPUModel;
        private PictureBox PictureBox_Memory;
        private Label Label_VirtualMemory;
        private Label Label_MaxMemory;
        private Label Label_AvailableMemory;
        private Label Label_InstallMemory;
        private Label Label_MemorySpeed;
        private Label Label_MemoryInstallNumber;
        private Label Label_MemoryManufacturer;
        private PictureBox PictureBox_GPU;
        private Label Label_GPU2DriverDate;
        private Label Label_GPU2Memory;
        private Label Label_GPU2Model;
        private Label Label_GPU1DriverDate;
        private Label Label_GPU1Memory;
        private Label Label_GPU1Model;
        private Label Label_Disk2InterfaceType;
        private Label Label_Disk2Size;
        private Label Label_Disk2Model;
        private Label Label_Disk1InterfaceType;
        private Label Label_Disk1Size;
        private Label Label_Disk1Model;
        private PictureBox PictureBox_Disk;
        private Label Label_UserName;
        private System.ComponentModel.BackgroundWorker BackgroundWorker_GetInfo;
        private ProgressBar ProgressBar_Scanning;
        private Label Label_Tip;
        private Label Label_InternalIP;
        private Label Label_InternetIP;
        private Label Label_NetState;
    }
}