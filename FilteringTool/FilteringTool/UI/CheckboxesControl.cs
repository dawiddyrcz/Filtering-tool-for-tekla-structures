/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    public partial class CheckboxesControl : UserControl
    {
        private ViewDisplay viewDisplay = new ViewDisplay();
        private bool checkBoxesChanged = true;

        public Keys ModifierKey { get; set; } = Keys.Shift;
        public Action MouseRightClicked;
        public Action ToolTipPopup;

        public CheckboxesControl()
        {
            InitializeComponent();
        }

        public bool CheckboxesChanged() => checkBoxesChanged;

        public ViewDisplay GetViewDisplay() => viewDisplay;

        public void SetCheckboxChanged(bool value)
        {
            checkBoxesChanged = value;
        }

        private void RaiseMouseRightClickedEventIfRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                MouseRightClicked?.Invoke();
        }

        #region PRIVATE_METHODS

        void SelectCheck_checkBoxMouseDown(object sender, MouseEventArgs e)
        {
            this.grid_checkBox.Checked = true;
            this.lines_checkBox.Checked = true;
            this.points_checkBox.Checked = true;
            this.bolt_checkBox.Checked = true;
            this.component_checkBox.Checked = true;
            this.cut_checkBox.Checked = true;
            this.fitting_checkBox.Checked = true;
            this.weld_checkBox.Checked = true;
            this.holes_checkBox.Checked = true;
            this.rebars_checkBox.Checked = true;
            this.loads_checkBox.Checked = true;
            this.references_checkBox.Checked = true;
            this.pourBreaks_checkBox.Checked = true;
            this.parts_checkBox.Checked = true;
            this.surfaces_checkBox.Checked = true;
            this.planes_checkBox.Checked = true;
            this.points2_checkBox.Checked = true;
            this.bolt2_checkBox.Checked = true;
            this.component2_checkBox.Checked = true;
            this.cut2_checkBox.Checked = true;
            this.fitting2_checkBox.Checked = true;
            this.weld2_checkBox.Checked = true;
            this.holes2_checkBox.Checked = true;
            this.rebars2_checkBox.Checked = true;
            this.parts2_checkBox.Checked = true;
            this.planes2_checkBox.Checked = true;

        }

        void UnSelectCheck_checkBoxMouseDown(object sender, MouseEventArgs e)
        {
            this.grid_checkBox.Checked = false;
            this.lines_checkBox.Checked = false;
            this.points_checkBox.Checked = false;
            this.bolt_checkBox.Checked = false;
            this.component_checkBox.Checked = false;
            this.cut_checkBox.Checked = false;
            this.fitting_checkBox.Checked = false;
            this.weld_checkBox.Checked = false;
            this.holes_checkBox.Checked = false;
            this.rebars_checkBox.Checked = false;
            this.loads_checkBox.Checked = false;
            this.references_checkBox.Checked = false;
            this.pourBreaks_checkBox.Checked = false;
            this.parts_checkBox.Checked = false;
            this.surfaces_checkBox.Checked = false;
            this.planes_checkBox.Checked = false;
            this.points2_checkBox.Checked = false;
            this.bolt2_checkBox.Checked = false;
            this.component2_checkBox.Checked = false;
            this.cut2_checkBox.Checked = false;
            this.fitting2_checkBox.Checked = false;
            this.weld2_checkBox.Checked = false;
            this.holes2_checkBox.Checked = false;
            this.rebars2_checkBox.Checked = false;
            this.parts2_checkBox.Checked = false;
            this.planes2_checkBox.Checked = false;
        }

        void CheckBoxesChanged(object sender, EventArgs e)
        {
            this.checkBoxesChanged = true;

            //Double attributes (model and component)
            viewDisplay.BoltsInModel = this.bolt_checkBox.Checked;
            viewDisplay.BoltsInComponents = bolt2_checkBox.Checked;
            viewDisplay.ComponentSymbolsInModel = component_checkBox.Checked;
            viewDisplay.ComponentSymbolsInComponents = component2_checkBox.Checked;
            viewDisplay.CutsAndAddedMaterialsInModel = cut_checkBox.Checked;
            viewDisplay.CutsAndAddedMaterialsInComponents = cut2_checkBox.Checked;
            viewDisplay.FittingsInModel = fitting_checkBox.Checked;
            viewDisplay.FittingsInComponents = fitting2_checkBox.Checked;
            viewDisplay.HolesInModel = holes_checkBox.Checked;
            viewDisplay.HolesInComponents = holes2_checkBox.Checked;
            viewDisplay.WeldsInModel = weld_checkBox.Checked;
            viewDisplay.WeldsInComponents = weld2_checkBox.Checked;
            viewDisplay.ReinforcingBarsInModel = rebars_checkBox.Checked;
            viewDisplay.ReinforcingBarsInComponents = rebars2_checkBox.Checked;
            viewDisplay.PartsInModel = parts_checkBox.Checked;
            viewDisplay.PartsInComponents = parts2_checkBox.Checked;
            viewDisplay.ConstructionPlanesInModel = planes_checkBox.Checked;
            viewDisplay.ConstructionPlanesInComponents = planes2_checkBox.Checked;

            //Single attributes
            viewDisplay.Loads = loads_checkBox.Checked;
            viewDisplay.Grids = grid_checkBox.Checked;
            viewDisplay.Points = points_checkBox.Checked;
            viewDisplay.ConstructionLines = lines_checkBox.Checked;
            viewDisplay.SurfaceTreatmentAndSurfaces = surfaces_checkBox.Checked;
            viewDisplay.ReferenceObjects = references_checkBox.Checked;
            viewDisplay.PourBreaks = pourBreaks_checkBox.Checked;
        }

        #endregion

        #region DoubleCHeck

        private void TryDoubleCheck(CheckBox checkBox1, CheckBox checkBox2)
        {
            if (Control.ModifierKeys == this.ModifierKey)
            {
                if (!checkBox2.Checked)
                {
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                }
                checkBox2.Checked = checkBox1.Checked;
            }
        }

        private void Component_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(component_checkBox, component2_checkBox);

        private void Cut_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(cut_checkBox, cut2_checkBox);

        private void Fitting_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(fitting_checkBox, fitting2_checkBox);

        private void Planes_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(planes_checkBox, planes2_checkBox);

        private void Points_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(points_checkBox, points2_checkBox);

        private void Weld_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(weld_checkBox, weld2_checkBox);

        private void Bolt_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(bolt_checkBox, bolt2_checkBox);

        private void Holes_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(holes_checkBox, holes2_checkBox);

        private void Rebars_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(rebars_checkBox, rebars2_checkBox);

        private void Parts_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(parts_checkBox, parts2_checkBox);

        //2
        private void Component2_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(component2_checkBox, component_checkBox);

        private void Cut2_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(cut2_checkBox, cut_checkBox);

        private void Fitting2_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(fitting2_checkBox, fitting_checkBox);

        private void Planes2_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(planes2_checkBox, planes_checkBox);

        private void Points2_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(points2_checkBox, points_checkBox);

        private void Weld2_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(weld2_checkBox, weld_checkBox);

        private void Bolt2_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(bolt2_checkBox, bolt_checkBox);

        private void Holes2_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(holes2_checkBox, holes_checkBox);

        private void Rebars2_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(rebars2_checkBox, rebars_checkBox);

        private void Parts2_checkBox_MouseUp(object sender, MouseEventArgs e) => TryDoubleCheck(parts2_checkBox, parts_checkBox);

        #endregion

        #region LabelClick
        private void Component_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !component_checkBox.Checked;
            component_checkBox.Checked = value;

            if (Control.ModifierKeys == this.ModifierKey)
            {
                component2_checkBox.Checked = value;
            }
        }

        private void cut_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !cut_checkBox.Checked;
            cut_checkBox.Checked = value;

            if (Control.ModifierKeys == this.ModifierKey)
            {
                cut2_checkBox.Checked = value;
            }
        }

        private void fitting_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !fitting_checkBox.Checked;
            fitting_checkBox.Checked = value;

            if (Control.ModifierKeys == this.ModifierKey)
            {
                fitting2_checkBox.Checked = value;
            }
        }

        private void lines_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !lines_checkBox.Checked;
            lines_checkBox.Checked = value;
        }

        private void planes_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !planes_checkBox.Checked;
            planes_checkBox.Checked = value;

            if (Control.ModifierKeys == this.ModifierKey)
            {
                planes2_checkBox.Checked = value;
            }
        }

        private void points_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !points_checkBox.Checked;
            points_checkBox.Checked = value;

            if (Control.ModifierKeys == this.ModifierKey)
            {
                points2_checkBox.Checked = value;
            }
        }

        private void weld_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !weld_checkBox.Checked;
            weld_checkBox.Checked = value;

            if (Control.ModifierKeys == this.ModifierKey)
            {
                weld2_checkBox.Checked = value;
            }
        }

        private void bolt_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !bolt_checkBox.Checked;
            bolt_checkBox.Checked = value;

            if (Control.ModifierKeys == this.ModifierKey)
            {
                bolt2_checkBox.Checked = value;
            }
        }

        private void holes_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !holes_checkBox.Checked;
            holes_checkBox.Checked = value;

            if (Control.ModifierKeys == this.ModifierKey)
            {
                holes2_checkBox.Checked = value;
            }
        }

        private void rebars_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !rebars_checkBox.Checked;
            rebars_checkBox.Checked = value;

            if (Control.ModifierKeys == this.ModifierKey)
            {
                rebars2_checkBox.Checked = value;
            }
        }

        private void parts_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !parts_checkBox.Checked;
            parts_checkBox.Checked = value;

            if (Control.ModifierKeys == this.ModifierKey)
            {
                parts2_checkBox.Checked = value;
            }
        }

        private void grid_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !grid_checkBox.Checked;
            grid_checkBox.Checked = value;
        }

        private void loads_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !loads_checkBox.Checked;
            loads_checkBox.Checked = value;
        }

        private void surfaces_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !surfaces_checkBox.Checked;
            surfaces_checkBox.Checked = value;
        }

        private void pourBreaks_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !pourBreaks_checkBox.Checked;
            pourBreaks_checkBox.Checked = value;
        }

        private void references_label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke();
                return;
            }

            bool value = !references_checkBox.Checked;
            references_checkBox.Checked = value;
        }

        #endregion
        private void ToolTip1_Popup(object sender, PopupEventArgs e) => ToolTipPopup?.Invoke();

        public override Size GetPreferredSize(Size proposedSize)
        {
            return tableLayoutPanel1.GetPreferredSize(proposedSize);
        }

    }
}
