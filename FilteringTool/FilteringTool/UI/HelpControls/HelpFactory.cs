/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System.Collections.Generic;
using System.Windows.Forms;

namespace FilteringTool.UI.HelpControls
{
    internal class HelpFactory
    {
        internal List<UserControl> GetHelpControlsList()
        {
            var helpItems = new List<UserControl>();

            UserControl item1 = new Overview();
            helpItems.Add(item1);

            item1 = new ViewFilter();
            helpItems.Add(item1);

            item1 = new SelectionFilter();
            helpItems.Add(item1);

            item1 = new DisplaySettings();
            helpItems.Add(item1);

            item1 = new SelectAllUnselectAll();
            helpItems.Add(item1);

            item1 = new MultiSelect();
            helpItems.Add(item1);

            item1 = new SaveLoadAttributes();
            helpItems.Add(item1);

            item1 = new SetCurrentPhase();
            helpItems.Add(item1);

            item1 = new AddNewPhase();
            helpItems.Add(item1);

            item1 = new MoveObjectsToPhase();
            helpItems.Add(item1);

            item1 = new HideShowWindow();
            helpItems.Add(item1);

            item1 = new SmallWindowMode();
            helpItems.Add(item1);

            item1 = new ImportPhases();
            helpItems.Add(item1);

            item1 = new ExportPhases();
            helpItems.Add(item1);

            item1 = new WeldMinusOne();
            helpItems.Add(item1);

            item1 = new TaskbarShortcut();
            helpItems.Add(item1);

            item1 = new WeldMinusOne();
            helpItems.Add(item1);

            item1 = new NearestPlane();
            helpItems.Add(item1);

            item1 = new ObjectInfo();
            helpItems.Add(item1);

            return helpItems;
        }
    }
}