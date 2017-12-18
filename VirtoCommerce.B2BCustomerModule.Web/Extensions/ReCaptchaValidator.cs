using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;

namespace VirtoCommerce.B2BCustomerModule.Web.Model.Extensions
{
    public class ReCaptchaValidator
    {
        private readonly string _reCaptchaSecret;
        private readonly string _reCaptchaSiteKey;
        public List<string> ErrorCodes { get; set; } = new List<string>();

        public ReCaptchaValidator(string reCaptchaSecret)
            : this(reCaptchaSecret, null)
        {
        }

        public ReCaptchaValidator(string reCaptchaSecret, string reCaptchaSiteKey)
        {
            _reCaptchaSecret = reCaptchaSecret;
            _reCaptchaSiteKey = reCaptchaSiteKey;
        }

        public bool ValidateCaptcha(string recaptchaResponse, HttpRequest request)
        {
            var uri = $"https://www.google.com/recaptcha/api/siteverify?secret={_reCaptchaSecret}&response={recaptchaResponse}&remoteip={GetUserIp(request)}";

            //make the api call and determine validity
            using (var client = new WebClient())
            {
                var json = client.DownloadString(uri);
                var serializer = new DataContractJsonSerializer(typeof(RecaptchaApiResponse));
                var ms = new MemoryStream(Encoding.Unicode.GetBytes(json));
                var result = serializer.ReadObject(ms) as RecaptchaApiResponse;

                if (result == null)
                {
                    return false;
                }
                else if (result.ErrorCodes != null)
                {
                    foreach (var code in result.ErrorCodes)
                    {
                        this.ErrorCodes.Add(code.ToString());
                    }
                    return false;
                }
                else if (!result.Success)
                {
                    return false;
                }
                else //-- If successfully verified.
                {
                    return true;
                }
            }
        }

        //--- To get user IP(Optional)
        private string GetUserIp(HttpRequest request)
        {
            var visitorsIpAddr = string.Empty;

            if (request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
            {
                visitorsIpAddr = request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            }
            else if (!string.IsNullOrEmpty(request.UserHostAddress))
            {
                visitorsIpAddr = request.UserHostAddress;
            }
            return visitorsIpAddr;
        }

    }
    [DataContract]
    public class RecaptchaApiResponse
    {
        [DataMember(Name = "success")]
        public bool Success;

        [DataMember(Name = "error-codes")]
        public List<string> ErrorCodes;
    }
}