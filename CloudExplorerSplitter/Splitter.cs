using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CloudExplorerSplitter
{
    public class Splitter
    {
        /*
        public static int Split(string filename,  int n, string directoryName = "")
        {
            //create main folder
            string path = @".\." + filename;
            CreateDirectory(path);
            string pathForBase = path + @"\." + filename + @"-";
            for (int i = 0; i < n; i++)
            {
                CreateDirectory(pathForBase + i.ToString());
            }

            //empty files
            for (int i = 0; i < n; i++)
            {
                //append into every file
                string pathForEmpty = pathForBase + i.ToString() + @"\." + filename + @"-" + i.ToString() + @".txt";
                File.Delete(pathForEmpty);
    }

    //open n FileStreams
    string[] pathFor = new string[n];
            for (int i = 0; i<n; i++)
            {
                pathFor[i] = pathForBase + i.ToString() + @"\." + filename + @"-" + i.ToString() + @".txt";
            }
FileStream[] fsas = new FileStream[n];
            for (int i = 0; i<n; i++)
            {
                fsas[i] = File.Open(pathFor[i], FileMode.Append, FileAccess.Write, FileShare.None);
            }

            //open file
            using (FileStream fs = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                byte[] barray = new byte[n];
//int rr = fs.Read(array, offset, n);
int rr = 0;
                while ((rr = fs.Read(barray, 0, barray.Length)) > 0)
                {
                    for (int i = 0; i<rr; i++)
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
            for (int i = 0; i<n; i++)
            {
                fsas[i].Close();
fsas[i].Dispose();
            }
            fsas = null;

            return 0;
        }
         * */
        public static int Split(string filePath,  int n, string directoryName = "")
        {
            string filename = Path.GetFileName(filePath);
            //create main folder
            string path = string.IsNullOrEmpty(directoryName) ? @".\." + filePath : directoryName;
            CreateDirectory(path);
            string pathForBase = path + @"\." + filename + @"-";
            for (int i = 0; i < n; i++)
            {
                CreateDirectory(pathForBase + i.ToString());
            }

            //empty files
            for (int i = 0; i < n; i++)
            {
                //append into every file
                string pathForEmpty = pathForBase + i.ToString() + @"\." + filename + @"-" + i.ToString() + @".txt";
                try
                {
                    File.Delete(pathForEmpty);
                }
                catch(IOException exception)
                { }
            }

            //open n FileStreams
            string[] pathFor = new string[n];
            for (int i = 0; i < n; i++)
            {
                pathFor[i] = pathForBase + i.ToString() + @"\." + filename + @"-" + i.ToString() + @".txt";
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
            fsas = null;

            return 0;
        }

        public static int Split(string filePath, int n, List<string> outputFilePaths)
        {
            if (outputFilePaths.Count != n) { return -1; }

            string filename = Path.GetFileName(filePath);
            //create main folder
            //string path = string.IsNullOrEmpty(directoryName) ? @".\." + filePath : directoryName;
            //CreateDirectory(path);
            //string pathForBase = path + @"\." + filename + @"-";
            for (int i = 0; i < n; i++)
            {
                string tempPath = Path.GetDirectoryName(outputFilePaths[i]);
                CreateDirectory(tempPath);
            }

            //empty files
            for (int i = 0; i < n; i++)
            {
                //append into every file
                string pathForEmpty = outputFilePaths[i];// pathForBase + i.ToString() + @"\." + filename + @"-" + i.ToString() + @".txt";
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
                pathFor[i] = outputFilePaths[i];// pathForBase + i.ToString() + @"\." + filename + @"-" + i.ToString() + @".txt";
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
            fsas = null;

            return 0;
        }

        public static void CreateDirectory(string path)
        {
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));
                //richTextBox1.AppendText("The directory was created successfully: " + path + "\n");

                // Delete the directory.
                //di.Delete();
                //Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception exception)
            {
                Console.WriteLine("The process failed: {0}", exception.ToString());
            }
            finally { }

            return;
        }

        /*
        public static int Merge(string filename, int n, string directoryName = "")
        {
            //create main folder
            string path = @".\." + filename;
            string pathForBase = path + @"\." + filename + @"-";
            string[] pathFor = new string[n];
            for (int i = 0; i < n; i++)
            {
                pathFor[i] = pathForBase + i.ToString() + @"\." + filename + @"-" + i.ToString() + @".txt";
            }

            //open n FileStreams
            FileStream[] fsas = new FileStream[n];
            for (int i = 0; i < n; i++)
            {
                fsas[i] = File.Open(pathFor[i], FileMode.Open, FileAccess.Read, FileShare.None);
            }
            bool endOfData = false;

            //open file
            File.Delete(filename);
            using (FileStream fs = File.Open(filename, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                byte[] barray = new byte[n];

                while (endOfData == false)
                {
                    int dataLength = barray.Length;
                    for (int i = 0; i < n; i++)
                    {
                        byte[] b = new byte[1];
                        int rr = fsas[i].Read(b, 0, 1);
                        if (rr <= 0)
                        {
                            endOfData = true;
                            dataLength = i;
                            break;
                        }
                        barray[i] = b[0];
                    }

                    fs.Write(barray, 0, dataLength);
                }

                fs.Close();
            }

            //free streams
            for (int i = 0; i < n; i++)
            {
                fsas[i].Close();
                fsas[i].Dispose();
            }
            fsas = null;

            return 0;
        }
         */

        public static int Merge(string inputDirectoryPath, int n, string outputFilePath = "")
        {
            string filename = Path.GetFileName(outputFilePath);
            //create main folder
            string path = string.IsNullOrEmpty(inputDirectoryPath) ? @".\." + outputFilePath : inputDirectoryPath;
            string pathForBase = path + @"\." + filename + @"-";
            string[] pathFor = new string[n];
            for (int i = 0; i < n; i++)
            {
                pathFor[i] = pathForBase + i.ToString() + @"\." + filename + @"-" + i.ToString() + @".txt";
            }

            //open n FileStreams
            FileStream[] fsas = new FileStream[n];
            for (int i = 0; i < n; i++)
            {
                fsas[i] = File.Open(pathFor[i], FileMode.Open, FileAccess.Read, FileShare.None);
            }
            bool endOfData = false;

            //open file
            File.Delete(filename);
            using (FileStream fs = File.Open(outputFilePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                byte[] barray = new byte[n];

                while (endOfData == false)
                {
                    int dataLength = barray.Length;
                    for (int i = 0; i < n; i++)
                    {
                        byte[] b = new byte[1];
                        int rr = fsas[i].Read(b, 0, 1);
                        if (rr <= 0)
                        {
                            endOfData = true;
                            dataLength = i;
                            break;
                        }
                        barray[i] = b[0];
                    }

                    fs.Write(barray, 0, dataLength);
                }

                fs.Close();
            }

            //free streams
            for (int i = 0; i < n; i++)
            {
                fsas[i].Close();
                fsas[i].Dispose();
            }
            fsas = null;

            return 0;
        }

        public static int Base64File(string filename, string encryptedFilename = "")
        {
            int n = 1024;
            string destinationFilename = encryptedFilename == "" ? Convert.ToBase64String(Encoding.ASCII.GetBytes(filename)) : encryptedFilename;
            using (FileStream fshashed = File.Open(destinationFilename, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                using (FileStream fs = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] barray = new byte[n];
                    int rr = 0;
                    while ((rr = fs.Read(barray, 0, barray.Length)) > 0)
                    {
                        byte[] encrypted = Encoding.UTF8.GetBytes(Convert.ToBase64String(barray, 0, rr));

                        fshashed.Write(encrypted, 0, encrypted.Length);
                    }
                    fs.Close();
                }
                fshashed.Close();
            }


            return 0;
        }

        public static int Hash(string filename)
        {
            //TODO hashing
            /*SHA512 shaM = new SHA512Managed(); using (FileStream fshashed = File.Open(destinationFilename, FileMode.Open, FileAccess.Write, FileShare.None))
            {
                using (FileStream fs = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] barray = new byte[n];
                    //int rr = fs.Read(array, offset, n);
                    int rr = 0;
                    while ((rr = fs.Read(barray, 0, barray.Length)) > 0)
                    {
                        byte[] hashed = shaM.ComputeHash(barray);

                        fshashed.Write(hashed, 0, hashed.Length);
                    }
                    fs.Close();
                }
                fshashed.Close();
            }*/
            return 0;
        }
    }
}
