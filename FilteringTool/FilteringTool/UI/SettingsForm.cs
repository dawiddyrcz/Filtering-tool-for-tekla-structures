/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using FilteringTool.FTSettings;
using System;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            CheckRadioButton();
            weldFilter_checkBox.Checked = Settings.AddWeldMinusOneFilter;
            component_checkBox.Checked = Settings.AddComponentFilter;
            onlySelViews_checkBox.Checked = Settings.ChangeOnlySelectedViews;
            showObjectInfoInTekla_checkBox.Checked = Settings.ShowShowObjectInfoInTheBottomOfTeklaWindow;
            partInfo_textBox.Text = Settings.ObjectInfoPart;
            assemblyInfo_textBox.Text = Settings.ObjectInfoAssembly;
            boltInfo_textBox.Text = Settings.ObjectInfoBolt;
            rebarInfo_textBox.Text = Settings.ObjectInfoRebar;
        }

        private void CheckRadioButton()
        {
            switch (Settings.CurrentFilterType)
            {
                case FilterType.Object:
                    this.obj_radioButton.Checked = true;
                    this.part_radioButton.Checked = false;
                    this.assembly_radioButton.Checked = false;
                    this.bolt_radioButton.Checked = false;
                    break;
                case FilterType.Assembly:
                    this.obj_radioButton.Checked = false;
                    this.part_radioButton.Checked = false;
                    this.assembly_radioButton.Checked = true;
                    this.bolt_radioButton.Checked = false;
                    break;
                case FilterType.Part:
                    this.obj_radioButton.Checked = false;
                    this.part_radioButton.Checked = true;
                    this.assembly_radioButton.Checked = false;
                    this.bolt_radioButton.Checked = false;
                    break;
                case FilterType.Bolt:
                    this.obj_radioButton.Checked = false;
                    this.part_radioButton.Checked = false;
                    this.assembly_radioButton.Checked = false;
                    this.bolt_radioButton.Checked = true;
                    break;
            }
        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            if (this.assembly_radioButton.Checked) Settings.CurrentFilterType = FilterType.Assembly;
            else if (this.part_radioButton.Checked) Settings.CurrentFilterType = FilterType.Part;
            else if (this.obj_radioButton.Checked) Settings.CurrentFilterType = FilterType.Object;
            else if (this.bolt_radioButton.Checked) Settings.CurrentFilterType = FilterType.Bolt;

            Settings.AddComponentFilter = this.component_checkBox.Checked;
            Settings.AddWeldMinusOneFilter = this.weldFilter_checkBox.Checked;
            Settings.ChangeOnlySelectedViews = onlySelViews_checkBox.Checked;
            Settings.ShowShowObjectInfoInTheBottomOfTeklaWindow = showObjectInfoInTekla_checkBox.Checked;

            Settings.ObjectInfoPart = partInfo_textBox.Text;
            Settings.ObjectInfoAssembly = assemblyInfo_textBox.Text;
            Settings.ObjectInfoBolt = boltInfo_textBox.Text;
            Settings.ObjectInfoRebar = rebarInfo_textBox.Text;

            Settings.Save();
        }


    }
}
