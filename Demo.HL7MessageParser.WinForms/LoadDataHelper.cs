using Demo.HL7MessageParser.Common;
using Demo.HL7MessageParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.HL7MessageParser
{
    public class LoadDataThreadHelper<T, R> where R : class where T : class
    {
        private Thread t = null;
        private Func<T, R> func;

        public Action<R> Completed { get; set; }
        public Action<Exception> Exceptioned { get; set; }

        public void Initialize(Func<T, R> func)
        {
            this.func = func;
        }
    
        public void Stop()
        {
            if (t != null)
            {
                try
                {
                    t.Abort();
                }
                catch
                {
                }

                t = null;
            }
        }

        public void LoadDataAsync(T obj)
        {
            if (t != null)
            {
                while (t.IsAlive)
                {
                    Thread.Sleep(50);
                }
            }

            t = new Thread(() => { DoProcess(obj); });

            t.Start();
        }

        private void DoProcess(object obj)
        {
            try
            {
                R result = func(obj as T);

                OnCompleted(result);
            }
            catch (Exception ex)
            {
                OnException(ex);
            }
            finally
            {
                Stop();
            }
        }

        private void OnException(Exception ex)
        {
            Exceptioned?.Invoke(ex);
        }

        private void OnCompleted(R result)
        {
            Completed?.Invoke(result);
        }
    }
}
