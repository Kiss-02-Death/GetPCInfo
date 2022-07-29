using System.Management;

namespace GetDeviceInfo
{
    public class GPU
    {
        public static List<string> GetGPUInfo()
        {
            List<string> GPU_Info = new List<string>();
            ManagementClass GPU = new("Win32_VideoController");
            foreach (var Info in GPU.GetInstances())
            {
                GPU_Info.Add(Info["Name"].ToString()); // 显卡名称
                GPU_Info.Add(((Math.Round(Convert.ToDouble(Info["AdapterRAM"].ToString()) / 1024 / 1024 / 1024, 1))).ToString()); // 显存大小
                GPU_Info.Add(DateFormat(Info["DriverDate"].ToString())); // 驱动日期
            }
            return GPU_Info;
        }
        private static string DateFormat(string date)  // 处理时间格式
        {
            string Date = date.Substring(0, 4) + "年" + date.Substring(4, 2) + "月" + date.Substring(6, 2) + "日";
            return Date;
        }
    }
}
