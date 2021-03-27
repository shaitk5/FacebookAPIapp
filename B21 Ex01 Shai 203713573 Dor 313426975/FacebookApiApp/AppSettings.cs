using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FacebookApiApp
{
     public sealed class AppSettings
     {
          private static string s_FileLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FacebookApiApp";
          private static string s_File = s_FileLocation + "\\AppSettings.txt";

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
               CheckFolder();
          }

          public void CheckFolder()
          {
               if(!Directory.Exists(s_FileLocation))
               {
                    Directory.CreateDirectory(s_FileLocation);
               }
          }

          public static AppSettings LoadFromFile()
          {
               AppSettings userSetting = new AppSettings();

               if(File.Exists(s_File))
               {
                    using(Stream stream = new FileStream(s_File, FileMode.Open))
                    {
                         XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                         userSetting = serializer.Deserialize(stream) as AppSettings;
                    }
               }

               return userSetting;
          }

          public void SaveToFile()
          {
               if(!File.Exists(s_File))
               {
                    Stream stream = new FileStream(s_File, FileMode.Create);
                    stream.Dispose();
               }

               using(Stream stream = new FileStream(s_File, FileMode.Truncate))
               {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
               }
          }
     }
}
