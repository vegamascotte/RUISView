using System;
using System.IO.IsolatedStorage;

namespace RUISView
{
    class Settings
    {

        IsolatedStorageSettings settings;

        const string m_snelheidSettingKey = "SnelheidSetting";
        const string m_herladenBijStartSettingKey = "HerladenBijStartSetting";
        const string m_toonNaamSettingKey = "ToonNaamSetting";
        const string m_toonNaamDuratieSettingKey = "ToonNaamDuratieSetting";

        const int m_snelheidSettingDefault = 5;
        const bool m_herladenBijStartSettingDefault = false;
        const bool m_toonNaamSettingDefault = false;
        const int m_toonNaamDuratieSettingDefault = 2;

        Settings()
        {
            settings = IsolatedStorageSettings.ApplicationSettings; 
        }

        public bool AddOrUpdateValue (string a_key, Object a_value)
        {
            bool valueChanged = false;

            if (settings.Contains(a_key))
            {
                if (settings[a_key] != a_value)
                {
                    settings[a_key] = a_value;
                    valueChanged = true;
                }
            }
            else
            {
                settings.Add(a_key, a_value);
                valueChanged = true;
            }
            return valueChanged;
        }

        public object GetValueOrDefault(string a_key, object a_defaultValue)
        {
            object value;

            if (settings.Contains(a_key))
            {
                value = settings[a_key];
            }
            else
            {
                value = a_defaultValue;
            }
            return value;
        }

        public void Save()
        {
            settings.Save();
        }

        public int SnelheidSetting
        {
            get
            {
                return (int)GetValueOrDefault(m_snelheidSettingKey, m_snelheidSettingDefault);
            }
            set
            {
                if (AddOrUpdateValue(m_snelheidSettingKey, value))
                {
                    Save();
                }
            }
        }

        public int ToonNaamDuratieSetting
        {
            get
            {
                return (int)GetValueOrDefault(m_toonNaamDuratieSettingKey, m_toonNaamDuratieSettingDefault);
            }
            set
            {
                if (AddOrUpdateValue(m_toonNaamDuratieSettingKey,  value))
                {
                    Save();
                }
            }
        }

        public bool HerladenBijStartSetting
        {
            get
            {
                return (bool)GetValueOrDefault(m_herladenBijStartSettingKey, m_herladenBijStartSettingDefault);
            }
            set
            {
                if (AddOrUpdateValue(m_herladenBijStartSettingKey, value))
                {
                    Save();
                }
            }
        }

        public bool ToonNaamSetting
        {
            get
            {
                return (bool)GetValueOrDefault(m_toonNaamSettingKey, m_toonNaamSettingDefault);
            }
            set
            {
                if (AddOrUpdateValue(m_toonNaamSettingKey, value))
                {
                    Save();
                }
            }
        }

    }
}