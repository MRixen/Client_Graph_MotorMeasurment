﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication6.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public int MAX_TABLE_AMOUNT {
            get {
                return ((int)(this["MAX_TABLE_AMOUNT"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int MIN_TABLE_AMOUNT {
            get {
                return ((int)(this["MIN_TABLE_AMOUNT"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.013")]
        public float SAMPLE_TIME {
            get {
                return ((float)(this["SAMPLE_TIME"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int DEFAULT_SAMPLE_TIME_FACTOR {
            get {
                return ((int)(this["DEFAULT_SAMPLE_TIME_FACTOR"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public int MAX_ALIVE_SIGNAL_PAUSE {
            get {
                return ((int)(this["MAX_ALIVE_SIGNAL_PAUSE"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\\\Users\\\\Manuel.Rixen\\\\Desktop\\\\")]
        public string FILE_SAVE_PATH {
            get {
                return ((string)(this["FILE_SAVE_PATH"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Manuel.Rixen\\Documen" +
            "ts\\GitHub\\DataBase\\DataBase\\Database2.mdf;Initial Catalog=Database2;Integrated S" +
            "ecurity=True")]
        public string ConnectionString_DataBase_RightLeg_extracted {
            get {
                return ((string)(this["ConnectionString_DataBase_RightLeg_extracted"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Manuel.Rixen\\Documen" +
            "ts\\GitHub\\DataBase\\DataBase\\Database1.mdf;Initial Catalog=Database1;Integrated S" +
            "ecurity=True")]
        public string ConnectionString_DataBase {
            get {
                return ((string)(this["ConnectionString_DataBase"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int sensorAmount {
            get {
                return ((int)(this["sensorAmount"]));
            }
        }
    }
}
