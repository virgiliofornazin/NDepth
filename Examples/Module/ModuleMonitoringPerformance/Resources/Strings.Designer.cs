﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NDepth.Examples.Module.ModuleMonitoringPerformance.Resources {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NDepth.Examples.Module.ModuleMonitoringPerformance.Resources.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to 99.99% observations less than = {0:F3}mcs.
        /// </summary>
        internal static string Histogram9999Message {
            get {
                return ResourceManager.GetString("Histogram9999Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 99% observations less than = {0:F3}mcs.
        /// </summary>
        internal static string Histogram99Message {
            get {
                return ResourceManager.GetString("Histogram99Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mean latency = {0:F3}mcs.
        /// </summary>
        internal static string HistogramMeanMessage {
            get {
                return ResourceManager.GetString("HistogramMeanMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}) {1:F3} - {2:F4} = {3}.
        /// </summary>
        internal static string HistogramPartMessage {
            get {
                return ResourceManager.GetString("HistogramPartMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid first argument! Provide items count per thread as a first application argument..
        /// </summary>
        internal static string InvalidArgumentCountPerThread {
            get {
                return ResourceManager.GetString("InvalidArgumentCountPerThread", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid second argument! Provide producers count as a second application argument..
        /// </summary>
        internal static string InvalidArgumentProducersCount {
            get {
                return ResourceManager.GetString("InvalidArgumentProducersCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was started on the machine &apos;{1}&apos;.
        /// </summary>
        internal static string ModuleStarted {
            get {
                return ResourceManager.GetString("ModuleStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press any key to stop....
        /// </summary>
        internal static string ModuleStopMessage {
            get {
                return ResourceManager.GetString("ModuleStopMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was stopped on the machine &apos;{1}&apos;.
        /// </summary>
        internal static string ModuleStopped {
            get {
                return ResourceManager.GetString("ModuleStopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Monitoring message {0} / {1}.
        /// </summary>
        internal static string MonitoringMessage {
            get {
                return ResourceManager.GetString("MonitoringMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generated {0} values in {1}ms (throughput = {2:F3} ops per second).
        /// </summary>
        internal static string ReportMessageGenerated {
            get {
                return ResourceManager.GetString("ReportMessageGenerated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stored {0} values in {1}ms (throughput = {2:F3} ops per second).
        /// </summary>
        internal static string ReportMessageTotal {
            get {
                return ResourceManager.GetString("ReportMessageTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: ModuleMonitoringPerformance.exe [CountPerThread] [ProducersCount] [ConsumersCount].
        /// </summary>
        internal static string UsageMessage {
            get {
                return ResourceManager.GetString("UsageMessage", resourceCulture);
            }
        }
    }
}
