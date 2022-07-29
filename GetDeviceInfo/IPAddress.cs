using System.Net;
using System.Text;
using System.Management;

namespace GetDeviceInfo
{
    public class IPAddress
    {
        public static List<string> GetIPInfo()
        {
            List<string> IP_Info = new List<string>();

            // 获取外网IP
            string InternetIP = "";
            string Url = "http://ip.tool.chinaz.com/";
            Uri uri = new Uri(Url);
            try
            {
                WebRequest webRequest = WebRequest.Create(uri);
                Stream s = webRequest.GetResponse().GetResponseStream();
                StreamReader streamReader = new StreamReader(s, Encoding.UTF8);
                string all = streamReader.ReadToEnd();
                string temp = all.Substring(all.IndexOf("<span id=\"IpValue\">") + 19, 15);
                for (int i = 0; i < 15; i++)
                {
                    if (temp[i] == '.')
                    {
                        InternetIP += ".";
                        continue;
                    }

                    try
                    {
                        int j = int.Parse(temp[i].ToString());
                        InternetIP += j;
                    }
                    catch
                    {
                        IP_Info.Add(InternetIP);
                        break;
                    }
                }
                if (IP_Info.Count == 0)
                    IP_Info.Add(InternetIP);
            }
            catch  // 若无法捕捉到公网IP，则为0，继续捕捉内网IP
            {
                IP_Info.Add("0.0.0.0");
                throw;
            }
            IP_Info.AddRange(InternalIP());
            return IP_Info;
        }
        private static List<string> InternalIP()  // 获取内网IP
        {
            List<string> InternalIP_Info = new List<string>();

            ManagementClass mc_nac = new("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc_nac = mc_nac.GetInstances();
            foreach (ManagementObject mo in moc_nac)
            {
                string mServiceName = mo["ServiceName"] as string;

                // 过滤非真实网卡
                if (!(bool)mo["IPEnabled"])
                { continue; }
                if (mServiceName.ToLower().Contains("vmnetadapter")
                   || mServiceName.ToLower().Contains("ppoe")
                   || mServiceName.ToLower().Contains("bthpan")
                   || mServiceName.ToLower().Contains("tapvpn")
                    || mServiceName.ToLower().Contains("ndisip")
                     || mServiceName.ToLower().Contains("sinforvnic"))
                { continue; }
                // 过滤非真实网卡

                bool mDHCPEnabled = (bool)mo["IPEnabled"];
                string mCaption = mo["Caption"] as string;
                string mMACAddress = mo["MACAddress"] as string;
                string[] mIPAddress = mo["IPAddress"] as string[];
                string[] mIPSubnet = mo["IPSubnet"] as string[];
                string[] mDefaultIPGateway = mo["DefaultIPGateway"] as string[];
                string[] mDNSServerSearchOrder = mo["DNSServerSearchOrder"] as string[];
                if (mIPAddress != null)
                {

                    foreach (string ip in mIPAddress)
                    {
                        InternalIP_Info.Add(ip);
                    }
                }
                mo.Dispose();
            }
            return InternalIP_Info;
        }
    }
}
