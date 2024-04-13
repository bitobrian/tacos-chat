namespace TacosChatSsr.Services;

public class StorageService : IDeviceStorage
{
    public string GetSaveFolderPath()
    {
        const string FolderName = "TacosChat";

        var path = $"C:\\{FolderName}";

        Directory.CreateDirectory(path);

        return path;
    }
}
