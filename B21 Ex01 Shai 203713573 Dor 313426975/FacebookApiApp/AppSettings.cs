using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FacebookApiApp
{
    class AppSettings
    {
        private static string m_FileLocation = System.IO.Directory.GetCurrentDirectory();

        public bool RememberUser
        {
            get;
            set;
        }

        public string LastAccessToken
        {
            get;
            set;
        }

        public AppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings userSetting = new AppSettings();

            if (File.Exists(m_FileLocation))
            {
                using (Stream stream = new FileStream(m_FileLocation, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    userSetting = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return userSetting;
        }

        public void SaveToFile()
        {
            if (!File.Exists(m_FileLocation))
            {
                Stream stream = new FileStream(m_FileLocation, FileMode.Create);
                stream.Dispose();
            }

            using (Stream stream = new FileStream(m_FileLocation, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
