using RUISView.Resources;

namespace RUISView
{
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();
        private static string _ConnectionString = "DataSource=isostore:/RUISviewDB.sdf";

        public AppResources LocalizedResources { get { return _localizedResources; } }

        public string ConnectionString { get { return _ConnectionString; } }
    }
}