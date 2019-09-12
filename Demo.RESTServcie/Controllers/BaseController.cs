using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo.RESTServcie.Controllers
{
    public class BaseController : ApiController
    {
        protected const string HEADER_CLIENT_SECRET = "client_secret";
        protected const string HEADER_PATHOSPCODE_VALUE = "patHospCode";
        protected const string HEAER_CLIENT_ID = "client_id";

        protected string GetHeaderValue(string headerName)
        {
            IEnumerable<string> header_Values;

            if (!Request.Headers.TryGetValues(headerName, out header_Values))
            {
                throw new Exception(string.Format("You are missing header - '{0}'!", headerName));
            }

            return header_Values.FirstOrDefault();
        }

        protected void ValidateHeader_Value(string headerName, string expectHeaderValue)
        {
            var headerValue = GetHeaderValue(headerName);

            if ((headerValue ?? string.Empty).Trim().ToUpper() != (expectHeaderValue ?? string.Empty).ToUpper())
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                {
                    Content = new StringContent(string.Format("Invalid {0} header", headerName)),
                    ReasonPhrase = string.Format("invalid {0} value of {1}!", headerValue, headerName),
                });

                throw new ArgumentException(string.Format("invalid {0} value of {1}!", headerValue, headerName));
            }
        }
    }
}
