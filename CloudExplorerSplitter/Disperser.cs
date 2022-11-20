using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CloudExplorerSplitter
{
    public class Disperser
    {
        public static int CreateConfigFile(string dirPath, string splitedDirPath, int n, List<string> virtualDirectoryNames, List<string> virtualDirectoryPaths)
        {
            string dirPathWithoutDirectory = Path.GetDirectoryName(dirPath);
            string dirName = Path.GetFileName(dirPath);
            //create main folder
            string configFilePath = dirPathWithoutDirectory + @"\." + dirName + @".config";

            ConfigFile configFileObject = new ConfigFile(dirPath, splitedDirPath, n, virtualDirectoryNames, virtualDirectoryPaths);

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

            string[] subdirectories = Directory.GetDirectories(dirPath);
            foreach (string subdirectory in subdirectories)
            {
                List<string> virtualDirectoryPathAndNames = new List<string>();
                Dictionary<string, string> splitedDirectoryNamesDict = Splitter.SplitNameWithKeyNames(Path.GetFileName(subdirectory), n, virtualDirectoryNames);
                Dictionary<string, string> destinationSubdirectoryPath = Splitter.SplitNameWithKeyNames(Path.GetFileName(subdirectory), n, virtualDirectoryNames);
                foreach (var virtualDirectoryName in virtualDirectoryNames)
                {
                    //virtualDirectoryPathAndNames.Add(path + @"\" + virtualDirectoryName + @"\" + Path.GetFileName(subdirectory));
                    virtualDirectoryPathAndNames.Add(path + @"\" + virtualDirectoryName + @"\" + splitedDirectoryNamesDict[virtualDirectoryName]);
                    destinationSubdirectoryPath[virtualDirectoryName] = @"";
                }

                //DisperseSubdirectory(dirPath, Path.GetFileName(subdirectory), n, virtualDirectoryNames);
                DisperseSubdirectory2(dirPath, @"", Path.GetFileName(subdirectory), destinationSubdirectoryPath, splitedDirectoryNamesDict, n, virtualDirectoryNames);
            }

            string[] fileNames = Directory.GetFiles(dirPath);
            foreach (string filename in fileNames)
            {
                List<string> virtualDirectoryPathAndNames = new List<string>();
                Dictionary<string, string> splitedNamesDict = Splitter.SplitNameWithKeyNames(Path.GetFileName(filename), n, virtualDirectoryNames);
                foreach (var virtualDirectoryName in virtualDirectoryNames)
                {
                    virtualDirectoryPathAndNames.Add(path + @"\" + virtualDirectoryName + @"\" + splitedNamesDict[virtualDirectoryName]);
                }

                Splitter.Split(filename, n, virtualDirectoryPathAndNames);
            }

            return 0;
        }

        public static int DisperseSubdirectory(string dirPath, string subdirectoryPath, int n, List<string> virtualDirectoryNames)
        {
            string sourceDirPath = dirPath + @"\" + subdirectoryPath;

            string dirPathWithoutDirectory = Path.GetDirectoryName(dirPath);
            string dirName = Path.GetFileName(dirPath);
            //create main folder
            string path = dirPathWithoutDirectory + @"\." + dirName;
            //Splitter.CreateDirectory(path);

            string pathForBase = path + @"\";
            foreach (var virtualDirectoryName in virtualDirectoryNames)
            {
                Splitter.CreateDirectory(pathForBase + virtualDirectoryName + @"\" + subdirectoryPath);//TODO: directory name change here
            }

            string[] subdirectories = Directory.GetDirectories(sourceDirPath);
            foreach (string subdirectory in subdirectories)
            {
                List<string> virtualDirectoryPathAndNames = new List<string>();
                foreach (var virtualDirectoryName in virtualDirectoryNames)
                {
                    virtualDirectoryPathAndNames.Add(path + @"\" + virtualDirectoryName + @"\" + subdirectoryPath + @"\" + Path.GetFileName(subdirectory));
                }

                DisperseSubdirectory(dirPath, subdirectoryPath + @"\" + Path.GetFileName(subdirectory), n, virtualDirectoryNames);
            }

            string[] fileNames = Directory.GetFiles(sourceDirPath);
            foreach (string filename in fileNames)
            {
                List<string> virtualDirectoryPathAndNames = new List<string>();
                Dictionary<string, string> splitedNamesDict = Splitter.SplitNameWithKeyNames(Path.GetFileName(filename), n, virtualDirectoryNames);
                foreach (var virtualDirectoryName in virtualDirectoryNames)
                {
                    //virtualDirectoryPathAndNames.Add(path + @"\" + virtualDirectoryName + @"\" + subdirectoryPath + @"\" + Path.GetFileName(filename));//TODO: file name change here
                    virtualDirectoryPathAndNames.Add(path + @"\" + virtualDirectoryName + @"\" + subdirectoryPath + @"\" + splitedNamesDict[virtualDirectoryName]);
                }

                Splitter.Split(filename, n, virtualDirectoryPathAndNames);
            }

            return 0;
        }

        public static int DisperseSubdirectory2(string dirPath, string sourceSubdirectoryPath, string sourceSubdirectory, Dictionary<string, string> destinationSubdirectoryPath, Dictionary<string, string> splitedSubdirectoryPath, int n, List<string> virtualDirectoryNames)
        {
            string sourceDirPath = dirPath + @"\" + sourceSubdirectoryPath + @"\" + sourceSubdirectory;
            string sourceSubdirectoryPathForNext = sourceSubdirectoryPath + @"\" + sourceSubdirectory;

            string dirPathWithoutDirectory = Path.GetDirectoryName(dirPath);
            string dirName = Path.GetFileName(dirPath);
            //create main folder
            string path = dirPathWithoutDirectory + @"\." + dirName;
            //Splitter.CreateDirectory(path);

            string pathForBase = path + @"\";
            foreach (var virtualDirectoryName in virtualDirectoryNames)
            {
                Splitter.CreateDirectory(pathForBase + virtualDirectoryName + @"\" + destinationSubdirectoryPath[virtualDirectoryName] + @"\" + splitedSubdirectoryPath[virtualDirectoryName]);//TODO: directory name change here
            }

            string[] subdirectories = Directory.GetDirectories(sourceDirPath);
            foreach (string subdirectory in subdirectories)
            {
                List<string> virtualDirectoryPathAndNames = new List<string>();
                Dictionary<string, string> splitedDirectoryNamesDict = Splitter.SplitNameWithKeyNames(Path.GetFileName(subdirectory), n, virtualDirectoryNames);
                Dictionary<string, string> destinationSubdirectoryPathInternal = Splitter.SplitNameWithKeyNames(Path.GetFileName(subdirectory), n, virtualDirectoryNames);
                foreach (var virtualDirectoryName in virtualDirectoryNames)
                {
                    virtualDirectoryPathAndNames.Add(path + @"\" + virtualDirectoryName + @"\" + splitedSubdirectoryPath[virtualDirectoryName] + @"\" + splitedDirectoryNamesDict[virtualDirectoryName]);
                    destinationSubdirectoryPathInternal[virtualDirectoryName] = destinationSubdirectoryPath[virtualDirectoryName];
                    destinationSubdirectoryPathInternal[virtualDirectoryName] += @"\" + splitedSubdirectoryPath[virtualDirectoryName];
                }

                //DisperseSubdirectory(dirPath, sourceSubdirectoryPath + @"\" + Path.GetFileName(subdirectory), n, virtualDirectoryNames);
                DisperseSubdirectory2(dirPath, sourceSubdirectoryPathForNext, Path.GetFileName(subdirectory), destinationSubdirectoryPathInternal, splitedDirectoryNamesDict, n, virtualDirectoryNames);
            }

            string[] fileNames = Directory.GetFiles(sourceDirPath);
            foreach (string filename in fileNames)
            {
                List<string> virtualDirectoryPathAndNames = new List<string>();
                Dictionary<string, string> splitedNamesDict = Splitter.SplitNameWithKeyNames(Path.GetFileName(filename), n, virtualDirectoryNames);
                foreach (var virtualDirectoryName in virtualDirectoryNames)
                {
                    //virtualDirectoryPathAndNames.Add(path + @"\" + virtualDirectoryName + @"\" + subdirectoryPath + @"\" + Path.GetFileName(filename));//TODO: file name change here
                    virtualDirectoryPathAndNames.Add(path + @"\" + virtualDirectoryName + @"\" + destinationSubdirectoryPath[virtualDirectoryName] + @"\" + splitedSubdirectoryPath[virtualDirectoryName] + @"\" + splitedNamesDict[virtualDirectoryName]);
                }

                Splitter.Split(filename, n, virtualDirectoryPathAndNames);
            }

            return 0;
        }

        public static int Concentrate(string configurationFilePath)
        {
            ConfigFile configFileObject = Disperser.ReadFromXmlFile<ConfigFile>(configurationFilePath);
            //TODO: check if main folder and n folders exist
            //TODO: don't get full path, because '-' char
            //try to concentrate filename
            string basePath = configFileObject.baseDestinationDirPath + @"\";
            string sourceDirPath = basePath + configFileObject.virtualDirectoryNames[0];
            List<string> virtualDirectoryNames = configFileObject.virtualDirectoryNames;

            string destinationBasePath = configFileObject.dirPath;

            //files
            string[] fileNames = Directory.GetFiles(sourceDirPath);
            foreach (string filename in fileNames)
            {
                //get the same part of filename
                string theSameFilenamePart = Path.GetFileName(filename).Split('-')[1];
                string searchPattern = @"*" + theSameFilenamePart + @"*";
                List<string> nPartFilenames = new List<string>();
                List<string> nPartFilePaths = new List<string>();
                for (int i = 0; i < configFileObject.n; i++)
                {
                    string[] tt = Directory.GetFiles(basePath + configFileObject.virtualDirectoryNames[i], searchPattern);
                    nPartFilenames.Add(Path.GetFileName(tt[0]));
                    nPartFilePaths.Add(tt[0]);
                }

                string concentratedFilename = Splitter.ConcentrateName(nPartFilenames);

                Splitter.Merge(nPartFilePaths, configFileObject.n, destinationBasePath + @"\" + concentratedFilename);
            }

            //directories
            string[] dirNames = Directory.GetDirectories(sourceDirPath);
            foreach (string dirName in dirNames)
            {
                //get the same part of filename
                string theSameFilenamePart = Path.GetFileName(dirName).Split('-')[1];
                string searchPattern = @"*" + theSameFilenamePart + @"*";
                List<string> nPartFilenames = new List<string>();
                for (int i = 0; i < configFileObject.n; i++)
                {
                    string[] tt = Directory.GetDirectories(basePath + configFileObject.virtualDirectoryNames[i], searchPattern);
                    nPartFilenames.Add(Path.GetFileName(tt[0]));
                }

                string concentratedDirname = Splitter.ConcentrateName(nPartFilenames);
                Splitter.CreateDirectory(destinationBasePath + @"\" + concentratedDirname);

                //jump into directory
                ConcentrateDirectory(concentratedDirname, destinationBasePath + @"\" + concentratedDirname, configFileObject.n, basePath, configFileObject.virtualDirectoryNames, nPartFilenames, destinationBasePath + @"\" + concentratedDirname);
            }
            
            return 0;
        }

        public static int ConcentrateDirectory(string directoryName, string directoryPath, int n, string sourceBasePath, List<string> sourceDirectoryNames, List<string> sourceAfterBasePath, string destinationDirectoryPath)
        {
            string source0DirPath = sourceBasePath + sourceDirectoryNames[0] + @"\" + sourceAfterBasePath[0];
            //files
            string[] fileNames = Directory.GetFiles(source0DirPath);
            foreach (string filename in fileNames)
            {
                //get the same part of filename
                string theSameFilenamePart = Path.GetFileName(filename).Split('-')[1];
                string searchPattern = @"*" + theSameFilenamePart + @"*";
                List<string> nPartFilenames = new List<string>();
                List<string> nPartFilePaths = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    string[] tt = Directory.GetFiles(sourceBasePath + sourceDirectoryNames[i] + @"\" + sourceAfterBasePath[i], searchPattern);
                    nPartFilenames.Add(Path.GetFileName(tt[0]));
                    nPartFilePaths.Add(tt[0]);
                }

                string concentratedFilename = Splitter.ConcentrateName(nPartFilenames);

                Splitter.Merge(nPartFilePaths, n, destinationDirectoryPath + @"\" + concentratedFilename);
            }

            //directories
            string[] dirNames = Directory.GetDirectories(source0DirPath);
            foreach (string dirName in dirNames)
            {
                List<string> sourceAfterBasePathActual = new List<string>();
                //get the same part of filename
                string theSameFilenamePart = Path.GetFileName(dirName).Split('-')[1];
                string searchPattern = @"*" + theSameFilenamePart + @"*";
                List<string> nPartFilenames = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    string[] tt = Directory.GetDirectories(sourceBasePath + sourceDirectoryNames[i] + @"\" + sourceAfterBasePath[i], searchPattern);
                    nPartFilenames.Add(Path.GetFileName(tt[0]));
                    sourceAfterBasePathActual.Add(sourceAfterBasePath[i] + @"\" + Path.GetFileName(tt[0]));
                }

                string concentratedDirname = Splitter.ConcentrateName(nPartFilenames);
                Splitter.CreateDirectory(destinationDirectoryPath + @"\" + concentratedDirname);

                //jump into directory
                ConcentrateDirectory(concentratedDirname, destinationDirectoryPath + @"\" + concentratedDirname, n, sourceBasePath, sourceDirectoryNames, sourceAfterBasePathActual, destinationDirectoryPath + @"\" + concentratedDirname);
            }

            return 0;
        }
    }
}
