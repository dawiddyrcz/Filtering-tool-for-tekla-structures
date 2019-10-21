/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.IO;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    public partial class ReleaseNoteForm : Form
    {
        public ReleaseNoteForm()
        {
            InitializeComponent();
            try
            {
                string text = File.ReadAllText("ReleaseNote.txt");
                richTextBox1.Text = text;
            }
            catch (Exception ex)
            {
                richTextBox1.Text = "ERROR LOADING LICENSE FILE (ReleaseNote.txt)\n\n" + ex.ToString();
            }
        }
    }
}
