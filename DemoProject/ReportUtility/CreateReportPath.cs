using System;
using System.IO;
using DemoProject.Library;

namespace DemoProject.ReportUtility
{
   public class CreateReportPath
    {
        //genrate dynamic path for report with date and time combination
        public static String dynamicPath()
        {           
            String path = AppDomain.CurrentDomain.BaseDirectory+ "\\reports" ;
            Console.WriteLine("Report Path:-"+path);
             path = System.IO.Path.Combine(path, DateUtilty.getCurrentDate());
            Console.WriteLine("currentDayFolderPath=" + path);
            CreateIfMissing(path);
             path = System.IO.Path.Combine(path,DateUtilty.getCurrentTime());
            CreateIfMissing(path);
            Console.WriteLine("currentTimeFolderPath=" + path);           
            return path;
        }
        //create directory if not available
        private  static void CreateIfMissing(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine(ioex.Message);
            }
        }

       
        }
    }

