using DevExpress.Mvvm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailWPF.Model
{
    [Serializable]
    public class User : BindableBase
    {
        public long UserId
        {
            get { return GetValue<long>(); }
            set
            {
                SetValue(value);
                RaisePropertyChanged(() => UserId);
            }
        }

        [JsonProperty("email")]
        public string Email
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        [JsonProperty("name")]
        public string Name
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        
        [JsonProperty("signature_id")]
        public string SignatureId
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }


    }
}
