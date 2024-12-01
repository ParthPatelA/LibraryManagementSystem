using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public class ChangeLanguage
    {
        public void UpdateConfig(string key, string value)
        { /*
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement xmlElement in xmlDoc.DocumentElement)
            {
                if (xmlElement.Name.Equals("appSettings"))
                {
                    foreach (XmlNode xNode in xmlElement.ChildNodes)
                    {
                        if (xNode.Attributes[0].Value.Equals(key))
                        {
                            xNode.Attributes[1].Value = value;
                        }
                    }
                }
            }

            ConfigurationManager.RefreshSection("appSettings");

         
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);*/
        
        try
            {
                // Load the configuration file
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;

                // Check if the key exists
                if (settings[key] == null)
                {
                    // Add the key if it doesn't exist
                    settings.Add(key, value);
                }
                else
                {
                    // Update the existing key
                    settings[key].Value = value;
                }

                // Save and refresh the configuration
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating configuration: " + ex.Message, ex);
            }
        }
    }
}

