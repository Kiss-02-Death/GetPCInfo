using System.Management;

namespace GetDeviceInfo
{
    public class Disk
    {
        public static List<string> GetDiskInfo()
        {
            List<string> HarkDisk_Info = new List<string>();
            ManagementClass HardDisk = new("Win32_DiskDrive");
            foreach (var Info in HardDisk.GetInstances())
            {
                HarkDisk_Info.Add(Info["Caption"].ToString()); // 硬盘名称
                HarkDisk_Info.Add(Math.Round(Convert.ToDouble(Info["Size"].ToString()) / 1024 / 1024 / 1024, 2).ToString()); // 硬盘大小
                HarkDisk_Info.Add(Info["InterfaceType"].ToString()); // 接口类型
            }
            return HarkDisk_Info;
        }
    }
}
