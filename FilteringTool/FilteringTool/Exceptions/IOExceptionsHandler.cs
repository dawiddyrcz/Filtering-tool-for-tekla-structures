/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.IO;

namespace FilteringTool.Exceptions
{
    class IOExceptionsHandler
    {
        public static string GetMessage(Exception ex)
        {
            if (ex is FileNotFoundException)
            {
                return "The file cannot be found.";
            }
            else if (ex is DirectoryNotFoundException)
            {
                return "The directory cannot be found.";
            }
            else if (ex is DriveNotFoundException)
            {
                return "The drive specified in 'path' is invalid.";
            }
            else if (ex is PathTooLongException)
            {
                return "Path is to long - 'path' exceeds the maxium supported path length.";
            }
            else if (ex is UnauthorizedAccessException)
            {
                return "You do not have permission to create this file.";
            }
            else
            {
                if (ex.HResult == 32)
                {
                    return "There is a sharing violation.";
                }
                else if (ex.HResult == 80)
                {
                    return "The file already exists.";
                }
                else if (ex is IOException)
                {
                    return "UnknownIO Exception Error code: " + ex.HResult;
                }
            }
            return "";
        }
    }
}
