using Demo.HL7MessageParser.Common;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Demo.HL7MessageParser
{
    /// <summary>
    /// RestSharpExtensions.cs
    /// https://gist.github.com/lkaczanowski/febb25cc49f339c5f516
    /// </summary>
    public static class RestSharpExtensions
    {
        public static bool IsScuccessStatusCode(this HttpStatusCode responseCode)
        {
            var numericResponse = (int)responseCode;

            const int statusCodeOk = (int)HttpStatusCode.OK;

            const int statusCodeBadRequest = (int)HttpStatusCode.BadRequest;

            return numericResponse >= statusCodeOk &&
                   numericResponse < statusCodeBadRequest;
        }

        public static bool IsSuccessful(this IRestResponse response)
        {
            return response.StatusCode.IsScuccessStatusCode() &&
                   response.ResponseStatus == ResponseStatus.Completed;
        }
        public static void ThrowException(this IRestResponse response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return;
            }

            if (response.StatusCode == 0)
            {
                throw new AMException(HttpStatusCode.ServiceUnavailable, response.ErrorMessage, response.ErrorException);
            }
            else
            {
                throw new AMException(response.StatusCode, response.Content, response.ErrorException);
            }
        }
    }


}
