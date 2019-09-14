using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace Demo.RESTServcie
{
    public class GlobalExceptionLogger:ExceptionLogger
    {
        public override void Log(ExceptionLoggerContext context)
        {
            base.Log(context);

            //Logger by customer
        }

        public override Task LogAsync(ExceptionLoggerContext context, CancellationToken cancellationToken)
        {
            return base.LogAsync(context, cancellationToken);

            //Logger by customer
        }
    }
}