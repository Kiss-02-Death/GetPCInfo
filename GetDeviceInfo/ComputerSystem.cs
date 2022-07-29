using System.Management;

namespace GetDeviceInfo
{
    public class ComputerSystem
    {
        public static List<string> GetSystemInfo()
        {
            List<string> System_Info = new List<string>();
            ManagementClass system = new("Win32_OperatingSystem");
            foreach (var Info in system.GetInstances())
            {
                System_Info.Add(Info["Caption"].ToString()); // 操作系统
                System_Info.Add(Info["Version"].ToString()); // 版本号
                System_Info.Add(DateFormat(Info["InstallDate"].ToString())); // 系统安装时间
                System_Info.Add(Info["Manufacturer"].ToString()); // 系统来源
                System_Info.Add(Info["SystemDirectory"].ToString()); // 系统路径
                System_Info.Add(Info["RegisteredUser"].ToString()); // 注册用户
                System_Info.Add(Info["SerialNumber"].ToString()); // 产品ID

            }
            return System_Info;
        }
        private static string DateFormat(string date)  // 处理时间格式
        {
            string Date = date.Substring(0, 4) + "年" + date.Substring(4, 2) + "月" + date.Substring(6, 2) + "日" +
                            date.Substring(8, 2) + "时" + date.Substring(10, 2) + "分" + date.Substring(12, 2) + "秒";
            return Date;
        }
    }
}
