using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Library
{
  public  class EnvironmentHealthCheck
    {
        public static ExtentTest checkUrlStatus(String appUrl, ExtentReports report) 
        {
            ExtentTest responseCode = report.StartTest("Application Health Check") ;
            HttpWebResponse response = null;
            int code = 0;
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(appUrl);
                request.Method = "GET";                
                response = (HttpWebResponse)request.GetResponse();
                code = (int)response.StatusCode;
               
                if (code == 200)
                {
                    responseCode.Log(LogStatus.Pass, "<a href=" + appUrl + ">" + appUrl + "</a>", "Up and Running");
                }else
                {
                    responseCode.Log(LogStatus.Fail, "<a href=" + appUrl + ">" + appUrl + "</a>", code + " Down");
                    
                }


            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    response = (HttpWebResponse)e.Response;
                    Console.Write("Errorcode: {0}", code);
                    responseCode.Log(LogStatus.Fail, "<a href=" + appUrl + ">" + appUrl + "</a>", code + " Down");

                }
                else
                {
                    Console.Write("Error: {0}", e.Status);
                    responseCode.Log(LogStatus.Fail, "<a href=" + appUrl + ">" + appUrl + "</a>", code + " Down "+e.Status.ToString());

                }
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }
            return responseCode;

        }


    }
}
