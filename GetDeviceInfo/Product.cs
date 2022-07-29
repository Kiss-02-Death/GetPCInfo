using System.Management;

namespace GetDeviceInfo
{
    public class Product
    {
        public static List<string> GetProductInfo()
        {
            List<string> Product_Info = new List<string>();
            ManagementClass SystemProduct = new("Win32_ComputerSystemProduct");
            foreach (var Info in SystemProduct.GetInstances())
            {
                Product_Info.Add(Info["Name"].ToString()); // 型号
                Product_Info.Add(Info["Vendor"].ToString()); // 制造商
                Product_Info.Add(Info["Version"].ToString()); // BIOS版本
                Product_Info.Add(Info["IdentifyingNumber"].ToString()); // SN号
                Product_Info.Add(Info["UUID"].ToString()); // UUID
            }
            return Product_Info;
        }
    }
}
