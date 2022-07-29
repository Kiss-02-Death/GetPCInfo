using GetDeviceInfo;

namespace UI
{
    public partial class MainWindow : Form
    {
        private static bool IsDragging = false; // ����ָʾ��ǰ�Ƿ�����ק״̬
        private Point StartPoint = new Point(0, 0); // ��¼����������ȥʱ������
        private Point OffsetPoint = new Point(0, 0); // ��¼ƫ����

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ���ڼ���ʱִ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            SayHello();
            // ��������̬ˢ��ʱ�䡱��ʱ��
            DynamicShowTime.Start();
            // ������̨������ȡ��Ϣ
            BackgroundWorker_GetInfo.RunWorkerAsync();
        }

        /// <summary>
        /// ��̬ˢ��ʱ����ʾ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DynamicShowTime_Tick(object sender, EventArgs e)
        {
            Label_Time.Text = "��ǰʱ�䣺" + DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// �ʺ�
        /// </summary>
        private void SayHello()
        {
            string UserName = Environment.UserName;
            DateTime now = DateTime.Now;
            if (now.Hour < 11)
                Label_UserName.Text = "���Ϻã�" + UserName;
            else if (now.Hour <= 14)
                Label_UserName.Text = "����ã�" + UserName;
            else if (now.Hour <= 19)
                Label_UserName.Text = "����ã�" + UserName;
            else
                Label_UserName.Text = "���Ϻã�" + UserName;
        }

        private void Panel_WindowTitle_MouseDown(object sender, MouseEventArgs e)
        {
            // �������ȥ�İ�ť��������������ֱ��return
            if (e.Button != MouseButtons.Left)
                return;
            // �����������󣬽����϶�״̬
            IsDragging = true;
            // ��¼�ո���갴��ʱ������
            StartPoint = new Point(e.X, e.Y);
        }

        private void Panel_WindowTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging)
            {
                // �õ�ǰ�����ȥ��ʼ����õ�ƫ����Offset
                OffsetPoint = new Point(e.X - StartPoint.X, e.Y - StartPoint.Y);
                // ��Offsetת��Ϊ��Ļ���긳ֵ��Location
                this.Location = PointToScreen(OffsetPoint);
            }
        }

        private void Panel_WindowTitle_MouseUp(object sender, MouseEventArgs e)
        {
            // �������ɿ�ʱ�����϶��ж���Ϊfalse
            IsDragging = false;
        }

        /// <summary>
        /// �ر�Ӧ�ó���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// ��С������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// �������������顱������ɨ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_ConfigDetail_Click(object sender, EventArgs e)
        {
            Label_ConfigDetail.Enabled = false;

            // ���ý���
            ResetWindow();

            // ����ɨ��
            BackgroundWorker_GetInfo.RunWorkerAsync();
        }

        /// <summary>
        /// ��̨��ȡ����������Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker_GetInfo_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Random random = new Random();

            // ��ȡ������Ϣ
            List<string> product = Product.GetProductInfo();
            BackgroundWorker_GetInfo.ReportProgress(random.Next(1, 15), product);

            // ��ȡϵͳ��Ϣ
            List<string> system = ComputerSystem.GetSystemInfo();
            BackgroundWorker_GetInfo.ReportProgress(random.Next(15, 30), system);

            // ��ȡCPU��Ϣ
            List<string> cpu = CPU.GetCPUInfo();
            BackgroundWorker_GetInfo.ReportProgress(random.Next(30, 45), cpu);

            // ��ȡ�ڴ���Ϣ
            List<string> memory = Memory.GetMemoryInfo();
            BackgroundWorker_GetInfo.ReportProgress(random.Next(45, 60), memory);

            // ��ȡGPU��Ϣ
            List<string> gpu = GPU.GetGPUInfo();
            BackgroundWorker_GetInfo.ReportProgress(random.Next(60, 75), gpu);

            // ��ȡӲ����Ϣ
            List<string> disk = Disk.GetDiskInfo();
            BackgroundWorker_GetInfo.ReportProgress(random.Next(75, 90), disk);

            // ��ȡIP��Ϣ
            List<string> ip = IPAddress.GetIPInfo();
            BackgroundWorker_GetInfo.ReportProgress(100, ip);
        }

        private void BackgroundWorker_GetInfo_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            // ���½�����
            ProgressBar_Scanning.Value = e.ProgressPercentage;
            
            // ȡ������
            List<string> data = e.UserState as List<string>;

            // ���´�������
            if (ProgressBar_Scanning.Value < 15) // д�������Ϣ
            {
                Label_Tip.Text = "����ɨ�裺������Ϣ...";

                Label_DeviceModel.Text += data[0];
                Label_ComputerManufacturer.Text += data[1];
                Label_BIOSVersion.Text += data[2];
                Label_DeviceSN.Text += data[3];
                Label_UUID.Text += data[4];
                Label_DeviceName.Text += Environment.MachineName;
            }
            else if (ProgressBar_Scanning.Value < 30) // д��ϵͳ��Ϣ
            {
                Label_Tip.Text = "����ɨ�裺ϵͳ��Ϣ...";

                Label_OS.Text += data[0];
                Label_OSVersion.Text += data[1];
                if (Environment.Is64BitOperatingSystem)
                    Label_SystemFramework.Text += "��64";
                else
                    Label_SystemFramework.Text += "��32";
                Label_InstallTime.Text += data[2];
                Label_SystemSource.Text += data[3];
                Label_InstallPath.Text += data[4];
                Label_RegisterUser.Text += data[5];
                Label_ProductID.Text += data[6];
            }
            else if (ProgressBar_Scanning.Value < 45) // д��CPU��Ϣ
            {
                Label_Tip.Text = "����ɨ�裺CPU��Ϣ...";

                Label_CPUModel.Text += data[0];
                Label_CPUClockSpeed.Text += data[1] + " GHz";
                Label_CPUCoreCount.Text += data[2];
                Label_CPUThreadCount.Text += data[3];
                Label_CPUFramework.Text += "��" + data[4];
                Label_L2Cache.Text += data[5] + " MB";
                Label_L3Cache.Text += data[6] + " MB";
            }
            else if (ProgressBar_Scanning.Value < 60) // д���ڴ���Ϣ
            {
                Label_Tip.Text = "����ɨ�裺�ڴ���Ϣ...";

                Label_MemoryManufacturer.Text += data[0];
                Label_MemoryInstallNumber.Text += (data.Count - 4) / 2 + "��";
                Label_MemorySpeed.Text += data[1] + " MHz  ";
                if (data.Count > 6) // ��ͨ���ڴ�
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
            else if (ProgressBar_Scanning.Value < 75) // д��GPU��Ϣ
            {
                Label_Tip.Text = "����ɨ�裺GPU��Ϣ...";

                Label_GPU1Model.Text += data[0];
                Label_GPU1Memory.Text += data[1] + " GB";
                Label_GPU1DriverDate.Text += data[2];
                if (data.Count > 3) // ˫��
                {
                    Label_GPU2Model.Visible = true;
                    Label_GPU2Memory.Visible = true;
                    Label_GPU2DriverDate.Visible = true;

                    Label_GPU2Model.Text += data[3];
                    Label_GPU2Memory.Text += data[4] + " GB";
                    Label_GPU2DriverDate.Text += data[5];
                }
            }
            else if (ProgressBar_Scanning.Value < 90) // д��Ӳ����Ϣ
            {
                Label_Tip.Text = "����ɨ�裺Ӳ����Ϣ...";

                Label_Disk1Model.Text += data[0];
                Label_Disk1Size.Text += data[1] + " GB";
                Label_Disk1InterfaceType.Text += data[2];
                if (data.Count > 3) // ˫Ӳ��
                {
                    Label_Disk2Model.Visible = true;
                    Label_Disk2Size.Visible = true;
                    Label_Disk2InterfaceType.Visible = true;
                    
                    Label_Disk2Model.Text += data[3];
                    Label_Disk2Size.Text += data[4] + " GB";
                    Label_Disk2InterfaceType.Text += data[5];
                }

            }
            else // д��IP��Ϣ
            {
                Label_Tip.Text = "����ɨ�裺IP��Ϣ...";

                Label_InternetIP.Text += data[0];
                Label_InternalIP.Text += data[1];
                if (data.Count > 2) // ������v4��v6
                    Label_InternalIP.Text += "  " + data[2];

                // �ж��Ƿ�����
                if (Label_InternetIP.Text == "0.0.0.0")
                    Label_NetState.Text += "δ���ӣ�";
                else
                    Label_NetState.Text += "�����ӣ�";

            }
        }

        private void BackgroundWorker_GetInfo_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Label_ConfigDetail.Enabled = true;

            // �����ʾ��Ϣ�������ء����ý�����,����ɨ��
            Label_Tip.Text = string.Empty;
            ProgressBar_Scanning.Visible = false;
            ProgressBar_Scanning.Value = 0;
        }

        private void ResetWindow()
        {
            Label_DeviceModel.Text = "�豸�ͺţ�";
            Label_ComputerManufacturer.Text = "�����̣�";
            Label_BIOSVersion.Text = "BIOS�汾��";
            Label_DeviceSN.Text = "�豸SN��";
            Label_UUID.Text = "UUID��";
            Label_OS.Text = "����ϵͳ��";
            Label_OSVersion.Text = "�汾�ţ�";
            Label_SystemFramework.Text = "ϵͳ�ܹ���";
            Label_InstallTime.Text = "��װʱ�䣺";
            Label_SystemSource.Text = "ϵͳ��Դ��";
            Label_InstallPath.Text = "��װ·����";
            Label_RegisterUser.Text = "ע���û���";
            Label_ProductID.Text = "��ƷID��";
            Label_DeviceName.Text = "�豸���ƣ�";

            Label_CPUModel.Text = "CPU�ͺţ�";
            Label_CPUClockSpeed.Text = "CPU��Ƶ��";
            Label_CPUCoreCount.Text = "CPU�ںˣ�";
            Label_CPUThreadCount.Text = "CPU�̣߳�";
            Label_CPUFramework.Text = "CPU�ܹ���";
            Label_L2Cache.Text = "L2���棺";
            Label_L3Cache.Text = "L3���棺";

            Label_MemoryManufacturer.Text = "�����̣�";
            Label_MemoryInstallNumber.Text = "��װ������";
            Label_MemorySpeed.Text = "�ڴ��ٶȣ�";
            Label_MaxMemory.Text = "����ڴ棺";
            Label_InstallMemory.Text = "��װ�ڴ棺";
            Label_AvailableMemory.Text = "�����ڴ棺";
            Label_VirtualMemory.Text = "�����ڴ棺";

            Label_GPU2Model.Visible = false;
            Label_GPU2Memory.Visible = false;
            Label_GPU2DriverDate.Visible = false;
            Label_GPU1Model.Text = "GPU�ͺţ�";
            Label_GPU1Memory.Text = "GPU�Դ棺";
            Label_GPU1DriverDate.Text = "�������ڣ�";
            Label_GPU2Model.Text = "GPU�ͺţ�";
            Label_GPU2Memory.Text = "GPU�Դ棺";
            Label_GPU2DriverDate.Text = "�������ڣ�";

            Label_Disk2Model.Visible = false;
            Label_Disk2Size.Visible = false;
            Label_Disk2InterfaceType.Visible = false;
            Label_Disk1Model.Text = "Ӳ���ͺţ�";
            Label_Disk1Size.Text = "Ӳ�̴�С��";
            Label_Disk1InterfaceType.Text = "�ӿ����ͣ�";
            Label_Disk2Model.Text = "Ӳ���ͺţ�";
            Label_Disk2Size.Text = "Ӳ�̴�С��";
            Label_Disk2InterfaceType.Text = "�ӿ����ͣ�";

            Label_InternetIP.Text = "����IP��";
            Label_InternalIP.Text = "����IP��";
            Label_NetState.Text = "��ǰ���磺";

            ProgressBar_Scanning.Visible = true;
        }
    }
}