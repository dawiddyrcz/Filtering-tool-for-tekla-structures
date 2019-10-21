/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

namespace FilteringTool.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Assembly")]
        public string CurrentFilterType {
            get {
                return ((string)(this["CurrentFilterType"]));
            }
            set {
                this["CurrentFilterType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AddWeldMinusOneFilter {
            get {
                return ((bool)(this["AddWeldMinusOneFilter"]));
            }
            set {
                this["AddWeldMinusOneFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AddComponentFilter {
            get {
                return ((bool)(this["AddComponentFilter"]));
            }
            set {
                this["AddComponentFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ChangeOnlySelectedViews {
            get {
                return ((bool)(this["ChangeOnlySelectedViews"]));
            }
            set {
                this["ChangeOnlySelectedViews"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowShowObjectInfoInTheBottomOfTeklaWindow {
            get {
                return ((bool)(this["ShowShowObjectInfoInTheBottomOfTeklaWindow"]));
            }
            set {
                this["ShowShowObjectInfoInTheBottomOfTeklaWindow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%NAME% %PROFILE%  %MATERIAL% %TOP_LEVEL_GLOBAL%/%BOTTOM_LEVEL_GLOBAL% Weight: %WE" +
            "IGHT% Class: %CLASS_ATTR% Phases: %PHASE%/%ASSEMBLY.PHASE%\r\n")]
        public string ObjectInfoPart {
            get {
                return ((string)(this["ObjectInfoPart"]));
            }
            set {
                this["ObjectInfoPart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Main profile: %MAINPART.PROFILE%  %MAINPART.MATERIAL%  Dim: %WIDTH% x %HEIGHT% x " +
            "%LENGTH% Weight: %WEIGHT% Phase: %PHASE%   Pos: %ASSEMBLY_POS%")]
        public string ObjectInfoAssembly {
            get {
                return ((string)(this["ObjectInfoAssembly"]));
            }
            set {
                this["ObjectInfoAssembly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Bolt size: %DIAMETER% Length: %LENGTH%  %TYPE%    %TYPE1%   %TYPE2% ")]
        public string ObjectInfoBolt {
            get {
                return ((string)(this["ObjectInfoBolt"]));
            }
            set {
                this["ObjectInfoBolt"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Name: %NAME%  Size: %SIZE%  Material: %MATERIAL% Weight: %WEIGHT% Class: %CLASS% " +
            "Phase: %PHASE%")]
        public string ObjectInfoRebar {
            get {
                return ((string)(this["ObjectInfoRebar"]));
            }
            set {
                this["ObjectInfoRebar"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1900-01-01")]
        public global::System.DateTime LastVersionCheck {
            get {
                return ((global::System.DateTime)(this["LastVersionCheck"]));
            }
            set {
                this["LastVersionCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1900-01-01")]
        public global::System.DateTime LastAdvertCheck {
            get {
                return ((global::System.DateTime)(this["LastAdvertCheck"]));
            }
            set {
                this["LastAdvertCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgradeRequired {
            get {
                return ((bool)(this["UpgradeRequired"]));
            }
            set {
                this["UpgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int FileMajorPartFromWebsite {
            get {
                return ((int)(this["FileMajorPartFromWebsite"]));
            }
            set {
                this["FileMajorPartFromWebsite"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int FileMinorPartFromWebsite {
            get {
                return ((int)(this["FileMinorPartFromWebsite"]));
            }
            set {
                this["FileMinorPartFromWebsite"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LinkToDownloadFromWebsite {
            get {
                return ((string)(this["LinkToDownloadFromWebsite"]));
            }
            set {
                this["LinkToDownloadFromWebsite"] = value;
            }
        }
    }
}
