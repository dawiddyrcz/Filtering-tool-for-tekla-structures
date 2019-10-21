/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    public partial class HelpForm : Form
    {
        private List<UserControl> helpItems;
        int currentIndex = 0;

        public HelpForm()
        {
            InitializeComponent();
            GenerateHelpItems();
            ShowItem(currentIndex);
            GenerateListBox();
        }

        private void GenerateListBox()
        {
            listBox.Items.Clear();
            foreach (UserControl item in helpItems)
            {
                listBox.Items.Add(item.Text);
            }
        }

        private void ShowItem(int index)
        {
            if (index >= 0 & index < helpItems.Count)
            {
                foreach (Control control in help_panel.Controls)
                {
                    control.Hide();
                }

                helpItems[index].Show();
                helpItems[index].BringToFront();
                help_panel.AutoScrollMinSize = new Size(helpItems[index].Size.Width + 10, helpItems[index].Size.Height + 10);
                help_panel.Refresh();
            }
        }

        private void GenerateHelpItems()
        {
            var helpBuilder = new HelpControls.HelpFactory();
            helpItems = helpBuilder.GetHelpControlsList();

            foreach (var item in helpItems)
            {
                //item.Dock = DockStyle.Fill;
                item.Parent = help_panel;
                item.Show();
            }
        }

        private void Previous_button_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0) currentIndex = 0;
            listBox.SelectedIndex = currentIndex;
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= helpItems.Count) currentIndex = helpItems.Count - 1;
            listBox.SelectedIndex = currentIndex;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIndex = listBox.SelectedIndex;
            ShowItem(listBox.SelectedIndex);
        }
    }
}
