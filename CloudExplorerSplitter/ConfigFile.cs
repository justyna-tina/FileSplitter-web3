using System.Collections.Generic;

namespace CloudExplorerSplitter
{
    public class ConfigFile
    {
        public string dirPath;
        public int n;
        public List<string> virtualDirectoryNames;
        public List<string> virtualDirectoryPaths;

        public ConfigFile()
        {
        }

        public ConfigFile(string dirPath, int n, List<string> virtualDirectoryNames, List<string> virtualDirectoryPaths)
        {
            this.dirPath = dirPath;
            this.n = n;
            this.virtualDirectoryNames = virtualDirectoryNames;
            this.virtualDirectoryPaths = virtualDirectoryPaths;
        }
    }
}