using System.Collections.Generic;
using System.IO;

namespace CloudExplorerSplitter
{
    public class ConfigFile
    {
        public string dirPath;
        public string splitedDirPath;
        public string baseDestinationDirPath { get { return splitedDirPath; } }//return Path.GetDirectoryName(dirPath) + @"\." + Path.GetFileName(dirPath); } }
        public int n;
        public List<string> virtualDirectoryNames;
        public List<string> virtualDirectoryPaths;

        public ConfigFile()
        {
        }

        public ConfigFile(string dirPath, string splitedDirPath, int n, List<string> virtualDirectoryNames, List<string> virtualDirectoryPaths)
        {
            this.dirPath = dirPath;
            this.splitedDirPath = splitedDirPath;
            this.n = n;
            this.virtualDirectoryNames = virtualDirectoryNames;
            this.virtualDirectoryPaths = virtualDirectoryPaths;
        }
    }
}