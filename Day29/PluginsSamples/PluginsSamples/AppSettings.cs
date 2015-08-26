
// Helpers/Settings.cs
using Refractored.Xam.Settings;
using Refractored.Xam.Settings.Abstractions;

namespace PluginsSamples
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class ApplicationSettings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private static readonly string SettingsDefault = string.Empty;

        #endregion


        public static string LoginNameSetting
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>("LoginName", SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>("LoginName", value);
            }
        }

    }
}
