using DevExpress.Mvvm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailWPF.Model
{
    public class UserResponseObject : BindableBase
    {
        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("signatures")]
        public Dictionary<string, Signature> Signatures { get; set; }
        [JsonProperty("signature_id")]
        public string SignatureId
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}
