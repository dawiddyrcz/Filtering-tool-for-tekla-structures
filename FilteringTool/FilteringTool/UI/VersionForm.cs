/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    public partial class VersionForm : Form
    {
        string url = "";

        public VersionForm()
        {
            InitializeComponent();
            var assembly = Assembly.GetExecutingAssembly();
            var currentVersion = FileVersionInfo.GetVersionInfo(assembly.Location);
            version_label.Text = currentVersion.FileMajorPart + "." + currentVersion.FileMinorPart;

            var fileMajorPartFromWebsite = FTSettings.Settings.FileMajorPartFromWebsite;
            var fileMinorPartFromWebsite = FTSettings.Settings.FileMinorPartFromWebsite;

            newVersion_label.Text = fileMajorPartFromWebsite + "." + fileMinorPartFromWebsite;
            url = FTSettings.Settings.LinkToDownloadFromWebsite;
            linkLabel1.Text = url;

            if (fileMajorPartFromWebsite > currentVersion.FileMajorPart |
            (fileMajorPartFromWebsite == currentVersion.FileMajorPart & fileMinorPartFromWebsite > currentVersion.FileMinorPart))
            {
                info_label.Text = "New version is avaiable";
                info_label.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                info_label.Text = "Your program is up to date";
                info_label.ForeColor = System.Drawing.Color.Green;
            }
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
