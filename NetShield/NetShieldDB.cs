/* Wrapper class for the Firebase calls */

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShield
{
    class NetShieldDB
    {
        IFirebaseConfig firebaseConfig = new FirebaseConfig
        {
            AuthSecret = "PUT AUTHSECRET HERE",
            BasePath = "PUT LINK HERE"
        };

        IFirebaseClient firebaseClient;

        public NetShieldDB()
        {
            firebaseClient = new FirebaseClient(firebaseConfig);
        }

        public HashSet<string> getWhitelist()
        {
            // Need to add string "path" to Get()
            FirebaseResponse response = firebaseClient.Get("");

            return response.ResultAs<HashSet<string>>();
        }

        public void setWhitelist()
        {

        }
    }
}
