/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;

namespace FilteringTool.FTSettings
{
    public class Settings
    {
        public static FilterType CurrentFilterType { get; set; }
        public static bool AddWeldMinusOneFilter { get; set; }
        public static bool AddComponentFilter { get; set; }
        public static bool ChangeOnlySelectedViews { get; set; }
        public static bool ShowShowObjectInfoInTheBottomOfTeklaWindow { get; set; }

        public static string ObjectInfoPart { get; set; }
        public static string ObjectInfoAssembly { get; set; }
        public static string ObjectInfoBolt { get; set; }
        public static string ObjectInfoRebar { get; set; }

        public static DateTime LastVersionCheck { get; set; }
        public static DateTime LastAdvertCheck { get; set; }

        public static int FileMajorPartFromWebsite { get; set; }
        public static int FileMinorPartFromWebsite { get; set; }
        public static string LinkToDownloadFromWebsite { get; set; }
        
        static Settings()
        {
            Properties.Settings.Default.Reload();

            if (Properties.Settings.Default.UpgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeRequired = false;
                Properties.Settings.Default.Save();
            }

            AddComponentFilter = Properties.Settings.Default.AddComponentFilter;
            AddWeldMinusOneFilter = Properties.Settings.Default.AddWeldMinusOneFilter;
            ChangeOnlySelectedViews = Properties.Settings.Default.ChangeOnlySelectedViews;
            ShowShowObjectInfoInTheBottomOfTeklaWindow = Properties.Settings.Default.ShowShowObjectInfoInTheBottomOfTeklaWindow;

            ObjectInfoPart = Properties.Settings.Default.ObjectInfoPart;
            ObjectInfoAssembly = Properties.Settings.Default.ObjectInfoAssembly;
            ObjectInfoBolt = Properties.Settings.Default.ObjectInfoBolt;
            ObjectInfoRebar = Properties.Settings.Default.ObjectInfoRebar;

            LastVersionCheck = Properties.Settings.Default.LastVersionCheck;
            LastAdvertCheck = Properties.Settings.Default.LastAdvertCheck;

            FileMajorPartFromWebsite = Properties.Settings.Default.FileMajorPartFromWebsite;
            FileMinorPartFromWebsite = Properties.Settings.Default.FileMinorPartFromWebsite;
            LinkToDownloadFromWebsite = Properties.Settings.Default.LinkToDownloadFromWebsite;

            var propFilterType = Properties.Settings.Default.CurrentFilterType;

            if (propFilterType.Equals(FilterType.Assembly.ToString()))
                CurrentFilterType = FilterType.Assembly;
            else if (propFilterType.Equals(FilterType.Bolt.ToString()))
                CurrentFilterType = FilterType.Bolt;
            else if (propFilterType.Equals(FilterType.Object.ToString()))
                CurrentFilterType = FilterType.Object;
            else if (propFilterType.Equals(FilterType.Part.ToString()))
                CurrentFilterType = FilterType.Part;
            else
                CurrentFilterType = FilterType.Assembly;
        }

        public static void Save()
        {
            Properties.Settings.Default.AddComponentFilter = AddComponentFilter;
            Properties.Settings.Default.AddWeldMinusOneFilter = AddWeldMinusOneFilter;
            Properties.Settings.Default.CurrentFilterType = CurrentFilterType.ToString();
            Properties.Settings.Default.ChangeOnlySelectedViews = ChangeOnlySelectedViews;
            Properties.Settings.Default.ShowShowObjectInfoInTheBottomOfTeklaWindow = ShowShowObjectInfoInTheBottomOfTeklaWindow;
            Properties.Settings.Default.ObjectInfoPart = ObjectInfoPart;
            Properties.Settings.Default.ObjectInfoAssembly = ObjectInfoAssembly;
            Properties.Settings.Default.ObjectInfoBolt = ObjectInfoBolt;
            Properties.Settings.Default.ObjectInfoRebar = ObjectInfoRebar;
            Properties.Settings.Default.LastVersionCheck = LastVersionCheck;
            Properties.Settings.Default.LastAdvertCheck = LastAdvertCheck;
            Properties.Settings.Default.FileMajorPartFromWebsite = FileMajorPartFromWebsite;
            Properties.Settings.Default.FileMinorPartFromWebsite = FileMinorPartFromWebsite;
            Properties.Settings.Default.LinkToDownloadFromWebsite = LinkToDownloadFromWebsite;

            Properties.Settings.Default.Save();
        }
    }
}

