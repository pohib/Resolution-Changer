﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResolutionChanger {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ResolutionChanger.Resources.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
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
        ///   Ищет локализованную строку, похожую на Process &quot;{0}&quot; not found.
        /// </summary>
        internal static string Error_ProcessNotFound {
            get {
                return ResourceManager.GetString("Error_ProcessNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Failed to change resolution: {0}.
        /// </summary>
        internal static string Error_ResolutionChangeFailed {
            get {
                return ResourceManager.GetString("Error_ResolutionChangeFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Exit.
        /// </summary>
        internal static string Menu_Exit {
            get {
                return ResourceManager.GetString("Menu_Exit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на File.
        /// </summary>
        internal static string Menu_File {
            get {
                return ResourceManager.GetString("Menu_File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Language.
        /// </summary>
        internal static string Menu_Language {
            get {
                return ResourceManager.GetString("Menu_Language", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Monitoring started for process: {0}.
        /// </summary>
        internal static string MonitoringStarted {
            get {
                return ResourceManager.GetString("MonitoringStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Monitoring stopped.
        /// </summary>
        internal static string MonitoringStopped {
            get {
                return ResourceManager.GetString("MonitoringStopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Process closed! Restoring default resolution {0}x{1}....
        /// </summary>
        internal static string ProcessExited {
            get {
                return ResourceManager.GetString("ProcessExited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Process detected! Changing resolution to {0}x{1}....
        /// </summary>
        internal static string ProcessStarted {
            get {
                return ResourceManager.GetString("ProcessStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Resolution successfully changed to {0}x{1}.
        /// </summary>
        internal static string ResolutionChangeSuccess {
            get {
                return ResourceManager.GetString("ResolutionChangeSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Default resolution {0}x{1} restored.
        /// </summary>
        internal static string ResolutionRestoreSuccess {
            get {
                return ResourceManager.GetString("ResolutionRestoreSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Ready.
        /// </summary>
        internal static string Status_Ready {
            get {
                return ResourceManager.GetString("Status_Ready", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Working....
        /// </summary>
        internal static string Status_Working {
            get {
                return ResourceManager.GetString("Status_Working", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Invalid resolution specified: {0}x{1}.
        /// </summary>
        internal static string Warning_InvalidResolution {
            get {
                return ResourceManager.GetString("Warning_InvalidResolution", resourceCulture);
            }
        }
    }
}
