﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Asp.Versioning {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Asp.Versioning.SR", typeof(SR).Assembly);
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
        ///   Looks up a localized string similar to An API version is required, but was not specified..
        /// </summary>
        internal static string ApiVersionUnspecified {
            get {
                return ResourceManager.GetString("ApiVersionUnspecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Conventions cannot be added after building the endpoint..
        /// </summary>
        internal static string ConventionAddedAfterEndpointBuilt {
            get {
                return ResourceManager.GetString("ConventionAddedAfterEndpointBuilt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request type was not configured..
        /// </summary>
        internal static string RequestTypeUnconfigured {
            get {
                return ResourceManager.GetString("RequestTypeUnconfigured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must be specified to construct a {1}..
        /// </summary>
        internal static string UnsetRequestDelegate {
            get {
                return ResourceManager.GetString("UnsetRequestDelegate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HTTP resource that matches the request URI &apos;{0}&apos; does not support the API version &apos;{1}&apos;..
        /// </summary>
        internal static string VersionedResourceNotSupported {
            get {
                return ResourceManager.GetString("VersionedResourceNotSupported", resourceCulture);
            }
        }
    }
}
