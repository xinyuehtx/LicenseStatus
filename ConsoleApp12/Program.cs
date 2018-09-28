using System;
using System.Management;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT ApplicationID, Description, ID, LicenseStatus, Name FROM SoftwareLicensingProduct WHERE LicenseStatus=1");
            foreach (var queryObj in searcher.Get())
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("SoftwareLicensingProduct instance");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("ApplicationID: {0}", queryObj["ApplicationID"]);
                Console.WriteLine("Description: {0}", queryObj["Description"]);
                Console.WriteLine("ID: {0}", queryObj["ID"]);
                Console.WriteLine("LicenseStatus: {0}", queryObj["LicenseStatus"]);
                Console.WriteLine("Name: {0}", queryObj["Name"]);
            }
            Console.Read();
        }
    }
}
