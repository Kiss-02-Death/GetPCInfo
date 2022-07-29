using System.Management;

namespace GetDeviceInfo
{
    public class CPU
    {
        public static List<string> GetCPUInfo()
        {
            List<string> CPU_Info = new List<string>();
            ManagementClass CPU = new("win32_Processor");    
            foreach (var Info in CPU.GetInstances())
            {
                CPU_Info.Add(Info["Name"].ToString()); // CPU名称
                CPU_Info.Add(Math.Round(Convert.ToDouble(Info["CurrentClockSpeed"].ToString()) / 1024, 2).ToString()); // CPU主频
                CPU_Info.Add(Info["NumberOfEnabledCore"].ToString()); // CPU内核
                CPU_Info.Add(Info["ThreadCount"].ToString()); // CPU线程
                CPU_Info.Add(Info["DataWidth"].ToString()); // CPU架构
                CPU_Info.Add(Math.Round(Convert.ToDouble(Info["L2CacheSize"].ToString()) / 1024, 2).ToString()); // L2缓存
                CPU_Info.Add(Math.Round(Convert.ToDouble(Info["L3CacheSize"].ToString()) / 1024, 2).ToString()); // L3缓存
            }
            return CPU_Info;
        }
    }
}