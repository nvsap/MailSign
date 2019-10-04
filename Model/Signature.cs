using DevExpress.Mvvm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailWPF.Model
{
    public class Signature : BindableBase
    {
        [JsonProperty("id")]
        public string Id
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        [JsonProperty("sig_key")]
        public string SignKey
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        [JsonProperty("template_id")]
        public string TemplateId
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        [JsonProperty("title")]
        public string Title
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        [JsonProperty("promo_id")]
        public string PromoId
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        [JsonProperty("date_created")]
        public string DateCreated
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        [JsonProperty("html")]
        public string HTML
        {
            get { return GetValue<string>(); }
            set
            {
                SetValue(value);
                RaisePropertyChanged(() => HTML);
            }
        }
    }
}
