﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoE_Chaos_Helper.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string POESESSID {
            get {
                return ((string)(this["POESESSID"]));
            }
            set {
                this["POESESSID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string League {
            get {
                return ((string)(this["League"]));
            }
            set {
                this["League"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AccountName {
            get {
                return ((string)(this["AccountName"]));
            }
            set {
                this["AccountName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int TabIndex {
            get {
                return ((int)(this["TabIndex"]));
            }
            set {
                this["TabIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("14")]
        public int MaxSets {
            get {
                return ((int)(this["MaxSets"]));
            }
            set {
                this["MaxSets"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string FilterPath {
            get {
                return ((string)(this["FilterPath"]));
            }
            set {
                this["FilterPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("16, 126")]
        public global::System.Drawing.Point OverlayLocation {
            get {
                return ((global::System.Drawing.Point)(this["OverlayLocation"]));
            }
            set {
                this["OverlayLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("635, 635")]
        public global::System.Drawing.Size OverlaySize {
            get {
                return ((global::System.Drawing.Size)(this["OverlaySize"]));
            }
            set {
                this["OverlaySize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Show</string>
  <string>SetBorderColor 50 130 165 255</string>
  <string>SetFontSize 45</string>
  <string>SetTextColor 50 130 165 255</string>
  <string>SetBackgroundColor 255 255 255 255</string>
  <string>PlayAlertSound 1 300</string>
  <string>PlayEffect Red</string>
  <string>MinimapIcon 0 Red Cross</string>
  <string>Rarity = Rare</string>
  <string>Identified False</string>
  <string>ItemLevel &gt;= 60</string>
  <string>ItemLevel &lt;= 74</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection FilterTemplate {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["FilterTemplate"]));
            }
            set {
                this["FilterTemplate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OverlayBorder {
            get {
                return ((bool)(this["OverlayBorder"]));
            }
            set {
                this["OverlayBorder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt + Shift + S")]
        public string OverlayHotkey {
            get {
                return ((string)(this["OverlayHotkey"]));
            }
            set {
                this["OverlayHotkey"] = value;
            }
        }
    }
}
