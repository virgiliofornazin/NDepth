﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NDepth.Module.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NDepth.Module.Resources.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot get the current module path!.
        /// </summary>
        internal static string CurrentModulePathException {
            get {
                return ResourceManager.GetString("CurrentModulePathException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to localhost.
        /// </summary>
        internal static string DefaultMachineAddress {
            get {
                return ResourceManager.GetString("DefaultMachineAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local machine.
        /// </summary>
        internal static string DefaultMachineDescription {
            get {
                return ResourceManager.GetString("DefaultMachineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local.
        /// </summary>
        internal static string DefaultMachineName {
            get {
                return ResourceManager.GetString("DefaultMachineName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local module.
        /// </summary>
        internal static string DefaultModuleDescription {
            get {
                return ResourceManager.GetString("DefaultModuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module.
        /// </summary>
        internal static string DefaultModuleName {
            get {
                return ResourceManager.GetString("DefaultModuleName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1.0.0.0.
        /// </summary>
        internal static string DefaultModuleVersion {
            get {
                return ResourceManager.GetString("DefaultModuleVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module &apos;{0}:{1}&apos; was initialized from local &apos;machine.xml&apos;.
        /// </summary>
        internal static string ModuleInitializedFromLocalMachineXml {
            get {
                return ResourceManager.GetString("ModuleInitializedFromLocalMachineXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module &apos;{0}:{1}&apos; was initialized from &apos;module.xml&apos;.
        /// </summary>
        internal static string ModuleInitializedFromModuleXml {
            get {
                return ResourceManager.GetString("ModuleInitializedFromModuleXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module &apos;{0}:{1}&apos; was initialized from parent &apos;machine.xml&apos;.
        /// </summary>
        internal static string ModuleInitializedFromParentMachineXml {
            get {
                return ResourceManager.GetString("ModuleInitializedFromParentMachineXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unhandled exception.
        /// </summary>
        internal static string UnhandledException {
            get {
                return ResourceManager.GetString("UnhandledException", resourceCulture);
            }
        }
    }
}
