using MailWPF.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace MailWPF.Controller
{
    public static class RequestsController
    {
        static RestClient client = new RestClient(System.Configuration.ConfigurationSettings.AppSettings["ApiLink"].ToString());
        public static bool SearchUser(User user, ObservableCollection<Signature> signatures)
        {

            try
            {

                var request = new RestRequest($"users/get?uid={user.UserId}&without_signatures=true", Method.GET);
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                UserResponseObject responseObject = JsonConvert.DeserializeObject<UserResponseObject>(content);
                user.Email = responseObject.User.Email;
                user.Name = responseObject.User.Name;
                user.SignatureId = responseObject.SignatureId;

                signatures.Clear(); 
                foreach (var item in responseObject.Signatures)
                    signatures.Add(item.Value);

                return true;
            }
            catch
            {
                MessageBox.Show("User not found", "Search Exception", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
        }

        internal static void SearchSingatureHTML(object signature)
        {
            throw new NotImplementedException();
        }

        public static bool SearchSingatureHTML(Signature signature)
        {
            try
            {
                var request = new RestRequest($"signatures/render?signature_id={signature.Id}", Method.GET);
                IRestResponse response = client.Execute(request);
                dynamic data = JObject.Parse(response.Content);
                signature.HTML = (string)data["html"];

                return true;
            }
            catch(Exception Ex)
            {
                return false;
            }
        }
    }
}
