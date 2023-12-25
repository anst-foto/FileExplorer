var discs = DriveInfo.GetDrives();

foreach (var disc in discs)
{
    Console.WriteLine($"{disc.Name}\t|\t{disc.DriveType}\t|\t{disc.DriveFormat}\t|\t{disc.VolumeLabel}");

    try
    {
        foreach (var directory in disc.RootDirectory.GetDirectories())
        {
            Console.WriteLine($"{directory.Name}\t=\t{directory.UnixFileMode}");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

    try
    {
        foreach (var file in disc.RootDirectory.GetFiles())
        {
            Console.WriteLine($"{file.Name}\t+\t{file.UnixFileMode}\t+\t{file.Attributes}");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}