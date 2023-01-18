namespace Backup
{
    public class Flash : IStorage
    {
        public string mediaName { get; set; }

        public string Model { get; set; }

        public double Media { get; set; }

        public double Size { get; set; }

        public double Speed = 600;

        public Flash(string mediaName, string model, double media, double size)
        {
            this.mediaName = mediaName;
            Model = model;
            Media = media;
            Size = size;
        }

        public void CopyMethod()
        {
            double media = Media / Size;
            Console.Clear();
            Console.WriteLine($"Copy started...");
            Console.WriteLine($"Media size : {Media} Mb");
            Console.WriteLine($"Device count : {((int)(Media / Size)) + 1}");
            Console.WriteLine($"Media size per device : {Size} MB");
            Console.WriteLine($"Upload speed : {Speed} Mbps ");
            Console.WriteLine($"Estimated time : {(float)(Size / Speed)} minutes");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public void FreeMemory()
        {
            Console.Clear();
            Console.WriteLine($"Free memory : {Size-Media} gb");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public void PrintDeviceInfo()
        {
            Console.Clear();
            Console.WriteLine("-----Device Info-----");
            Console.WriteLine($"Media name : {mediaName}");
            Console.WriteLine($"Media model : {Model}");
            Console.WriteLine($"Device speed : {Speed}  Mbps");
            Console.WriteLine($"Device size : {Size}  Mb");
            Thread.Sleep(2000);
            Console.Clear();
        }

    }
}
