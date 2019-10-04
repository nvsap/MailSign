using DevExpress.Mvvm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailWPF.Model
{
    public class SignatureHTMLTemplate : BindableBase
    {
        [JsonProperty("signature_id")]
        public string SignatureId
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        [JsonProperty("html")]
        public string HTML
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}
