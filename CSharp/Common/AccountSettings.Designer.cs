﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Batch.Samples.Common {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    public sealed partial class AccountSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static AccountSettings defaultInstance = ((AccountSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new AccountSettings())));
        
        public static AccountSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://(YourAccount).(region).batch.azure.com")] 
        public string BatchServiceUrl {
            get {
                return ((string)(this["BatchServiceUrl"]));
            }
            set {
                this["BatchServiceUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BatchAccountName {
            get {
                return ((string)(this["BatchAccountName"]));
            }
            set {
                this["BatchAccountName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BatchAccountKey {
            get {
                return ((string)(this["BatchAccountKey"]));
            }
            set {
                this["BatchAccountKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("core.windows.net")]
        public string StorageServiceUrl {
            get {
                return ((string)(this["StorageServiceUrl"]));
            }
            set {
                this["StorageServiceUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string StorageAccountName {
            get {
                return ((string)(this["StorageAccountName"]));
            }
            set {
                this["StorageAccountName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string StorageAccountKey {
            get {
                return ((string)(this["StorageAccountKey"]));
            }
            set {
                this["StorageAccountKey"] = value;
            }
        }
    }
}
