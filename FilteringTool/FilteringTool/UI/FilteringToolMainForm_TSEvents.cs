/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Drawing;
using System.Windows.Forms;
using Tekla.Structures.Model;

namespace FilteringTool.UI
{
    partial class FilteringToolMainForm : Form
    {
        private void MainFormFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (new Model().GetConnectionStatus())
            {
                _events = new Events();
                RegisterEventHandler();
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            if (_events != null)
            {
                UnRegisterEventHandler(); ;
            }
            base.OnClosed(e);
        }

        private Events _events = null;

        private object _tsExitEventHandlerLock = new object();

        public void RegisterEventHandler()
        {
            _events.TeklaStructuresExit += Events_TeklaExitEvent;
            _events.ModelLoad += Events_TeklaLoadModel;

#pragma warning disable CS0618 // Type or member is obsolete
            _events.ModelChanged += Events_TeklaDatabaseCommit; //Filtering tool should work on the old and new Tekla programs
#pragma warning restore CS0618 // Type or member is obsolete

            _events.SelectionChange += Events_SelectionChange;
            _events.Register();
        }

        public void UnRegisterEventHandler()
        {
            if (_events != null) _events.UnRegister();
        }

        private void Events_TeklaExitEvent()
        {
            lock (_tsExitEventHandlerLock)
            {
                Application.Exit();
            }
        }

        private object _tsLoadModelEventHandlerLock = new object();

        private void Events_TeklaLoadModel()
        {
            lock (_tsLoadModelEventHandlerLock)
            {
                BeginInvoke(new MethodInvoker(() =>
                {
                    RefreshPhases();
                    RefreshAttributesList(true);
                }));

            }
        }

        private object _tsTeklaDatabaseCommitEventHandlerLock = new object();

        private void Events_TeklaDatabaseCommit()
        {
            lock (_tsTeklaDatabaseCommitEventHandlerLock)
            {
                if (view_checkedListBox.PhasesChanged())
                {
                    BeginInvoke(new MethodInvoker(() =>
                    {
                        RefreshPhases();
                    }));
                }
            }
        }

        private object _tsTeklaSelectionChangeLock = new object();

        private void Events_SelectionChange()
        {
            lock (_tsTeklaSelectionChangeLock)
            {
                string newText = "";
                var selectedObjects = new Tekla.Structures.Model.UI.ModelObjectSelector().GetSelectedObjects();

                if (selectedObjects.MoveNext())
                {
                    newText = TeklaObjects.TeklaObject.GetInfo(selectedObjects.Current);
                }
                if (newText.Equals("")) return;

                BeginInvoke(new MethodInvoker(() =>
                {
                    this.objectInfo_label.Text = newText;
                    this.objectInfo_label.ForeColor = SystemColors.ControlText;

                    if (FTSettings.Settings.ShowShowObjectInfoInTheBottomOfTeklaWindow & string.IsNullOrWhiteSpace(newText) == false)
                        Tekla.Structures.Model.Operations.Operation.DisplayPrompt("Filtering Tool info:     " + newText);
                }));
            }
        }

        private void AddErrorMessageToObjectInfo(string message)
        {
            this.objectInfo_label.Text = "Error: " + message;
            this.objectInfo_label.ForeColor = Color.Red;

            if (FTSettings.Settings.ShowShowObjectInfoInTheBottomOfTeklaWindow & string.IsNullOrWhiteSpace(message) == false)
                Tekla.Structures.Model.Operations.Operation.DisplayPrompt("Filtering Tool ERROR:  " + message);
        }
    }
}
