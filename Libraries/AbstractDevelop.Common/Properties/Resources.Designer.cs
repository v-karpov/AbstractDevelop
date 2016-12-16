﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AbstractDevelop.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AbstractDevelop.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Ищет локализованную строку, похожую на Не удалось найти каталог {0}.
        /// </summary>
        internal static string DirectoryNotFoundError {
            get {
                return ResourceManager.GetString("DirectoryNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Не удалось найти файл с путем {0}.
        /// </summary>
        internal static string FileNotFoundError {
            get {
                return ResourceManager.GetString("FileNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Инструкция {0} c аргументами {1} (кол-во = {2}).
        /// </summary>
        internal static string InstructionDescription {
            get {
                return ResourceManager.GetString("InstructionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Аргумент {0} не является допустимым (см. документацию).
        /// </summary>
        internal static string InvalidArgumentException {
            get {
                return ResourceManager.GetString("InvalidArgumentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Неверный формат записи инструкции в строке {0}.
        /// </summary>
        internal static string InvalidInstructionSyntaxException {
            get {
                return ResourceManager.GetString("InvalidInstructionSyntaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Невозможно загрузить данные из источника JSON.
        /// </summary>
        internal static string JsonLoadingError {
            get {
                return ResourceManager.GetString("JsonLoadingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Невозможно сохранить данные JSON в назначенный поток вывода.
        /// </summary>
        internal static string JsonSavingError {
            get {
                return ResourceManager.GetString("JsonSavingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Метка &quot;{0}&quot; уже определена в данном модуле.
        /// </summary>
        internal static string LabelRedefinedException {
            get {
                return ResourceManager.GetString("LabelRedefinedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Не найден аргумент с индексом {0} для инструкции {1} (см. документацию) .
        /// </summary>
        internal static string MissingArgumentException {
            get {
                return ResourceManager.GetString("MissingArgumentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Платформа {0} не была загружена по причине несовместимости с данной версией программы.
        /// </summary>
        internal static string PlatformExcluded {
            get {
                return ResourceManager.GetString("PlatformExcluded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Платформа с кодом {0} не найдена в хранилище.
        /// </summary>
        internal static string PlatformNotFoundError {
            get {
                return ResourceManager.GetString("PlatformNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Необходимо предоставить аргументов: {0}.
        /// </summary>
        internal static string TooMuchArguentsException {
            get {
                return ResourceManager.GetString("TooMuchArguentsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Нераспознанная инструкция {0}.
        /// </summary>
        internal static string UnknownInstructionException {
            get {
                return ResourceManager.GetString("UnknownInstructionException", resourceCulture);
            }
        }
    }
}
