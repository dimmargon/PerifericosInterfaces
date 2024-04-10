using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace p6_S1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringCollection propNames = new StringCollection();
            ManagementClass driveClass = new
            ManagementClass("Win32_DiskDrive");
            PropertyDataCollection props = driveClass.Properties;
            foreach (PropertyData driveProperty in props)
            {
                propNames.Add(driveProperty.Name);
            }
            int idx = 0;
            ManagementObjectCollection drives = driveClass.GetInstances();
            foreach (ManagementObject drv in drives)
            {
                Console.WriteLine(" ******** Drive({0}) Properties * ***********", idx+1);
                foreach (string strProp in propNames)
                {
                    Console.WriteLine("Property: {0}, Value: {1}",
                    strProp, drv[strProp]);
                }
            }
        }

    }
}

