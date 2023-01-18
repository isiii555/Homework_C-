namespace Backup
{
    public interface IStorage
    {
        string mediaName { get; set; }

        string Model { get; set; }

        double Media { get; set; }

        void CopyMethod();

        void FreeMemory();

        void PrintDeviceInfo();

    }
}
