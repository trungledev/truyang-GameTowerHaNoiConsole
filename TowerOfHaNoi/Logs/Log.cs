using System.IO;
using System.Text;

namespace TowerOfHaNoi.Log;

public static class WriteLog
{
    public static void WriteLogToFile(string message)
    {
        var fileName  = "./Log.txt";
        string line = "Message: " + message + " + Time: " + DateTime.Now.ToString();
        var file = File.AppendText(fileName);
        file.WriteLine(line);
        file.Dispose();
    }
}
