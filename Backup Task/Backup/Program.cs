using Backup;

Flash flash_disc = new("Flash Disc", "HP", 565 * 780, 2 * 1024);
HDD hdd = new("HDD", "Kingston", 565 * 780, 500 * 1024);
DVD dvd = new("DVD", "Sade", 565 * 780, 2);

flash_disc.CopyMethod();
flash_disc.PrintDeviceInfo();
Console.ReadKey();
hdd.CopyMethod();
hdd.PrintDeviceInfo();
Console.ReadKey();
dvd.CopyMethod();
dvd.PrintDeviceInfo();
Console.ReadKey();

