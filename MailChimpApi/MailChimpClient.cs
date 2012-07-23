using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using RDumont.MailChimpApi.Types;

namespace RDumont.MailChimpApi
{
    public class MailChimpClient
    {
        private readonly string _url;
        private ListsApi _lists;

        public string ApiKey { get; private set; }
        public string Dc { get; private set; }

        public ListsApi Lists { get { return _lists ?? (_lists = new ListsApi(this)); } }

        public MailChimpClient(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey)) throw new ArgumentNullException("apiKey");

            var match = Regex.Match(apiKey, @"^(?<KEY>\w{32})-(?<DC>\w{3})$");
            if (!match.Success)
                throw new ArgumentException("Invalid API key. Please make sure it includes the DC (e.g. somekey-us1)");

            ApiKey = apiKey;
            Dc = match.Groups["DC"].Value;

            _url = "https://" + Dc + ".api.mailchimp.com/1.3/";
        }

        public virtual TResult GenericCall<TResult>(string method, object data = null)
        {
            var encoding = Encoding.GetEncoding("iso-8859-1");

            var url = _url + "?method=" + method;
            if (data == null) url += "&apikey=" + ApiKey;

            var request = WebRequest.Create(url);
            request.ContentType = "application/json; charset=" + encoding.BodyName;
            request.Method = "POST";

            if (data != null)
            {
                string serialized = JsonConvert.SerializeObject(data);

                if(data.GetType().GetProperty("apikey") == null)
                {
                    serialized = "{\"apikey\":\"" + ApiKey + "\"," + serialized.Substring(1);
                }

                var dataBytes = encoding.GetBytes(serialized);
                var requestStream = request.GetRequestStream();
                requestStream.Write(dataBytes, 0, dataBytes.Length);
            }

            var response = request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream(), encoding);
            var text = reader.ReadToEnd();
            try
            {
                return JsonConvert.DeserializeObject<TResult>(text);
            }
            catch(JsonSerializationException)
            {
                throw new MailChimpException(JsonConvert.DeserializeObject<ApiError>(text));
            }
        }
    }
}
