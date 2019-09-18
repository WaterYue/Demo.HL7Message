using Demo.HL7MessageParser.Common;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.HL7MessageParser
{
    public static class StaticExtensions
    {
        public static void SafeInvoke(this Control controlofUI, Action callback, bool forceSynchronous)
        {
            if (controlofUI == null)
            {
                throw new ArgumentNullException("uiElement");
            }

            if (controlofUI.InvokeRequired)
            {
                if (forceSynchronous)
                {
                    controlofUI.Invoke((Action)delegate { SafeInvoke(controlofUI, callback, forceSynchronous); });
                }
                else
                {
                    controlofUI.BeginInvoke((Action)delegate { SafeInvoke(controlofUI, callback, forceSynchronous); });
                }
            }
            else
            {
                if (controlofUI.IsDisposed)
                {
                    throw new ObjectDisposedException("Control is already disposed.");
                }
                else
                {
                    callback();
                }
            }
        }


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
                throw new RestException(HttpStatusCode.ServiceUnavailable, response.ErrorMessage, response.ErrorException);
            }
            else
            {
                throw new RestException(response.StatusCode, response.Content, response.ErrorException);
            }
        }
    }
}
