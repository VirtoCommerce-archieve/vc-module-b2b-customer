﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtoCommerce.B2BCustomerModule.Core.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class B2BCustomerResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal B2BCustomerResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VirtoCommerce.B2BCustomerModule.Core.Resources.B2BCustomerResources", typeof(B2BCustomerResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contact adminisrator&apos;s email is not valid..
        /// </summary>
        public static string AdminEmailIsNotValid {
            get {
                return ResourceManager.GetString("AdminEmailIsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Company {0} already exists..
        /// </summary>
        public static string CompanyAlreadyExist {
            get {
                return ResourceManager.GetString("CompanyAlreadyExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Company {0} does not exist..
        /// </summary>
        public static string CompanyDoesNotExist {
            get {
                return ResourceManager.GetString("CompanyDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User with email {0} already registered..
        /// </summary>
        public static string EmailAlreadyUsed {
            get {
                return ResourceManager.GetString("EmailAlreadyUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified email is invalid..
        /// </summary>
        public static string EmailsIsNotValid {
            get {
                return ResourceManager.GetString("EmailsIsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must specify emails for which invitation will be send..
        /// </summary>
        public static string EmailsIsNullOrEmpty {
            get {
                return ResourceManager.GetString("EmailsIsNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must specify an existing company and the only one..
        /// </summary>
        public static string InvalidCompanyCount {
            get {
                return ResourceManager.GetString("InvalidCompanyCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must specify an unique email and the only one..
        /// </summary>
        public static string InvalidEmailCount {
            get {
                return ResourceManager.GetString("InvalidEmailCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your invite is revoked or invalid..
        /// </summary>
        public static string InvalidInvite {
            get {
                return ResourceManager.GetString("InvalidInvite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You&apos;ve registered by this invite already..
        /// </summary>
        public static string InviteAlreadyUsed {
            get {
                return ResourceManager.GetString("InviteAlreadyUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {{message}}&lt;br&gt;
        ///&lt;p&gt;You have been invited to register in {{store_name}} as {{company_name}} company member.&lt;/p&gt;
        ///&lt;p&gt;Go to &lt;strong&gt;&lt;a href=&quot;{{ url }}&quot;&gt;{{ url }}&lt;/a&gt;&lt;/strong&gt; to create your account.&lt;/p&gt;
        ///&lt;p&gt;If you are unable to click on the link above, simple copy the link and paste into the browser where you enter web addresses and press enter.&lt;br&gt;
        ///If you have any questions, please contact your company&apos;s account administrator, {{admin_name}} at {{admin_email}}.&lt;/p&gt;.
        /// </summary>
        public static string InviteEmailNotificationBody {
            get {
                return ResourceManager.GetString("InviteEmailNotificationBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invitation to join {{company_name}}..
        /// </summary>
        public static string InviteEmailNotificationSubject {
            get {
                return ResourceManager.GetString("InviteEmailNotificationSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You selected &lt;a href={{ product_url }}&gt;{{ product.name }}&lt;a/&gt;  from {{ store_name}} to send to this email..
        /// </summary>
        public static string ProductEmailNotificationBody {
            get {
                return ResourceManager.GetString("ProductEmailNotificationBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {{ store_name }}: {{ product.name }}.
        /// </summary>
        public static string ProductEmailNotificationSubject {
            get {
                return ResourceManager.GetString("ProductEmailNotificationSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to reCAPTCHA validation failed.
        /// </summary>
        public static string ReCaptchaValidationFailed {
            get {
                return ResourceManager.GetString("ReCaptchaValidationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Store {0} does not exist..
        /// </summary>
        public static string StoreDoesNotExist {
            get {
                return ResourceManager.GetString("StoreDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User {0} already registered..
        /// </summary>
        public static string UserAlreadyExist {
            get {
                return ResourceManager.GetString("UserAlreadyExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to with id {0}.
        /// </summary>
        public static string WithId {
            get {
                return ResourceManager.GetString("WithId", resourceCulture);
            }
        }
    }
}