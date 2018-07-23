using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Wasalee.ResponseFormats
{
    public class CustomResponse<T>
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public T Result { get; set; }
    }
    
    public class Error
    {
        public string ErrorMessage { get; set; }

        public static int LogError(Exception ex)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + "/ErrorLog.txt"))
                {
                    sw.WriteLine("DateTime : " + DateTime.Now + Environment.NewLine);
                    if (ex.Message != null)
                    {
                        sw.WriteLine(Environment.NewLine + "Message" + ex.Message);
                        sw.WriteLine(Environment.NewLine + "StackTrace" + ex.StackTrace);
                    }
                    again: if (ex.InnerException != null)
                    {
                        sw.WriteLine(Environment.NewLine + "Inner Exception : " + ex.InnerException.Message);
                    }
                    if (ex.InnerException.InnerException != null)
                    {
                        ex = ex.InnerException;
                        goto again;
                    }

                    sw.WriteLine("------******------");
                }
                return StatusCodes.Status500InternalServerError;
            }
            catch (Exception)
            {
                return StatusCodes.Status500InternalServerError;
            }
        }
    }
}
