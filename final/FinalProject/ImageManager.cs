using System.IO;
class ImageManager
{
    private string _desktopBackgroundImagePath;
    private string _os;
    public ImageManager()
    {
        _os = Environment.OSVersion.ToString();
        if (_os == "Unix" || _os == "Linux")
        {
            _desktopBackgroundImagePath = "/usr/share/backgrounds/default.jpg";
        }
        else if (_os == "Windows")
        {
            _desktopBackgroundImagePath = @"C:\Windows\Web\Wallpaper\Windows\img0.jpg";
        }
        else if (_os == "MacOS")
        {
            _desktopBackgroundImagePath = "/System/Library/Desktop Pictures";
        }
        else
        {
            _desktopBackgroundImagePath = "default.jpg";
        }
    }
    public void DisplayOsInfo()
    {
        Console.WriteLine($"Operating System: {_os}");
    }
}