﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace log4net.Async.Resources {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("log4net.Async.Resources.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to &apos;Appender&apos; property is null.
        /// </summary>
        internal static string AsyncAppenderIsNull {
            get {
                return ResourceManager.GetString("AsyncAppenderIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Asynchronous logging file appender accepts only prepared strings!.
        /// </summary>
        internal static string AsyncFileAppenderInvalidOperation {
            get {
                return ResourceManager.GetString("AsyncFileAppenderInvalidOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;Layout&apos; property is null.
        /// </summary>
        internal static string AsyncLayoutIsNull {
            get {
                return ResourceManager.GetString("AsyncLayoutIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Asynchronous logging queue overflow (contains {0} items)!.
        /// </summary>
        internal static string AsyncQueueOverflow {
            get {
                return ResourceManager.GetString("AsyncQueueOverflow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;Strategy&apos; property is null.
        /// </summary>
        internal static string AsyncStrategyIsNull {
            get {
                return ResourceManager.GetString("AsyncStrategyIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot close log file - {0}.
        /// </summary>
        internal static string CloseFileError {
            get {
                return ResourceManager.GetString("CloseFileError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log file name is null or empty.
        /// </summary>
        internal static string FileNameIsNullOrEmpty {
            get {
                return ResourceManager.GetString("FileNameIsNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot open log file - {0}.
        /// </summary>
        internal static string OpenFileError {
            get {
                return ResourceManager.GetString("OpenFileError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrapped &apos;Appender&apos; property is null.
        /// </summary>
        internal static string WrappedAppenderIsNull {
            get {
                return ResourceManager.GetString("WrappedAppenderIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrapped &apos;Layout&apos; property is null.
        /// </summary>
        internal static string WrappedLayoutIsNull {
            get {
                return ResourceManager.GetString("WrappedLayoutIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot write into the log file - {0}.
        /// </summary>
        internal static string WriteFileError {
            get {
                return ResourceManager.GetString("WriteFileError", resourceCulture);
            }
        }
    }
}
