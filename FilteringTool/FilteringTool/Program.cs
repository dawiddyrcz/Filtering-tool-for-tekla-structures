/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Threading;
using System.Windows.Forms;

namespace FilteringTool
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            bool intoTekla = true;

            if (intoTekla)
            {
                if (new Tekla.Structures.Model.Model().GetConnectionStatus())
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    IntPtr h1;
                    try { h1 = Tekla.Structures.Dialog.MainWindow.Frame.Handle; } catch (Exception) { return; }
                    Form form1 = new UI.FilteringToolMainForm();
                    form1.Show(new WindowWrapper(h1));
                    Application.Run();
                }
                else
                {
                    MessageBox.Show("Could not find Tekla Structures process");
                    Application.Exit();
                }

            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new UI.FilteringToolMainForm());
            }
        }
    }

    public class WindowWrapper : System.Windows.Forms.IWin32Window
    {
        public WindowWrapper(IntPtr handle)
        {
            _hwnd = handle;
        }

        public IntPtr Handle
        {
            get { return _hwnd; }
        }

        private readonly IntPtr _hwnd;
    }
}