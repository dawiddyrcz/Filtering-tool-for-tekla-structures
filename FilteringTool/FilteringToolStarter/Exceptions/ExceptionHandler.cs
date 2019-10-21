/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Windows.Forms;

namespace FilteringToolStarter.Exceptions
{
    class ExceptionHandler
    {
        private static readonly string ERROR_FILENAME = "lastFTStarterError.txt";

        public static void HandleException(Exception exception)
        {
            if (exception is FilteringToolStarterException)
            {
                MessageBox.Show(exception.Message, "Filtering tool starter");
            }
            else if (exception is FilteringToolStarterIOException)
            {
                string message = exception.Message + "\n\n" + exception.InnerException.ToString();
                MessageBox.Show(message);
                try
                {
                    System.IO.File.WriteAllText(ERROR_FILENAME, message);
                    MessageBox.Show("Error saved in file " + ERROR_FILENAME);
                }
                catch (Exception) { }
            }
            else
            {
                string message = exception.ToString();
                MessageBox.Show(message);
                try
                {
                    System.IO.File.WriteAllText(ERROR_FILENAME, message);
                    MessageBox.Show("Error saved in file " + ERROR_FILENAME);
                }
                catch (Exception) { }
            }

        }
    }
}
