/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }
        
        private void Youtube_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LinkForm(youtube_linkLabel.Text).ShowDialog();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LinkForm(linkLabel1.Text).ShowDialog();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LinkForm(linkLabel2.Text).ShowDialog();
        }
    }
}
