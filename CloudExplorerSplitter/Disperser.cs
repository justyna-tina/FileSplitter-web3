using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CloudExplorerSplitter
{
    public class Disperser
    {
        public static int CreateConfigFile(string dirPath, int n, List<string> virtualDirectoryNames, List<string> virtualDirectoryPaths)
        {
            string dirPathWithoutDirectory = Path.GetDirectoryName(dirPath);
            string dirName = Path.GetFileName(dirPath);
            //create main folder
            string configFilePath = dirPathWithoutDirectory + @"\." + dirName + @".config";

            ConfigFile configFileObject = new ConfigFile(dirPath, n, virtualDirectoryNames, virtualDirectoryPaths);

            Disperser.WriteToXmlFile<ConfigFile>(configFilePath, configFileObject, false);

            return 0;
        }

        /// <summary>
        /// Writes the given object instance to an XML file.
        /// <para>Only Public properties and variables will be written to the file. These can be any type though, even other classes.</para>
        /// <para>If there are public properties/variables that you do not want written to the file, decorate them with the [XmlIgnore] attribute.</para>
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter(filePath, append);
                serializer.Serialize(writer, objectToWrite);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>
        /// Reads an object instance from an XML file.
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object to read from the file.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the XML file.</returns>
        public static T ReadFromXmlFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader(filePath);
                return (T)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public static int Disperse(string dirPath, int n, List<string> virtualDirectoryNames)
        {
            string dirPathWithoutDirectory = Path.GetDirectoryName(dirPath);
            string dirName = Path.GetFileName(dirPath);
            //create main folder
            string path = dirPathWithoutDirectory + @"\." + dirName;
            Splitter.CreateDirectory(path);

            string pathForBase = path + @"\";
            foreach (var virtualDirectoryName in virtualDirectoryNames)
            {
                Splitter.CreateDirectory(pathForBase + virtualDirectoryName);
            }

            //TODO: check 2 version of Split
            //Split(string filePath, int n, List<string> outputFilePaths);

            //empty files
            /*for (int i = 0; i < n; i++)
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
