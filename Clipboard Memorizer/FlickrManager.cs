using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlickrNet;

namespace ClipboardManager
{
    static class FlickrManager
    {
        public static string authStatus;
        public static string authenticatedUsername;
        public static string authToken;
        public static string errorMessage = "";
        public static string successMessage = "";
        public static string AuthUrl;
        public static string frob;
        public static string ApiKey = "1d81d44c4912d67ea84c0291e36329dc";
        public static string SharedSecret = "31e93dffe30f5eb1";
        public static string LastUploadAction = "";

        public static void OpenAuthURL()
        {
            Flickr flickr = new Flickr(ApiKey, SharedSecret);
            frob = flickr.AuthGetFrob();
            AuthUrl = flickr.AuthCalcUrl(frob, AuthLevel.Write);
            System.Diagnostics.Process.Start(AuthUrl);
        }

        public static void CompleteAuthentication()
        {
            Flickr flickr = new Flickr(ApiKey, SharedSecret);
            try
            {
                Auth auth = flickr.AuthGetToken(frob);
                authStatus = "SUCCESS";
                authenticatedUsername = auth.User.Username;
                authToken = auth.Token;
                successMessage = "Authentication Successful!";
            }
            catch (FlickrException ex)
            {
                authStatus = "FAILED";
                authenticatedUsername = "";
                authToken = "";
                if (ex.Message == "Invalid frob (108)")
                    errorMessage = ex.Message + " Did you give the app permission?";
                else
                    errorMessage = ex.Message;
            }
        }

        public static void UploadPicture(string filename, string title, string description, bool uploadAsPublic)
        {
            try
            {
                Flickr flickr = new Flickr(ApiKey, SharedSecret, authToken);

                string photoId = flickr.UploadPicture(ConfigManager.ssStorageDir + "\\" + filename, title, description, "", uploadAsPublic, false, false);

                LastUploadAction = "Photo uploaded successfully ID: " + photoId;
            }
            catch
            {
                LastUploadAction = "Last UploadPicture Failed.";
            }
        }
    }
}
