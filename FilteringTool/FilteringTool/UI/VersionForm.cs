/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    public partial class VersionForm : Form
    {
        private readonly string url = "";

        public VersionForm()
        {
            InitializeComponent();
            var assembly = Assembly.GetExecutingAssembly();
            var currentVersion = FileVersionInfo.GetVersionInfo(assembly.Location);
            version_label.Text = currentVersion.FileMajorPart + "." + currentVersion.FileMinorPart;

            //Removed version checking from public release
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(url) == false)
            {
                var linkForm = new LinkForm(url);
                linkForm.ShowDialog();
            }
        }
    }
}
