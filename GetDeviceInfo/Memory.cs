using System.Management;
using Microsoft.VisualBasic.Devices;

namespace GetDeviceInfo
{
    public class Memory
    {
        public static List<string> GetMemoryInfo()
        {
            List<string> Memory_Info = new List<string>();


            ManagementClass physicalMemory = new("Win32_PhysicalMemory");
            foreach (var Info in physicalMemory.GetInstances())
            {
                Memory_Info.Add(Info["Manufacturer"].ToString()); // 生产商
                Memory_Info.Add(Info["Speed"].ToString()); // 速率
            }

            ManagementClass physicalMemoryArray = new("Win32_PhysicalMemoryArray");
            foreach (var Info in physicalMemoryArray.GetInstances())
            {
                Memory_Info.Add((Convert.ToInt64(Info["MaxCapacityEx"].ToString()) / 1024 / 1024).ToString()); // 最大物理内存
            }

            ComputerInfo Memory = new ComputerInfo();
            double TotalPhysicalMemory = Math.Round((double)Memory.TotalPhysicalMemory / 1024 / 1024 / 1024, 2);
            Memory_Info.Add(TotalPhysicalMemory.ToString()); // 总物理内存
            double AvailablePhysicalMemory = Math.Round((double)Memory.AvailablePhysicalMemory / 1024 / 1024 / 1024, 2);
            Memory_Info.Add(AvailablePhysicalMemory.ToString()); // 可用物理内存
            double VirtualMemory = Math.Round((double)Memory.TotalVirtualMemory / 1024 / 1024 / 1024, 2);
            Memory_Info.Add(VirtualMemory.ToString()); // 虚拟内存

            return Memory_Info;
        }
    }
}
