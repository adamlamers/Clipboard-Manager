using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace ClipboardManager
{
    static class ConfigManager
    {
        public static string ssStorageDir = "";
        public static string ssImageFormat = "";
        public static string ssFTPServer = "";
        public static string ssUsername = "";
        public static string ssPassword = "";
        public static bool BalloonTips = true;
        public static bool ssUpload = true;

        //FLICKR MANAGEMENT
        public static bool flickrUpload;
        public static string flickrAuthToken;
        public static string flickrUsername;

        public static string strReadConfigValue(string element)
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.ini");
            XmlNodeList xnlReturnConfigValue = config.GetElementsByTagName(element);
            string returnConfigValue = xnlReturnConfigValue[0].InnerText;
            return returnConfigValue;
        }

        public static bool boolReadConfigValue(string element)
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.ini");
            XmlNodeList xnlReturnConfigValue = config.GetElementsByTagName(element);
            bool returnConfigValue = false;
            if (xnlReturnConfigValue[0].InnerText == "1")
                returnConfigValue = true;
            else
                returnConfigValue = false;
            return returnConfigValue;
        }

        public static void WriteNewConfig()
        {
            StreamWriter configStream = new StreamWriter("config.ini");
            configStream.WriteLine("<config>");
            configStream.WriteLine("\t<ssStorageDir>" + Application.StartupPath + "\\screenshots</ssStorageDir>");
            configStream.WriteLine("\t<BalloonTips>1</BalloonTips>");
            configStream.WriteLine("\t<ImageFormat>jpg</ImageFormat>");
            configStream.WriteLine("\t<UploadScreenshots>0</UploadScreenshots>");
            configStream.WriteLine("\t<FTPServer></FTPServer>");
            configStream.WriteLine("\t<Username></Username>");
            configStream.WriteLine("\t<Password></Password>");
            configStream.WriteLine("\t<FlickrUpload>0</FlickrUpload>");
            configStream.WriteLine("\t<FlickrUsername></FlickrUsername>");
            configStream.WriteLine("\t<FlickrAuthToken></FlickrAuthToken>");
            configStream.WriteLine("</config>");
            configStream.Close();
        }
        public static void SetConfigValues()
        {
            ssStorageDir = strReadConfigValue("ssStorageDir");
            BalloonTips = boolReadConfigValue("BalloonTips");
            ssImageFormat = strReadConfigValue("ImageFormat");
            ssUpload = boolReadConfigValue("UploadScreenshots");
            ssFTPServer = strReadConfigValue("FTPServer");
            ssUsername = strReadConfigValue("Username");
            ssPassword = strReadConfigValue("Password");
            flickrUpload = boolReadConfigValue("FlickrUpload");
            flickrUsername = strReadConfigValue("FlickrUsername");
            flickrAuthToken = strReadConfigValue("FlickrAuthToken");
            FlickrManager.authenticatedUsername = flickrUsername;
            FlickrManager.authToken = flickrAuthToken;
        }    
    }
}
