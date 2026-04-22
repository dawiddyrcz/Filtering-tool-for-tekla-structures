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

            var item1 = new Overview();
            helpItems.Add(item1);

            var item2 = new ViewFilter();
            helpItems.Add(item2);

            var item3 = new SelectionFilter();
            helpItems.Add(item3);

            var item4 = new DisplaySettings();
            helpItems.Add(item4);

            var item5 = new SelectAllUnselectAll();
            helpItems.Add(item5);

            var item6 = new MultiSelect();
            helpItems.Add(item6);

            var item7 = new SaveLoadAttributes();
            helpItems.Add(item7);

            var item8 = new SetCurrentPhase();
            helpItems.Add(item8);

            var item9 = new AddNewPhase();
            helpItems.Add(item9);

            var item10 = new MoveObjectsToPhase();
            helpItems.Add(item10);

            var item11 = new HideShowWindow();
            helpItems.Add(item11);

            var item12 = new SmallWindowMode();
            helpItems.Add(item12);

            var item13 = new ImportPhases();
            helpItems.Add(item13);

            var item14 = new ExportPhases();
            helpItems.Add(item14);

            var item15 = new WeldMinusOne();
            helpItems.Add(item15);

            var item16 = new NearestPlane();
            helpItems.Add(item16);

            var item17 = new ObjectInfo();
            helpItems.Add(item17);

            return helpItems;
        }
    }
}