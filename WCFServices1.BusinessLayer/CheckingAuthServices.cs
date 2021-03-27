using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;

namespace WCFServices1.BusinessLayer
{
    public class CheckingAuthServices 
    {
        public static bool CheckAPIKey (string apiKey)
        {
            //return (apiKey == "ABC123");

            // Get the Api Key from Web.Config Keys
            var validApiKey = WebConfigurationManager.AppSettings["APIKey"];

            // Return Only Valid if they match
            return validApiKey.Equals(apiKey);
        }
    }
}
