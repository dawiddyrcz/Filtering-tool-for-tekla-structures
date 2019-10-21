/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Collections.Generic;
using System.IO;
using TSM = Tekla.Structures.Model;

namespace FilteringTool
{
    /// <summary>Allow user to save and load the lists of checked phases. User can save the list for the future usage. 
    /// Lists are saved in the attributes folder in current opened tekla strucutres model. 
    /// It works like attributes in every tekla structures window</summary>
    public class CheckedPhasesAttributes
    {
        private const string ATTRIBUTE_FILE_EXTENSION = ".afvf";
        private const string ATTRIBUTE_DIRECTORY_NAME = "attributes";

        private TSM.Model model = new TSM.Model();

        ///<summary>Saves list of phases to the file in tekla structures model in the attributes folder</summary>
        ///<param name="attributeName">File name without extension</param>
        ///<param name="checkedItems">List with phase numbers</param>
        ///<exception cref="Exceptions.FilteringToolException"></exception>
        public void SaveAttributeFile(string attributeName, List<int> checkedItems)
        {
            FileStream fileStream = null;
            StreamWriter file = null;
            try
            {
                var filePath = Path.Combine(GetAttributePath(), attributeName + ATTRIBUTE_FILE_EXTENSION);
                fileStream = new FileStream(filePath, FileMode.Create);
                file = new StreamWriter(fileStream);

                foreach (var item in checkedItems)
                {
                    file.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                string message = "Could not save attribute file: " + attributeName;
                message = message + "\n\n" + Exceptions.IOExceptionsHandler.GetMessage(ex);
                throw new Exceptions.FilteringToolException(message, ex);
            }
            finally
            {
                if (file != null) file.Close();
                if (fileStream != null) fileStream.Close();
            }
        }

        ///<summary>Loads phase list from the attribute file</summary>
        ///<param name="attributeName">File name without extension</param>
        ///<exception cref="Exceptions.FilteringToolException"></exception>
        public List<int> GetCheckedPhasesFromAttributeFile(string attributeName)
        {
            var phaseList = new System.Collections.Generic.List<int>();

            FileStream fileStream = null;
            StreamReader file = null;
            try
            {
                var filePath = Path.Combine(GetAttributePath(), attributeName + ATTRIBUTE_FILE_EXTENSION);
                fileStream = new FileStream(filePath, FileMode.Open);
                file = new StreamReader(fileStream);

                while (!file.EndOfStream)
                {
                    var line = file.ReadLine();

                    if (int.TryParse(line, out int phaseNumber))
                    {
                        phaseList.Add(phaseNumber);
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Could not load values from attribute file: " + attributeName;
                message = message + "\n\n" + Exceptions.IOExceptionsHandler.GetMessage(ex);
                throw new Exceptions.FilteringToolException(message, ex);
            }
            finally
            {
                if (file != null) file.Close();
                if (fileStream != null) fileStream.Close();
            }

            return phaseList;
        }

        /// <summary>Checks if attribute file exsists in tekla strucutres model in the attributes folder</summary>
        /// <param name="attributeName">File name without extension</param>
        /// <returns>True if exsists</returns>
        public bool FileExsist(string attributeName)
        {
            var filePath = Path.Combine(GetAttributePath(), attributeName + ATTRIBUTE_FILE_EXTENSION);
            return File.Exists(filePath);
        }

        ///<summary>Gets list with file names which contains saved phase lists from opened tekla structures model</summary>
        ///<exception cref="Exceptions.FilteringToolException"></exception>
        public List<string> GetAllAttributeFileNames()
        {
            var retList = new List<string>();
            var atrDirectory = GetAttributePath();
            try
            {
                string[] filePathes = Directory.GetFiles(atrDirectory, "*" + ATTRIBUTE_FILE_EXTENSION);

                foreach (string filePath in filePathes)
                {
                    retList.Add(Path.GetFileNameWithoutExtension(filePath));
                }
            }
            catch (Exception ex)
            {
                string message = "Could not get attribute files from directory:  " + atrDirectory;
                message = message + "\n\n" + Exceptions.IOExceptionsHandler.GetMessage(ex);
                throw new Exceptions.FilteringToolException(message, ex);
            }
            return retList;
        }

        ///<summary>Deletes file with phase list from attributes folder in the opened tekla strucutres model</summary>
        ///<param name="attributeName">File name witout extension</param>
        ///<exception cref="Exceptions.FilteringToolException"></exception>
        public void DeleteAttributeFile(string attributeName)
        {
            try
            {
                var filePath = Path.Combine(GetAttributePath(), attributeName + ATTRIBUTE_FILE_EXTENSION);
                File.Delete(filePath);
            }
            catch (Exception ex)
            {
                string message = "Could not delete attribute file: " + attributeName;
                message = message + "\n\n" + Exceptions.IOExceptionsHandler.GetMessage(ex);
                throw new Exceptions.FilteringToolException(message, ex);
            }
        }

        private string GetAttributePath()
        {
            return Path.Combine(model.GetInfo().ModelPath, ATTRIBUTE_DIRECTORY_NAME);
        }
    }
}
