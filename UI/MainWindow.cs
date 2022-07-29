using GetDeviceInfo;

namespace UI
{
    public partial class MainWindow : Form
    {
        private static bool IsDragging = false; // 用于指示当前是否处于拖拽状态
        private Point StartPoint = new Point(0, 0); // 记录鼠标左键按下去时的坐标
        private Point OffsetPoint = new Point(0, 0); // 记录偏移量

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口加载时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            SayHello();
            // 启动“动态刷新时间”定时器
            DynamicShowTime.Start();
            // 启动后台工作读取信息
            BackgroundWorker_GetInfo.RunWorkerAsync();
        }

        /// <summary>
        /// 动态刷新时间显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DynamicShowTime_Tick(object sender, EventArgs e)
        {
            Label_Time.Text = "当前时间：" + DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// 问候
        /// </summary>
        private void SayHello()
        {
            string UserName = Environment.UserName;
            DateTime now = DateTime.Now;
            if (now.Hour < 11)
                Label_UserName.Text = "早上好！" + UserName;
            else if (now.Hour <= 14)
                Label_UserName.Text = "中午好！" + UserName;
            else if (now.Hour <= 19)
                Label_UserName.Text = "下午好！" + UserName;
            else
                Label_UserName.Text = "晚上好！" + UserName;
        }

        private void Panel_WindowTitle_MouseDown(object sender, MouseEventArgs e)
        {
            // 如果按下去的按钮不是鼠标左键，则直接return
            if (e.Button != MouseButtons.Left)
                return;
            // 按下鼠标左键后，进入拖动状态
            IsDragging = true;
            // 记录刚刚鼠标按下时的坐标
            StartPoint = new Point(e.X, e.Y);
        }

        private void Panel_WindowTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging)
            {
                // 用当前坐标减去初始坐标得到偏移量Offset
                OffsetPoint = new Point(e.X - StartPoint.X, e.Y - StartPoint.Y);
                // 将Offset转化为屏幕坐标赋值给Location
                this.Location = PointToScreen(OffsetPoint);
            }
        }

        private void Panel_WindowTitle_MouseUp(object sender, MouseEventArgs e)
        {
            // 鼠标左键松开时，把拖动判定改为false
            IsDragging = false;
        }

        /// <summary>
        /// 关闭应用程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// 最小化窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 单击“配置详情”可重新扫描
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_ConfigDetail_Click(object sender, EventArgs e)
        {
            Label_ConfigDetail.Enabled = false;

            // 重置界面
            ResetWindow();

            // 启动扫描
            BackgroundWorker_GetInfo.RunWorkerAsync();
        }

        /// <summary>
        /// 后台读取电脑配置信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker_GetInfo_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Random random = new Random();

            // 获取电脑信息
            List<string> product = Product.GetProductInfo();
            BackgroundWorker_GetInfo.ReportProgress(random.Next(1, 15), product);

            // 获取系统信息
            List<string> system = ComputerSystem.GetSystemInfo();
            BackgroundWorker_GetInfo.ReportProgress(random.Next(15, 30), system);

            // 获取CPU信息
            List<string> cpu = CPU.GetCPUInfo();
            BackgroundWorker_GetInfo.ReportProgress(random.Next(30, 45), cpu);

            // 获取内存信息
            List<string> memory = Memory.GetMemoryInfo();
            BackgroundWorker_GetInfo.ReportProgress(random.Next(45, 60), memory);

            // 获取GPU信息
            List<string> gpu = GPU.GetGPUInfo();
            BackgroundWorker_GetInfo.ReportProgress(random.Next(60, 75), gpu);

            // 获取硬盘信息
            List<string> disk = Disk.GetDiskInfo();
            BackgroundWorker_GetInfo.ReportProgress(random.Next(75, 90), disk);

            // 获取IP信息
            List<string> ip = IPAddress.GetIPInfo();
            BackgroundWorker_GetInfo.ReportProgress(100, ip);
        }

        private void BackgroundWorker_GetInfo_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            // 更新进度条
            ProgressBar_Scanning.Value = e.ProgressPercentage;
            
            // 取出参数
            List<string> data = e.UserState as List<string>;

            // 更新窗体数据
            if (ProgressBar_Scanning.Value < 15) // 写入电脑信息
            {
                Label_Tip.Text = "正在扫描：电脑信息...";

                Label_DeviceModel.Text += data[0];
                Label_ComputerManufacturer.Text += data[1];
                Label_BIOSVersion.Text += data[2];
                Label_DeviceSN.Text += data[3];
                Label_UUID.Text += data[4];
                Label_DeviceName.Text += Environment.MachineName;
            }
            else if (ProgressBar_Scanning.Value < 30) // 写入系统信息
            {
                Label_Tip.Text = "正在扫描：系统信息...";

                Label_OS.Text += data[0];
                Label_OSVersion.Text += data[1];
                if (Environment.Is64BitOperatingSystem)
                    Label_SystemFramework.Text += "×64";
                else
                    Label_SystemFramework.Text += "×32";
                Label_InstallTime.Text += data[2];
                Label_SystemSource.Text += data[3];
                Label_InstallPath.Text += data[4];
                Label_RegisterUser.Text += data[5];
                Label_ProductID.Text += data[6];
            }
            else if (ProgressBar_Scanning.Value < 45) // 写入CPU信息
            {
                Label_Tip.Text = "正在扫描：CPU信息...";

                Label_CPUModel.Text += data[0];
                Label_CPUClockSpeed.Text += data[1] + " GHz";
                Label_CPUCoreCount.Text += data[2];
                Label_CPUThreadCount.Text += data[3];
                Label_CPUFramework.Text += "×" + data[4];
                Label_L2Cache.Text += data[5] + " MB";
                Label_L3Cache.Text += data[6] + " MB";
            }
            else if (ProgressBar_Scanning.Value < 60) // 写入内存信息
            {
                Label_Tip.Text = "正在扫描：内存信息...";

                Label_MemoryManufacturer.Text += data[0];
                Label_MemoryInstallNumber.Text += (data.Count - 4) / 2 + "条";
                Label_MemorySpeed.Text += data[1] + " MHz  ";
                if (data.Count > 6) // 多通道内存
                {
                    for (int i = 2; i < data.Count - 4; i += 2)
                        Label_MemoryManufacturer.Text += "  " + data[i];

                    for (int i = 3; i < data.Count - 4; i += 2)
                        Label_MemorySpeed.Text += data[i] + " MHz  ";
                }
                Label_MaxMemory.Text += data[data.Count - 4] + " GB";
                Label_InstallMemory.Text += data[data.Count - 3] + " GB";
                Label_AvailableMemory.Text += data[data.Count - 2] + " GB";
                Label_VirtualMemory.Text += data[data.Count - 1] + " GB";
            }
            else if (ProgressBar_Scanning.Value < 75) // 写入GPU信息
            {
                Label_Tip.Text = "正在扫描：GPU信息...";

                Label_GPU1Model.Text += data[0];
                Label_GPU1Memory.Text += data[1] + " GB";
                Label_GPU1DriverDate.Text += data[2];
                if (data.Count > 3) // 双显
                {
                    Label_GPU2Model.Visible = true;
                    Label_GPU2Memory.Visible = true;
                    Label_GPU2DriverDate.Visible = true;

                    Label_GPU2Model.Text += data[3];
                    Label_GPU2Memory.Text += data[4] + " GB";
                    Label_GPU2DriverDate.Text += data[5];
                }
            }
            else if (ProgressBar_Scanning.Value < 90) // 写入硬盘信息
            {
                Label_Tip.Text = "正在扫描：硬盘信息...";

                Label_Disk1Model.Text += data[0];
                Label_Disk1Size.Text += data[1] + " GB";
                Label_Disk1InterfaceType.Text += data[2];
                if (data.Count > 3) // 双硬盘
                {
                    Label_Disk2Model.Visible = true;
                    Label_Disk2Size.Visible = true;
                    Label_Disk2InterfaceType.Visible = true;
                    
                    Label_Disk2Model.Text += data[3];
                    Label_Disk2Size.Text += data[4] + " GB";
                    Label_Disk2InterfaceType.Text += data[5];
                }

            }
            else // 写入IP信息
            {
                Label_Tip.Text = "正在扫描：IP信息...";

                Label_InternetIP.Text += data[0];
                Label_InternalIP.Text += data[1];
                if (data.Count > 2) // 即启用v4和v6
                    Label_InternalIP.Text += "  " + data[2];

                // 判断是否联网
                if (Label_InternetIP.Text == "0.0.0.0")
                    Label_NetState.Text += "未连接！";
                else
                    Label_NetState.Text += "已连接！";

            }
        }

        private void BackgroundWorker_GetInfo_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Label_ConfigDetail.Enabled = true;

            // 清空提示信息，并隐藏、重置进度条,结束扫描
            Label_Tip.Text = string.Empty;
            ProgressBar_Scanning.Visible = false;
            ProgressBar_Scanning.Value = 0;
        }

        private void ResetWindow()
        {
            Label_DeviceModel.Text = "设备型号：";
            Label_ComputerManufacturer.Text = "制造商：";
            Label_BIOSVersion.Text = "BIOS版本：";
            Label_DeviceSN.Text = "设备SN：";
            Label_UUID.Text = "UUID：";
            Label_OS.Text = "操作系统：";
            Label_OSVersion.Text = "版本号：";
            Label_SystemFramework.Text = "系统架构：";
            Label_InstallTime.Text = "安装时间：";
            Label_SystemSource.Text = "系统来源：";
            Label_InstallPath.Text = "安装路径：";
            Label_RegisterUser.Text = "注册用户：";
            Label_ProductID.Text = "产品ID：";
            Label_DeviceName.Text = "设备名称：";

            Label_CPUModel.Text = "CPU型号：";
            Label_CPUClockSpeed.Text = "CPU主频：";
            Label_CPUCoreCount.Text = "CPU内核：";
            Label_CPUThreadCount.Text = "CPU线程：";
            Label_CPUFramework.Text = "CPU架构：";
            Label_L2Cache.Text = "L2缓存：";
            Label_L3Cache.Text = "L3缓存：";

            Label_MemoryManufacturer.Text = "制造商：";
            Label_MemoryInstallNumber.Text = "安装数量：";
            Label_MemorySpeed.Text = "内存速度：";
            Label_MaxMemory.Text = "最大内存：";
            Label_InstallMemory.Text = "安装内存：";
            Label_AvailableMemory.Text = "可用内存：";
            Label_VirtualMemory.Text = "虚拟内存：";

            Label_GPU2Model.Visible = false;
            Label_GPU2Memory.Visible = false;
            Label_GPU2DriverDate.Visible = false;
            Label_GPU1Model.Text = "GPU型号：";
            Label_GPU1Memory.Text = "GPU显存：";
            Label_GPU1DriverDate.Text = "驱动日期：";
            Label_GPU2Model.Text = "GPU型号：";
            Label_GPU2Memory.Text = "GPU显存：";
            Label_GPU2DriverDate.Text = "驱动日期：";

            Label_Disk2Model.Visible = false;
            Label_Disk2Size.Visible = false;
            Label_Disk2InterfaceType.Visible = false;
            Label_Disk1Model.Text = "硬盘型号：";
            Label_Disk1Size.Text = "硬盘大小：";
            Label_Disk1InterfaceType.Text = "接口类型：";
            Label_Disk2Model.Text = "硬盘型号：";
            Label_Disk2Size.Text = "硬盘大小：";
            Label_Disk2InterfaceType.Text = "接口类型：";

            Label_InternetIP.Text = "外网IP：";
            Label_InternalIP.Text = "内网IP：";
            Label_NetState.Text = "当前网络：";

            ProgressBar_Scanning.Visible = true;
        }
    }
}