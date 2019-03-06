using RelevantCodes.ExtentReports;
using System.IO;

namespace DemoProject.ReportUtility
{
    public class ReportGenerator
    {
      //  CreateReportPath reportPath = new CreateReportPath();

        public static ExtentReports report = new ExtentReports(CreateReportPath.dynamicPath() + "\\Report.html", false);
        //create html report in bin/debug/reports
        public ExtentReports createReport()
        {
            ExtentReports report;
            //report = new ExtentReports(CreateReportPath.dynamicPath() + "\\"+ browserName + "Report.html", false);
            //       report = new ExtentReports(reportPath.dynamicPath() + "\\Report.html", true);
                report = new ExtentReports("E:/Report.html", false);
        //    report = new ExtentReports(file, false);
            return report;
        }



        private byte[] ReadAllBytes2(string filePath, FileAccess fileAccess = FileAccess.ReadWrite, FileShare shareMode = FileShare.ReadWrite)
        {
            using (var fs = new FileStream(filePath, FileMode.Open, fileAccess, shareMode))
            {
                using (var ms = new MemoryStream())
                {
                    fs.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }
    }
}
    
