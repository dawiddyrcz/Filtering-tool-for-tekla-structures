/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System.IO;

namespace FilteringTool
{
    /// <summary>Handle the name of current temp filter which is using in filtering tool.
    /// All users have unique temp filter name to avoid conflicts when they are working in the multi user mode</summary>
    internal class CurrentFilter
    {
        private const string BEGIN_OF_FILTER_NAME = "_currentFilter";

        /// <summary>Gets tempolary filter name for the current user</summary>
        public static string Name()
        {
            string userName = GetCurrentUserName();
            userName = RemoveInvalidChars(userName);

            return BEGIN_OF_FILTER_NAME + "_" + userName;
        }

        private static string GetCurrentUserName()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        private static string RemoveInvalidChars(string text)
        {
            text = text.Replace("\\", "_").Replace("/", "_");

            foreach (char invalidChar in Path.GetInvalidFileNameChars())
            {
                text = text.Replace(invalidChar.ToString(), string.Empty);
            }

            foreach (char invalidChar in Path.GetInvalidPathChars())
            {
                text = text.Replace(invalidChar.ToString(), string.Empty);
            }

            return text;
        }
    }
}
