using System.Collections.Generic;
using System.IO;

namespace CloudExplorerSplitter
{
    public class Disperser
    {
        public static int Disperse(string dirPath, int n, List<string> virtualDirectoryNames)
        {
            string dirPathWithoutDirectory = Path.GetDirectoryName(dirPath);
            string dirName = Path.GetFileName(dirPath);
            //create main folder
            string path = dirPathWithoutDirectory + @"\." + dirName;
            Splitter.CreateDirectory(path);

            /*string pathForBase = path + @"\." + dirName + @"-";
            for (int i = 0; i < n; i++)
            {
                CreateDirectory(pathForBase + i.ToString());
            }

            //empty files
            for (int i = 0; i < n; i++)
            {
                //append into every file
                string pathForEmpty = pathForBase + i.ToString() + @"\." + dirName + @"-" + i.ToString() + @".txt";
                try
                {
                    File.Delete(pathForEmpty);
                }
                catch (IOException exception)
                { }
            }

            //open n FileStreams
            string[] pathFor = new string[n];
            for (int i = 0; i < n; i++)
            {
                pathFor[i] = pathForBase + i.ToString() + @"\." + dirName + @"-" + i.ToString() + @".txt";
            }
            FileStream[] fsas = new FileStream[n];
            for (int i = 0; i < n; i++)
            {
                fsas[i] = File.Open(pathFor[i], FileMode.Append, FileAccess.Write, FileShare.None);
            }

            //open file
            using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                byte[] barray = new byte[n];
                //int rr = fs.Read(array, offset, n);
                int rr = 0;
                while ((rr = fs.Read(barray, 0, barray.Length)) > 0)
                {
                    for (int i = 0; i < rr; i++)
                    {
                        //append into every file
                        fsas[i].Write(barray, i, 1);
                    }

                    //UTF8Encoding temp = new UTF8Encoding(true);
                    //richTextBox1.AppendText(temp.GetString(barray, 0, rr) +"\n");
                }

                //Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                // Add some information to the file.
                //fs.Write(info, 0, info.Length);
                fs.Close();
            }

            //free streams
            for (int i = 0; i < n; i++)
            {
                fsas[i].Close();
                fsas[i].Dispose();
            }
            fsas = null;*/

            return 0;
        }
    }
}
