﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace $safeprojectname$.Dialogs.NameAge.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class NameAgeStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal NameAgeStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("$safeprojectname$.Dialogs.NameAge.Resources.NameAgeStrings", typeof(NameAgeStrings).Assembly);
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
        ///   Looks up a localized string similar to Thank you {0} for providing your age {1}.
        /// </summary>
        internal static string ThankYou_NameAge {
            get {
                return ResourceManager.GetString("ThankYou_NameAge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thank you {0}, {1} from {2} for providing your information..
        /// </summary>
        internal static string ThankYou_NameAgeCountry {
            get {
                return ResourceManager.GetString("ThankYou_NameAgeCountry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are in the Name and Age dialog.
        /// </summary>
        internal static string Welcome {
            get {
                return ResourceManager.GetString("Welcome", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What&apos;s your age {0}?.
        /// </summary>
        internal static string WhatsAge_Name {
            get {
                return ResourceManager.GetString("WhatsAge_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What&apos;s your name?.
        /// </summary>
        internal static string WhatsName {
            get {
                return ResourceManager.GetString("WhatsName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You already provided your country: {0}, what&apos;s your name?.
        /// </summary>
        internal static string WhatsName_Country {
            get {
                return ResourceManager.GetString("WhatsName_Country", resourceCulture);
            }
        }
    }
}
