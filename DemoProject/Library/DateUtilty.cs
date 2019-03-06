using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Library
{
   public class DateUtilty
    {

        public static String getCurrentDate()
        {
            return DateTime.Today.ToString("yyyy-MM-dd");
        }

        public static String getCurrentTime()
        {
            return DateTime.Now.ToString("HH-mm-ss");
        }
    }
}
