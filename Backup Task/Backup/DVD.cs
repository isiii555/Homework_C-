using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    public class DVD : IStorage
    {
        public string mediaName { get; set; }

        public string Model { get; set; }

        public double Media { get; set; }

        public double Size { get; set; }

        public byte Type { get; set; } 

        public double readSpeed = 1.38;

        public DVD(string mediaName, string model, double media, byte type)
        {
            this.mediaName = mediaName;
            Model = model;
            Media = media;
            Type = type;
            if (Type == 1)
                Size = 4700;
            else
                Size = 9000;
        }

        public void CopyMethod()
        {
            double media = Media / Size;
            Console.Clear();
            Console.WriteLine($"Copy started...");
            Console.WriteLine($"Media size : {Media} Mb");
            Console.WriteLine($"Device count : {((int)(Media / Size)) + 1}");
            Console.WriteLine($"Media size per device : {Size} Mb");
            Console.WriteLine($"Upload speed : {readSpeed} Mbps");
            Console.WriteLine($"Estimated time : {(float)(Size / readSpeed)} minutes");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public void FreeMemory()
        {
            Console.Clear();
            Console.WriteLine($"Free memory : {Size - Media} gb");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public void PrintDeviceInfo()
        {
            Console.Clear();
            Console.WriteLine("-----Device Info-----");
            Console.WriteLine($"Media name : {mediaName}");
            Console.WriteLine($"Media model : {Model}");
            Console.WriteLine($"Device speed : {readSpeed} Mbps");
            Console.WriteLine($"Device size : {Size} Mb");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
