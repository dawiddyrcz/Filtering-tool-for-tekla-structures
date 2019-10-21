/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.IO;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    public partial class LicenseForm : Form
    {
        public LicenseForm()
        {
            InitializeComponent();
            try
            {
                string text = File.ReadAllText("License.txt");
                richTextBox1.Text = text;
            }
            catch (Exception ex)
            {
                richTextBox1.Text = "ERROR LOADING LICENSE FILE (License.txt)\n\n" + ex.ToString();
            }
        }
    }
}
