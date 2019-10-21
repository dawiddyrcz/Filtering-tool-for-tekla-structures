/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System.IO;

namespace FilteringToolStarter
{
    class DirecoryTools
    {
        ///<summary>Copy directory with subdirectories and all files</summary>
        ///<exception cref="PathTooLongException"></exception>
        ///<exception cref="System.ArgumentException"></exception>
        ///<exception cref="System.ArgumentNullException"></exception>
        ///<exception cref="System.IO.PathTooLongException"></exception>
        ///<exception cref="System.IO.DirectoryNotFoundException"></exception>
        ///<exception cref="System.IO.FileNotFoundException"></exception>
        ///<exception cref="System.IO.IOException"></exception>
        ///<exception cref="System.NotSupportedException"></exception>
        public static void CopyDir(string inputDir, string outputDir)
        {
            if (!Directory.Exists(inputDir)) throw new DirectoryNotFoundException(inputDir + " not exsist");
            if (!Directory.Exists(outputDir)) Directory.CreateDirectory(outputDir);
            var inputDirectoryInfo = new DirectoryInfo(inputDir);

            var filesToCopy = inputDirectoryInfo.GetFiles();
            foreach (var file in filesToCopy)
            {
                File.Copy(file.FullName, Path.Combine(outputDir, file.Name), true);
            }

            var directoriesToCopy = inputDirectoryInfo.GetDirectories();
            foreach (var directory in directoriesToCopy)
            {
                CopyDir(Path.Combine(inputDir, directory.Name), Path.Combine(outputDir, directory.Name));
            }
        }

        public static void DeleteDir(string inputDir)
        {
            if (!Directory.Exists(inputDir)) return;
            var inputDirectoryInfo = new DirectoryInfo(inputDir);

            var filesToDelete = inputDirectoryInfo.GetFiles();
            foreach (var file in filesToDelete)
            {
                File.Delete(file.FullName);
            }

            var directoriesToDelete = inputDirectoryInfo.GetDirectories();
            foreach (var directory in directoriesToDelete)
            {
                DeleteDir(Path.Combine(inputDir, directory.Name));
            }
        }
    }
}
