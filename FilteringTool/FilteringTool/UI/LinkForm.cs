/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    public partial class LinkForm : Form
    {
        private string url = "";

        public LinkForm(string url)
        {
            InitializeComponent();
            this.url = url;
            this.linkLabel1.Text = url;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink();
        }

        private void OpenLink_button_Click(object sender, EventArgs e)
        {
            OpenLink();
        }

        private void OpenLink()
        {
            try
            {
                System.Diagnostics.Process.Start(url);
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void CopyLink_button_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(url);
                this.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}
