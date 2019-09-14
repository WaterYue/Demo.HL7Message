using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Demo.RESTServcie
{
    public static class Const
    {
        public const string ROUNT_PREFIX = "pms-asa/1/";
    }

    public static class RestServiceExtensions
    {
        public static void ThrowHttpResponseExceptions(this ApiController controller, HttpStatusCode httpStatusCode, string errorMessage)
        {
            throw new HttpResponseException(new HttpResponseMessage
            {
                StatusCode = httpStatusCode,
                Content = new StringContent(errorMessage),
                ReasonPhrase = errorMessage,
            });
        }
    }
}